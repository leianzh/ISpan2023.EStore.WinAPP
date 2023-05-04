using ISpan2023.EStore.SqlDataLayer.Core;
using ISpan2023.EStore.SqlDataLayer.Dtos;
using ISpan2023.EStore.SqlDataLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ISpan2023.EStore.SqlDataLayer.Service
{
	public class CategoryService
	{
		private readonly ICategoryRepository _repo;
		public CategoryService(ICategoryRepository repo)
		{
			_repo = repo;
		}

		public void Create(CategoryAddDto dto)
		{
			// 檢查 name是否己存在
			var data = _repo.Search(dto.Name, null);
			if (data != null && data.Count > 0) throw new Exception("分類名稱已存在");

			// 若名稱是唯一的, 允許新建記錄
			CategoryEntity entity = dto.ToEntity();
			_repo.Create(entity);
		}

		public void Update(CategoryEditDto dto)
		{
			// 檢查 name是否己存在
			List<CategoryEntity> data = _repo.Search(dto.Name, null);

			if (data != null && data.Count > 0)
			{
				if (data[0].Id != dto.Id) throw new Exception("分類名稱已存在,不允許更新");
			}

			// 若名稱是唯一的, 允許更新記錄
			CategoryEntity entity = dto.ToEntity();
			_repo.Update(entity);
		}

		public void Delete(int categoryId)
		{
			_repo.Delete(categoryId);
		}

		public List<CategoryDto> GetAll()
		{
			List<CategoryEntity> data = _repo.Search(null, null);

			//List<CategoryDto> result = new List<CategoryDto>();
			//foreach (CategoryEntity item in data) {
			//	CategoryDto dto = item.ToDto();
			//	result.Add(dto);
			//}

			//return result;

			return data.Select(x => x.ToDto()).ToList();
		}

		public CategoryEditDto Get(int id)
		{
			//CategoryEntity entity = _repo.Get(id);
			//CategoryEditDto dto = entity.ToEditDto();

			//return dto;

			return _repo.Get(id).ToEditDto();
		}
	}
}
