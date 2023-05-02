using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ISpan2023.EStore.SqlDataLayer
{
	public class ProductRepository//查詢多筆
	{
		public List<ProductDto> Search(int? categoryId = null)
		{
			Func<SqlConnection> funcConn = SqlDb.GetConnection;
			#region sql
			var sql = @"select P.Id,P.Name,P.Price,C.Name as CategoryName
from Products as P
inner join Categories as C on C.Id =P.CategoryId";
			if (categoryId.HasValue)
			{
				sql = sql + " where C.Id= " + categoryId.Value;
			}
			sql = sql + " order by C.DisplayOrder";
			#endregion
			Func<SqlDataReader, ProductDto> funcAssembler = reader =>
			{
				return new ProductDto()
				{
					ProductId = reader.GetInt32("Id", 0),
					ProductName = reader.GetString("Name"),
					Price = reader.GetInt32("Price", 0),
					CategoryName = reader.GetString("CategoryName")
				};
			};
			return SqlDb.Search<ProductDto>(funcConn, funcAssembler, sql);
			
		}
		public List<ProductDto> Search2(int? categoryId = null)
		{
			using (SqlConnection conn = SqlDb.GetConnection("default"))
			{
				conn.Open();
				var sql = @"select P.Id,P.Name,P.Price,C.Name as CategoryName
from Products as P
inner join Categories as C on C.Id =P.CategoryId";
				if (categoryId.HasValue)
				{
					sql = sql + " where C.Id= " + categoryId.Value;
				}
				sql = sql + " order by C.DisplayOrder";
				var products = new List<ProductDto>();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = sql;
					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);//在reader不再使用時,自動關閉connection
					while (reader.Read())
					{
						ProductDto dto = new ProductDto()
						{
							ProductId = reader.GetInt32("Id", 0),
							ProductName = reader.GetString("Name"),
							Price = reader.GetInt32("Price", 0),
							CategoryName = reader.GetString("CategoryName")
						};
						products.Add(dto);
					}
				}
				return products;
			}
		}

	}


	public class ProductDto
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public int Price { get; set; }
		public string CategoryName { get; set; }
	}
}
