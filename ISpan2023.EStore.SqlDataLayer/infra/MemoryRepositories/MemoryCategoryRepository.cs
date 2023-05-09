using ISpan2023.EStore.SqlDataLayer.Core;
using ISpan2023.EStore.SqlDataLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer.infra.MemoryRepositories
{
	public class MemoryCategoryRepository : ICategoryRepository
	{
		private static List<CategoryEntity>allData = new List<CategoryEntity>();
		//靜態建構函數
		static MemoryCategoryRepository() 
		{
			allData.Add(new CategoryEntity("n1", 10, 1));
			allData.Add(new CategoryEntity("n2", 20, 2));
			allData.Add(new CategoryEntity("n3", 30, 3));
		}
		public void Create(CategoryEntity entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(int categoryId)
		{
			throw new NotImplementedException();
		}

		public CategoryEntity Get(int categoryId)
		{
			throw new NotImplementedException();
		}

		public List<CategoryEntity> Search(string categoryName, int? categoryId)
		{
			IEnumerable<CategoryEntity> query = (IEnumerable<CategoryEntity>)allData;

			if(string.IsNullOrEmpty(categoryName) == false) 
			{
				query = query.Where(x => x.Name == categoryName);
			}
			if(categoryId.HasValue) 
			{
				query = query.Where(x => x.Id == categoryId.Value);
			}
			return query.ToList();
		}

		public void Update(CategoryEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}
