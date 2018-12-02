using eBatch.BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBatch.BusinessEntities.Enums
{
    public static class GlobalConstants
    {
        public static int LogginInUserId;
        public static string LogginInUserName;
        public static string LogginInUserDisplayName;
        public static string LogginInUserRole;
        public static string LogginInUserRoleId;
        public static Form baseForm;
        public static List<User> lstUsers = null;
        public static List<Supplier> lstAllSupplier = null;
        public static List<Setting> lstSetting = null;
        public static List<FileLog> EditedFile = null;




    }
}
