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
	public partial class FormAddNews : Form
	{
		public FormAddNews()
		{
			InitializeComponent();
		}

		private void btnAddNews_Click(object sender, EventArgs e)
		{
			var news = new NewsDto
			{
				Title = txtTitle.Text,
				Description = txtDescription.Text,
			};
			int id = new NewsRepository().Create(news);
			MessageBox.Show($"紀錄已新增id={id}");
		}
	}
}
