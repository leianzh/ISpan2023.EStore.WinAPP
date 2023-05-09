using ISpan2023.EStore.SqlDataLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer.Service
{
	public class UserService
	
	{
		private readonly IUserRepository _repo;
		public UserService(IUserRepository repo)
		{
			this._repo = repo;
		}
		public bool IsVaild(string account, string password) 
		{
			//precondition checks
			//account,password 必填
			if (string.IsNullOrEmpty(account)) { throw new ArgumentNullException(nameof(account),"帳號必填"); }
			if (string.IsNullOrEmpty(password)) {  throw new ArgumentNullException(nameof(password),"密碼必填"); }
			//取得單一使用者
			User user = _repo.GetByAccount(account);
			if (user == null) { return false; }
			//判斷密碼是否正確
			string passwordInDb = user.Password;//正確密碼
			//如果不拘大小寫
			return (passwordInDb.ToLower() == password.ToLower());
			//區分大小寫
			//return passwordInDb == password;

		}
	}
}
