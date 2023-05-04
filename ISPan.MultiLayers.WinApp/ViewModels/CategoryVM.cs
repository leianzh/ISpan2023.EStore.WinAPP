using ISpan2023.EStore.SqlDataLayer.Dtos;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPan.MultiLayers.WinApp.ViewModel
{
	public class CategoryVM
	{/// <summary>
    /// 供FormCategories使用的view model
    /// </summary>
        public int Id { get; set; }
        [Display(Name="分類名稱")]//加入[]稱為Atteribute特徵項，特性
        public string Name { get; set; }
        [Display(Name="顯示順序")]
        public int DisplayOrder { get; set; }
    }
	public static class CategoryDtoExs //針對dto轉VM的擴充方法
	{
		public static CategoryVM ToViewModel(this CategoryDto dto) 
		{
			return new CategoryVM
			{
				Id = dto.Id,
				Name = dto.Name,
				DisplayOrder = dto.DisplayOrder,
			};
		}
	}
    public class CategoryAddVM 
    {/// <summary>
	 /// 供FormAddCategory表單使用
	 /// </summary>
     /// 
		//public int Id { get; set; }
        [Display(Name="分類名稱")]
        [Required(ErrorMessage ="分類名稱必填")]
        [MaxLength(30, ErrorMessage="{0}長度不可大於30")]
        public string Name { get; set; }
		[Display(Name = "顯示順序")]
		[Required(ErrorMessage = "{0}必填")]
		public int DisplayOrder { get; set; }
    }
	public static class CategoryAddVMExs //針對VM轉dto的擴充方法
	{
		public static CategoryAddDto ToDto(this CategoryAddVM vm) 
		{
			return new CategoryAddDto
			{
				Name = vm.Name,
				DisplayOrder = vm.DisplayOrder,

			};
		}
	}
	public class CategoryEditVM
	{
		[Display(Name = "編號")]
		public int Id { get; set; }

		[Display(Name = "分類名稱")]
		[Required(ErrorMessage = "分類名稱必填")]
		[MaxLength(30, ErrorMessage = "{0}長度不可大於{1}")]
		public string Name { get; set; }

		[Display(Name = "顯示順序")]
		[Required(ErrorMessage = "{0}必填")]
		public int DisplayOrder { get; set; }
	}
	public static class CategoryEditVMExs//針對VM,dto互轉的擴充方法
	{
		public static CategoryEditDto ToDto(this CategoryEditVM vm) 
		{
			return new CategoryEditDto
			{
				Id = vm.Id,
				Name = vm.Name,
				DisplayOrder = vm.DisplayOrder,
			};
		}
		public static CategoryEditVM ToViewModel(this CategoryEditDto dto) 
		{
			return new CategoryEditVM
			{
				Id =dto.Id,
				Name =dto.Name,
				DisplayOrder = dto.DisplayOrder,

			};
		}
	}


}
