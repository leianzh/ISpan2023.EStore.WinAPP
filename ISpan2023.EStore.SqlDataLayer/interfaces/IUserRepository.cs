using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer.interfaces
{
	public interface  IUserRepository
	{
		User GetByAccount(string account);//供登入使用

		User Get(int userId);//編輯紀錄時使用
	}
	public class User 
	{
		public int Id { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
	}
}
