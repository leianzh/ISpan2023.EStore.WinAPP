using ISpan2023.EStore.SqlDataLayer.Core;
using ISpan2023.EStore.SqlDataLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer.infra.SqlRepositories
{
	public class SqlCategoryRepository : ICategoryRepository
	{
		public void Create(CategoryEntity entity)
		{
			string sql = "INSERT INTO Categories(Name, DisplayOrder)VALUES(@Name, @DisplayOrder)";

			var parameters = SqlParameterBuilder.Create()
				.AddNvarchar("@Name", 20, entity.Name)
				.AddInt("@DisplayOrder", entity.DisplayOrder)
				.Build();

			SqlDb.Create(SqlDb.GetConnection, sql, parameters);
		}

		public void Delete(int categoryId)
		{
			string sql = "DELETE FROM Categories WHERE Id=" + categoryId;

			SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, null);

		}

		public CategoryEntity Get(int categoryId)//查詢一筆所以不用list包
		{
			string sql = "SELECT * FROM Categories WHERE Id=" + categoryId;
			Func<SqlDataReader, CategoryEntity> funcAssembler = reader =>
			{
				int id = reader.GetInt32("Id",0);
				string name = reader.GetString("Name");
				int displayOrder = reader.GetInt32("DisplayOrder",0);

				return new CategoryEntity(name,displayOrder,id);
			};
			return SqlDb.Get<CategoryEntity>(SqlDb.GetConnection, funcAssembler, sql, null);
		}

		public List<CategoryEntity> Search(string categoryName, int? categoryId)//查詢多筆用list包
		{
			List<SqlParameter>parameters = new List<SqlParameter>();
			string sql = "SELECT * FROM Categories";
			#region 組出where條件
			string where = string.Empty;
			if (string.IsNullOrEmpty(categoryName) == false) 
			{
				where += " AND name =@name";
				parameters.Add(new SqlParameter("@name", System.Data.SqlDbType.NVarChar, 20) { Value = categoryName });

			}
			if (categoryId.HasValue) 
			{
				where += " AND Id=" + categoryId.Value;
			}
			where = string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where.Substring(5);
			//5是扣掉AND和前後空白
			sql += where;
			#endregion

			sql += " ORDER BY DisplayOrder";
			Func<SqlDataReader, CategoryEntity> funcAssembler = reader =>
			{
				int id = reader.GetInt32("Id",0);
				string name = reader.GetString("Name");
				int displayOrder = reader.GetInt32("DisplayOrder", 0);

				return new CategoryEntity ( name, displayOrder, id );
			};
			return SqlDb.Search(SqlDb.GetConnection, funcAssembler, sql, parameters.ToArray());



		}

		public void Update(CategoryEntity entity)
		{
			string sql = "UPDATE Categories SET name=@name,DisplayOrder = @DisplayOrder WHERE Id=@Id";
			var parameters = SqlParameterBuilder.Create()
				.AddInt("@Id",entity.Id)
				.AddNvarchar("@Name",20,entity.Name)
				.AddInt("@DisplayOrder",entity.DisplayOrder)
				.Build();
			SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, parameters);
		}
	}
}
