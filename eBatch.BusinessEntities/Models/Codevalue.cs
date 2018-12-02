using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.BusinessEntities.Models
{
    public class Codevalue
    {
        public int id { get; set; }
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }

    }
}
