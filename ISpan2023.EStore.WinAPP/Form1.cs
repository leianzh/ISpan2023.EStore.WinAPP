using ISpan2023.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan2023.EStore.WinAPP
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)//GetConnectString取得連線字串
		{

			string connStr = SqlDb.GetConnectString("default");
			labelConnStr.Text = connStr;
		}

		private void button2_Click(object sender, EventArgs e)//SqlConnection SQL連線
		{
			SqlDb.Pooling = checkBoxpooling.Checked;
			SqlConnection conn = SqlDb.GetConnection("default");
			conn.Open();

			string sql = "SELECT ID FROM News";
			SqlCommand command = new SqlCommand(sql, conn);//SqlCommand 下CRUD指令

			SqlDataReader reader = command.ExecuteReader();//ExecuteReader 執行完之後放到SqlDataReader
			reader.Close();
			conn.Close();//記得一定要關

		}

		private void btnUsing_Click(object sender, EventArgs e)
		{
			SqlDb.Pooling = checkBoxpooling.Checked;
			using (SqlConnection conn = SqlDb.GetConnection("default"))
			{
				conn.Open();
				string sql = "SELECT ID FROM News";
				using (SqlCommand command = new SqlCommand(sql, conn))
				{
					SqlDataReader reader = command.ExecuteReader();
					reader.Close();

				}

			}

		}

		private void buttonCategory_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(textBoxCategory.Text, out int categoryId);
			if (!isInt)
			{
				MessageBox.Show("請輸入Category id,再試一次");
				return;
			}

			var frm = new FormEditCategory(categoryId);
			frm.ShowDialog();
		}

		private void btnSearchProducts_Click(object sender, EventArgs e)
		{
			var frm = new FormProducts();
			frm.ShowDialog();
		}

		private void btnAddNews_Click(object sender, EventArgs e)
		{
			var frm = new FormAddNews();
			frm.ShowDialog();
		}

		private void btnEditNews_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(txtNewsId.Text, out int newsId);
			if (!isInt)
			{
				MessageBox.Show("請輸入 News Id, 再試一次");
				return;
			}

			var frm = new FormEditNews(newsId);
			frm.ShowDialog();
		}

		private void btnDeleteNews_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(txtNewsId.Text, out int newsId);
			if (!isInt)
			{
				MessageBox.Show("請輸入 News Id,再試一次");
				return;
			}
			int rowAffected = new NewsRepository().Delete(newsId);
			if (rowAffected == 1) 
			{
				MessageBox.Show("紀錄已刪除");
			}
			else 
			{
				MessageBox.Show("沒有紀錄被刪除，可能此紀錄不存在");
			}
		}

		private void btnAddCategories_Click(object sender, EventArgs e)
		{
			var frm = new FormAddCategory();
			frm.ShowDialog();
		}

		private void btnUpdateCategory_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(textBoxCategory.Text, out int categoryId);
			if (!isInt)
			{
				MessageBox.Show("請輸入 category Id , 再試一次");
				return;
			}


			var frm = new FormEditCategory(categoryId);
			frm.ShowDialog();
		}

		private void btnDeletCategories_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(textBoxCategory.Text, out int categoryId);
			if (!isInt)
			{
				MessageBox.Show("請輸入 category Id,再試一次");
				return;
			}
			int rowAffected = new CategoryRepository().Delete(categoryId);
			if (rowAffected == 1)
			{
				MessageBox.Show("紀錄已刪除");
			}
			else
			{
				MessageBox.Show("沒有紀錄被刪除，可能此紀錄不存在");
			}

		}

		private void btnSearchCategory_Click(object sender, EventArgs e)
		{
			var frm = new FormCategoryAll();
			frm.ShowDialog();
		}
	}
}
