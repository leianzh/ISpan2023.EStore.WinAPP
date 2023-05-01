using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer
{
	public class SqlParameterBuilder
	{
		private List<SqlParameter>_parameters = new List<SqlParameter>();

		public static SqlParameterBuilder Create() { 
		return new SqlParameterBuilder();
		}

		public SqlParameterBuilder AddInt(string name,int value)
		{
			var parameter = new SqlParameter(name, SqlDbType.Int) { Value= value };
			_parameters.Add(parameter);

			return this;
		}
		public SqlParameterBuilder AddOutputInt(string name) 
		{
			var parameter = new SqlParameter(name, SqlDbType.Int) { Direction = ParameterDirection.Output };
			_parameters.Add(parameter);
			return this;
		}
		public SqlParameterBuilder AddNvarchar(string name,int length,string value) 
		{
			var parameter = string.IsNullOrEmpty(value)
				? new SqlParameter(name, SqlDbType.NVarChar, length) {Value = DBNull.Value } 
				:new SqlParameter(name,SqlDbType.NVarChar, length) { Value= value};
			_parameters.Add(parameter);
			return this;
		}

		public SqlParameterBuilder AddDateTime(string name,DateTime value) 
		{
			var parameter = new SqlParameter(name, SqlDbType.DateTime) { Value= value };
			_parameters.Add(parameter);
			return this;
		}

		public SqlParameter[] Build() 
		{
			return _parameters.ToArray();
		}
	}
}
