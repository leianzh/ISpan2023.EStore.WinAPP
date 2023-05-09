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
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			IUserRepository userRepository = new SqlUserRepository();
			UserService service = new UserService(userRepository);

			try 
			{
				bool validationResult = service.IsVaild(txtAccount.Text, txtPassword.Text);
				if (validationResult == false) 
				{
					MessageBox.Show("帳號或密碼有誤，請再試一次");
					return;
				}
				//清空表單值，以便下次在顯示時，不會有值
				txtAccount.Text = string.Empty;
				txtPassword.Text = string.Empty;

				var frm = new FormMain();
				frm.Owner = this;

				//這點很重要，不能將FormLogin關閉，只能隱藏
				//否則目前的application就會視同結束
				this.Hide();

				//稍後FormMain關閉時，再將FormLogin顯示
				frm.ShowDialog();
			}catch (Exception ex) 
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}
	}
}
