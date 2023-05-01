using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer
{
	public class NewsEditDto
	{
        public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
        public DateTime ModifiedTime { get; set; }
    }
}
