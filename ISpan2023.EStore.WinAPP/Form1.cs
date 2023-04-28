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

		private void button1_Click(object sender, EventArgs e)//取得連線字串
		{
			
			string connStr = SqlDb.GetConnectString("default");
			labelConnStr.Text = connStr;
		}

		private void button2_Click(object sender, EventArgs e)//連線到SQL
		{
			SqlDb.Pooling = checkBoxpooling.Checked;
			SqlConnection conn = SqlDb.GetConnection("default");
			conn.Open();

			string sql = "SELECT ID FROM News";
			SqlCommand command = new SqlCommand(sql, conn);

			SqlDataReader reader = command.ExecuteReader();
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
	}
}
