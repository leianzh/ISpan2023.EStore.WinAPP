using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer
{
	public class SqlDb
	{
		public static string ApplicationName { get; set; }
		public static bool Pooling { get; set; } = true;
		public static string GetConnectString(string keyOfConnString)
		{
			string connStr = System.Configuration.ConfigurationManager.ConnectionStrings[keyOfConnString].ToString();
			if (string.IsNullOrEmpty(connStr)) 
			{
				throw new Exception("找不到連線字串, key="+ keyOfConnString);
			}
			SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(connStr);
			sb.Pooling = Pooling;
			if (string.IsNullOrEmpty(ApplicationName)== false) 
			{
				sb.ApplicationName = ApplicationName;
			}

			return sb.ToString();
			
		}
		public static SqlConnection GetConnection(string keyOfConnString) 
		{
			string connStr = GetConnectString(keyOfConnString);
			return new SqlConnection(connStr);
		}
	}
}
