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
	}
}
