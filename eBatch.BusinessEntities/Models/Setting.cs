using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.BusinessEntities.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public string KeyText { get; set; }
        public string ValueText { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}
