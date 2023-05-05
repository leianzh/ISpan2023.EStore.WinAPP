using ISPan.MultiLayers.WinApp.ViewModel;
using ISpan2023.EStore.SqlDataLayer.Dtos;
using ISpan2023.EStore.SqlDataLayer.infra.SqlRepositories;
using ISpan2023.EStore.SqlDataLayer.interfaces;
using ISpan2023.EStore.SqlDataLayer.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPan.MultiLayers.WinApp
{
	public partial class FormCategories : Form,IGrid
	{
		private List<CategoryVM> vm;
		public FormCategories()
		{
			InitializeComponent();
		}

		private void FormCategories_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Display();
		}
		public void Display()
		{
			string name = txtName.Text;
			int? id = int.TryParse(txtId.Text, out int num) ? num : (int?)null;

			ICategoryRepository categoryRepository = new SqlCategoryRepository();
			//介面呼叫repo,SqlCategoryRepository有實作
			CategoryService service = new CategoryService(categoryRepository);
			//public CategoryService(ICategoryRepository repo)建構函數傳了ICategoryRepository
			//所以form去呼叫它

			//List<CategoryDto> data = service.Search(name, id);
			//List<CategoryVM> vm = data.Select( x => x.ToViewModel()).ToList();

			 vm = service.Search(name, id)
				.Select(x => x.ToViewModel())
				.ToList();



			dataGridView1.DataSource = vm;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var frm = new FormAddCategory();
			frm.Owner = this;//fromadd的擁有者是form1
			//fromadd做完之後讓form1再去讀一次
			frm.ShowDialog();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;//e.RowIndex,索引在第幾列，表頭是-1

			int categoryId = vm[e.RowIndex].Id;//vm[]

			var frm = new FormEditCategory(categoryId);
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
