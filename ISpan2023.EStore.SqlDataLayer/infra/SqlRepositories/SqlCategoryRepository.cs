using ISpan2023.EStore.SqlDataLayer.Core;
using ISpan2023.EStore.SqlDataLayer.interfaces;
using System;
using System.Collections.Generic;
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
			throw new NotImplementedException();
		}

		public List<CategoryEntity> Search(string categoryName, int? categoryId)//查詢多筆用list包
		{
			throw new NotImplementedException();
		}

		public void Update(CategoryEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}
