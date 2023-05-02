using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer
{
	public class CategoryRepository
	{
		public Category Get(int categoryId) 
		{
			using (SqlConnection conn = SqlDb.GetConnection("default"))
			{
				conn.Open();
				var sql = $"SELECT*FROM CATEGORIES WHERE Id={categoryId}";
				using(var cmd  = conn.CreateCommand()) 
				{
					cmd.CommandText = sql;
					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
					if (reader.Read())
					{
						var category = new Category();
						//category.Id = int.Parse(reader["Id"].ToString());
						//category.Name = reader["Name"].ToString();
						//category.DisplaryOrder = int.Parse(reader["DisplayOrder"].ToString());
						//return category;
						category.Id = reader.GetInt32("Id",0);
						category.Name = reader.GetString("Name");
						category.DisplayOrder = reader.GetInt32("DisplayOrder", 0);
						return category;
					}
					else 
					{
						return null;
					}
				}
			}
		}
		public  int Create(Category dto) 
		{
			string sql = @"SET NOCOUNT ON;
INSERT INTO Categories
(Name,DisplayOrder)
VALUES
(@Name,@DisplayOrder);
SET @newId = SCOPE_IDENTITY()";
			var parameters = SqlParameterBuilder.Create()
			.AddNvarchar("@Name",30,dto.Name)
				.AddInt("@DisplayOrder", dto.DisplayOrder)
				.AddOutputInt("@newId")
				.Build();
			using(var conn = SqlDb.GetConnection("default")) 
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
		public int Update(Category dto)
		{
			string sql = @"UPDATE Categories SET
Name =@Name,
DisplayOrder=@DisplayOrder,
WHERE
Id=@Id";
			SqlParameter[] parameters = SqlParameterBuilder.Create()
				.AddNvarchar("@Name", 30, dto.Name)
				.AddInt("@DisplayOrder", dto.DisplayOrder)
				.AddInt("@Id", dto.Id)
				.Build();
			return SqlDb.UpdateOrDelete(SqlDb.GetConnection,
				sql,
				parameters);
		}

	}
}
