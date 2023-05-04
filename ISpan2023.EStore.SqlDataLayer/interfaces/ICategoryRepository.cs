using ISpan2023.EStore.SqlDataLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer.interfaces
{/// <summary>
 ///interface
 /// 不能宣告FIELD和建構函數
 ///不能寫public private
 ///要寫大寫I
 ///宣告METHOD方法  void METHOD(參數);
 /// </summary>
	public interface ICategoryRepository//針對介面寫程式意思是用interface寫service，不要針對實例寫程式意思是，不要直接用service寫repo
	{
		void Create(CategoryEntity entity);
		void Update(CategoryEntity entity);
		void Delete(int categoryId);
		CategoryEntity Get(int categoryId);//查詢一筆所以不用list包
		List<CategoryEntity> Search(string categoryName, int? categoryId);//查詢多筆用list包

	}
}
