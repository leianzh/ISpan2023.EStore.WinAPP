using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer.Core
{
	public class CategoryEntity
	{   // 屬性做readonly 即可,不允許事後修改 
		public int Id { get; private set; }
		public string Name { get; private set; }
		public int DisplayOrder { get; private set; }

		public CategoryEntity(string name, int displayOrder, int id = 0)
		{
			// todo 在這裡,需要檢查各傳入值的正確性

			this.Id = id;
			this.Name = name;
			this.DisplayOrder = displayOrder;
		}
	}
}
