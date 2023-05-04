using ISpan2023.EStore.SqlDataLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer.Dtos
{
	/// <summary>
	/// 供Search結果使用
	/// </summary>
	public class CategoryDto
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public int DisplayOrder { get; set; }
	}

	public static class CategoryEntityExts//針對傳入Entity,傳出Dto的擴充方法
	{
		public static CategoryDto ToDto(this CategoryEntity entity)
		{
			return new CategoryDto
			{
				Id = entity.Id,
				Name = entity.Name,
				DisplayOrder = entity.DisplayOrder
			};
		}
	}

	public class CategoryAddDto
	{
		public string Name { get; set; }

		public int DisplayOrder { get; set; }
	}
	public static class CategoryAddDtoExts//針對傳入Dto,傳出Entity的擴充方法
	{
		public static CategoryEntity ToEntity(this CategoryAddDto dto)
		{
			return new CategoryEntity(dto.Name, dto.DisplayOrder);
		}
	}

	public class CategoryEditDto
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public int DisplayOrder { get; set; }
	}
	public static class CategoryEditDtoExts//針對傳入Entity,傳出Dto的擴充方法
	{
		public static CategoryEditDto ToEditDto(this CategoryEntity entity)
		{
			return new CategoryEditDto
			{
				Id = entity.Id,
				Name = entity.Name,
				DisplayOrder = entity.DisplayOrder
			};
		}
		public static CategoryEntity ToEntity(this CategoryEditDto dto)//針對傳入EditDto,傳出Entity的擴充方法
		{
			return new CategoryEntity(dto.Name, dto.DisplayOrder, dto.Id);
		}
	}
}
