using ISpan2023.EStore.SqlDataLayer;
using System;
using System.Collections;
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
	public partial class FormAddCategory : Form
	{
		public FormAddCategory()
		{
			InitializeComponent();
		}

		private void btnAddCategory_Click(object sender, EventArgs e)
		{

			var categories = new Category
			{ 
				Name = txtTitle.Text,
				DisplayOrder = int.Parse(txtDisplayOrder.Text)
			};
			int id = new CategoryRepository().Create(categories);
			MessageBox.Show($"紀錄已新增id={id}");
		}
	}
}
