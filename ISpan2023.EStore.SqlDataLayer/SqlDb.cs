using System;
using System.Collections.Generic;
using System.Data;
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
		public static string GetConnectString(string keyOfConnString)//GetConnectString取得連線字串
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
		public static SqlConnection GetConnection(string keyOfConnString)//SqlConnection SQL連線
		{
			string connStr = GetConnectString(keyOfConnString);
			return new SqlConnection(connStr);
		}
		public static SqlConnection GetConnection()
		{
			string connStr = GetConnectString("default");
			return new SqlConnection(connStr);
		}

		public static int UpdateOrDelete(Func<SqlConnection>funcConn,string sql,params SqlParameter[] parameters) 
		{
			using(var conn =funcConn()) 
			{
				conn.Open();
				using(var cmd = new SqlCommand(sql,conn))
				{
					if (parameters != null) cmd.Parameters.AddRange(parameters);
					return cmd.ExecuteNonQuery();// 傳回被異動的筆數,若為零,表示沒有異動記錄
				}
			}

		}
		public static int Create(Func<SqlConnection> funcConn, string sql, params SqlParameter[] parameters) 
		{
			sql += ";SELECT SCOPE_IDENTITY()";
			using(var conn = funcConn()) 
			{
				conn.Open();
				using(var cmd =new SqlCommand(sql, conn)) 
				{
					if(parameters != null) cmd.Parameters.AddRange(parameters);	
					return Convert.ToInt32(cmd.ExecuteScalar());
				}
			}
		}
		public static T Get<T>(Func<SqlConnection>funcConn,Func<SqlDataReader,T>funcAssembler,string sql,params SqlParameter[] parameters) 
		{
			using (var conn = funcConn())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null) cmd.Parameters.AddRange(parameters);
					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
					return reader.Read()
						? funcAssembler(reader)
						: default(T);
				}
			}
			
		} 
		public static List<T>Search<T>(Func<SqlConnection> funcConn,
			Func<SqlDataReader,T>funcAssembler,
			string sql,
			params SqlParameter[] parameters)
		{
			List<T> list = new List<T>();
			using (var conn = funcConn())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn)) 
				{
					if(parameters !=null) cmd.Parameters.AddRange(parameters);
					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
					while (reader.Read()) 
					{
						T entity = funcAssembler(reader);
						list.Add(entity);
					}
					return list;
				}
			}

		}


	}

}
