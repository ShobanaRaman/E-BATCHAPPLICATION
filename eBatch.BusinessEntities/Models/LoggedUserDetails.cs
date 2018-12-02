using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.BusinessEntities.Models
{
    public class LoggedUserDetails
    {
        public int LoggedUserid { get; set; }
        public string LoggeduserName { get; set; }
        public string LoggedUserRole { get; set; }
        public string LoggedRoleId { get; set; }
        public string LoggedDisplayUserName { get; set; }
    }
}
