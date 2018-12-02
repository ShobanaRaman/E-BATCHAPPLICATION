using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.BusinessEntities.Models
{
    public class Audit
    {
        public string UserName { get; set; }
        public string PrimaryKey { get; set; }
        public string ActionType { get; set; }
        public string FieldName { get; set; }
        public string NewValue { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
