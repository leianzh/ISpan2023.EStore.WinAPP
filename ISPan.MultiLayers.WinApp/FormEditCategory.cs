using ISPan.MultiLayers.WinApp.ViewModel;
using ISpan2023.EStore.SqlDataLayer.Dtos;
using ISpan2023.EStore.SqlDataLayer.infra.SqlRepositories;
using ISpan2023.EStore.SqlDataLayer.interfaces;
using ISpan2023.EStore.SqlDataLayer.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ISPan.MultiLayers.WinApp
{
	public partial class FormEditCategory : Form
	{
		private readonly int _categoryID;
		public FormEditCategory(int categoryID)
		{
			InitializeComponent();
			_categoryID = categoryID;
		}

		private void btnUPDATE_Click(object sender, EventArgs e)
		{
			string name = textBoxName.Text;

			bool isInt = int.TryParse(textBoxDO.Text, out int displayOrder);
			if (isInt == false)
			{
				MessageBox.Show("DisplayOrder 必須輸入整數");
				return;
			}

			CategoryEditVM vm = new CategoryEditVM()
			{
				Id = _categoryID,
				Name = name,
				DisplayOrder = displayOrder
			};
			//驗證vm閃錯誤訊息
			(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);
			if (validationResult.isValid == false)
			{
				this.errorProvider1.Clear();
				DisplayErrors(validationResult.errors);
				return;
			}

			CategoryEditDto dto = vm.ToDto();
			ICategoryRepository repo = new SqlCategoryRepository();
			CategoryService service = new CategoryService(repo);

			try
			{
				service.Update(dto);
			}
			catch (Exception ex)
			{
				MessageBox.Show("更新失敗，原因:" + ex.Message);
				return;
			}

			//
			IGrid owner = this.Owner as IGrid;
			if (owner == null)
			{
				MessageBox.Show("忘了把owner實作IGrid");
			}
			else
			{
				owner.Display();

			}

			this.DialogResult = DialogResult.OK;

		}
		private (bool isValid, List<ValidationResult> errors) Validate(CategoryEditVM vm)
		{
			// 得知要驗證規則
			ValidationContext context = new ValidationContext(vm, null, null);

			// 用來存放錯誤的集合,因為可能有零到多個錯誤
			List<ValidationResult> errors = new List<ValidationResult>();

			// 驗證 model
			bool validateAllProperties = true; // 是否驗證所有規則,而非只驗證Required規則
			bool isValid = Validator.TryValidateObject(vm, context, errors, validateAllProperties);

			return (isValid, errors);
		}
		private void DisplayErrors(List<ValidationResult> errors)
		{
			// 大小寫不同仍視為相同的key
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Name", textBoxName},
				{"DisplayOrder", textBoxDO}
			};

			this.errorProvider1.Clear();

			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.FirstOrDefault();
				if (propName != null && map.TryGetValue(propName, out Control ctrl))
				{
					this.errorProvider1.SetError(ctrl, error.ErrorMessage);
				}
			}
		}

		private void FormEditCategory_Load(object sender, EventArgs e)
		{
			ICategoryRepository repo = new SqlCategoryRepository();
			CategoryService service = new CategoryService(repo);

			CategoryEditDto dto = service.Get(this._categoryID);
			CategoryEditVM vm = dto.ToViewModel();
			//連結到各控制項
			textBoxName.Text = vm.Name;
			textBoxDO.Text = vm.DisplayOrder.ToString();

		}

		private void btnDELETE_Click(object sender, EventArgs e)
		{




			ICategoryRepository repo = new SqlCategoryRepository();
			CategoryService service = new CategoryService(repo);

			var result = MessageBox.Show("你確定要刪除嗎?", "確定嗎????", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				var result2 = MessageBox.Show("確定嗎??刪了回不去喔?!", "REALLY??", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
				if (result2 == DialogResult.Yes)
				{
					try
					{
						service.Delete(_categoryID);
					}
					catch (Exception ex)
					{
						MessageBox.Show("刪除失敗，原因:" + ex.Message);
						return;
					}

				}



			}





			//
			IGrid owner = this.Owner as IGrid;
			if (owner == null)
			{
				MessageBox.Show("忘了把owner實作IGrid");
			}
			else
			{
				owner.Display();

			}

			this.DialogResult = DialogResult.OK;

		}
	}
}
