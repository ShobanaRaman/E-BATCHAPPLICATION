using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.BusinessEntities.Models
{
    public class RoleMapping
    {
        public int Id { get; set; }
        public string ModuleName { get; set; }
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }
    }
}
