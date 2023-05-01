using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer
{
	public class NewsRepository
	{
		public int Create(NewsDto dto) 
		{
			//取得剛新增資料的自動編號
			string sql = @"SET NOCOUNT ON;
INSERT INTO News
(Title,Description,CreatedTime,ModifiedTime)
VALUES
(@Title,@Description,DEFAULT,DEFAULT);
SET @newId = SCOPE_IDENTITY()";

			//SqlParameter[] parameters = new SqlParameter[]
			//{
			//	new SqlParameter("@Title",SqlDbType.NVarChar,50){Value = dto.Title},
			//	new SqlParameter("@Description",SqlDbType.NVarChar,3000){Value =dto.Description},
			//	new SqlParameter("@newId",SqlDbType.Int){Direction = ParameterDirection.Output}
			//};
			var parameters = SqlParameterBuilder.Create()
				.AddNvarchar("@Title",50,dto.Title)
				.AddNvarchar("@Description",3000,dto.Description)
				.AddOutputInt("@newId")
				.Build();


			using (var conn = SqlDb.GetConnection("default")) 
			{
				conn.Open();
				using(var cmd = conn.CreateCommand()) 
				{
					cmd.CommandText = sql;
					cmd.Parameters.AddRange(parameters);
					cmd.ExecuteNonQuery();
					return (int)cmd.Parameters["@newId"].Value;
				}
			}
		}
		public NewsEditDto Get(int newsId) 
		{
			using(SqlConnection conn = SqlDb.GetConnection("default")) 
			{
				conn.Open();
				var sql = $"SELECT*FROM News WHERE ID={newsId}";
				using(var cmd = conn.CreateCommand()) 
				{
					cmd.CommandText = sql;
					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
					if (reader.Read()) 
					{
						var dto = new NewsEditDto
						{Id=newsId,
						Title=reader.GetString("Title"),
						Description=reader.GetString("Description"),
						ModifiedTime =reader.GetDateTime("ModifiedTime",DateTime.MinValue)
						};
						return dto;
					}
					else 
					{
						return null;
					}
				}
			}
		}

	}
}
