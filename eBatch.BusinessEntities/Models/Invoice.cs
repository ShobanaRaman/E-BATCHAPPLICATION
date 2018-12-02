using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.BusinessEntities.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime ReceiptDate { get; set; }
        public int? DifficultyLevel { get; set; }       
        public string InvoiceId { get; set; }
        public string SupplierEmail { get; set; }
        public string Status { get; set; }
        public string UserAssigned { get; set; }
        public int? createdby { get; set; }
        public DateTime? createddate { get; set; }
        public int? updatedby { get; set; }
        public DateTime? updateddate { get; set; }          
        public bool? active { get; set; }
    }
}
