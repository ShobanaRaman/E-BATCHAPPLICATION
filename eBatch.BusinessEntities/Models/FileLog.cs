using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.BusinessEntities.Models
{
    public class FileLog
    {
        public int Id { get; set; }

        public int SupplierId { get; set; }

        public string SupplierEmail { get; set; }

        public DateTime ReceiptDate { get; set; }

        public int AttachmentId { get; set; }

        public int DifficultyLevel { get; set; }

        public string FileSource { get; set;}
        public string AttachmentFileName { get; set; }
        public string AttachmentFileDisplayName { get; set; }
        public string AttachmentFileSize { get; set; }

    }
}
