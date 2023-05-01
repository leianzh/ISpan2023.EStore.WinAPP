using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer
{
	public static class sqlDataReaderExtensions
	{
		public static string GetString(this SqlDataReader reader,string columName) 
		{
			int colIndex = reader.GetOrdinal(columName);// 取得它在第幾欄
			return reader.IsDBNull(colIndex)?null 
				: reader.GetString(colIndex);
		}
		public static int? GetInt32(this SqlDataReader reader, string columName) 
		{
			int colIndex = reader.GetOrdinal(columName);
			return reader.IsDBNull(colIndex) ? (int?)null
				: reader.GetInt32(colIndex);
		}
		public static int GetInt32(this SqlDataReader reader, string columName,int defaultValue) 
		{
			int? result = reader.GetInt32(columName);
			return result.HasValue ? result.Value : defaultValue;
		}
		public static DateTime? GetDateTime(this SqlDataReader reader, string columnName)
		{
			int colIndex = reader.GetOrdinal(columnName);
			return reader.IsDBNull(colIndex)
				? (DateTime?)null
				: reader.GetDateTime(colIndex);
		}
		public static DateTime GetDateTime(this SqlDataReader reader, string columnName, DateTime defaultValue)
		{
			DateTime? result = reader.GetDateTime(columnName);
			return result.HasValue ? result.Value : defaultValue;
		}
	}
}
