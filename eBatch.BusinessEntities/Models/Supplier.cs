using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.BusinessEntities.Models
{
   public class Supplier
    {
        public int Supplierid { get; set; }
        public string SupplierName { get; set; }
        public string Email { get; set; }
        public string CIN { get; set; }
        public string ApprovalNumber { get; set; }
        public int? DifficultyLevel { get; set; }
        public string InvoiceType { get; set; }
        public bool? Status { get; set; }

        // public DateTime? createddate { get; set; }
        //  public int? createdby { get; set; }
        //  public int? updatedby { get; set; }
        //  public DateTime? updateddate { get; set; }
    }
}
