using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.BusinessEntities.Models
{
    public class FileStatus
    {
        public int Id { get; set; }
        public int FileId { get; set; }
        public int Status { get; set; }
        public int RejectReason { get; set; }
        public int CreatedBy { get; set; }
        public  int UpdatedBy { get; set; }
    }
}
