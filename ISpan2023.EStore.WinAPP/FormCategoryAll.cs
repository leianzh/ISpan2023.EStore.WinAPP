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
	public partial class FormCategoryAll : Form
	{
		public FormCategoryAll()
		{
			InitializeComponent();
		}

		private void FormCategoryAll_Load(object sender, EventArgs e)
		{
			var repo = new CategoryRepository();
			var categories = repo.Search();

			this.dataGridView1.DataSource = categories;
		}
	}
}
