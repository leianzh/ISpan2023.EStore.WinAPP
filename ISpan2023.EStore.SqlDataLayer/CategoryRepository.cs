using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
						category.DisplaryOrder = reader.GetInt32("DisplayOrder", 0);
						return category;
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
