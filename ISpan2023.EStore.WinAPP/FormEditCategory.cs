using ISpan2023.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan2023.EStore.WinAPP
{
	public partial class FormEditCategory : Form
	{
		private readonly int _categoryId;
		public FormEditCategory(int categoryId)
		{
			InitializeComponent();
			_categoryId = categoryId;
		}

		private void FormEditCategory_Load(object sender, EventArgs e)
		{
			Category category = new CategoryRepository().Get(this._categoryId);
			if(category == null) 
			{
				MessageBox.Show("Record not found");
				this.DialogResult = DialogResult.Cancel;//會關閉表單
				return;
			}
			//bind data
			textBoxName.Text = category.Name;
			textBoxDO.Text = category.DisplayOrder.ToString();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			var categories = new Category
			{
				Id = _categoryId,
				Name = textBoxName.Text,
				DisplayOrder = int.Parse(textBoxDO.Text),
				
			};

			int rowsAffected = new CategoryRepository().Update(categories);
			//如果傳回筆數是1,表示有正確更新一筆
			if (rowsAffected > 0)
			{
				MessageBox.Show("紀錄已更新");
			}
			else
			{
				MessageBox.Show("紀錄沒有被異動，可能紀錄已經被刪除");
			}
			FormEditCategory_Load(this, EventArgs.Empty);
		}
	}
}
