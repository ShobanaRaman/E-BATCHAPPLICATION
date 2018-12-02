using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.BusinessEntities.Models
{
    public class MapInvoice
    {
        public int id { get; set; }
        public int? invoiceid { get; set; }
        public int? userid { get; set; }
        public int? status { get; set; }
        public bool? active { get; set; }
        public int? createdby { get; set; }
        public DateTime? createddate { get; set; }
        public int? updatedby { get; set; }
        public DateTime? updateddate { get; set; }
    }
}
