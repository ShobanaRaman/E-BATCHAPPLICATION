using eBatch.BusinessEntities.Enums;
using eBatch.BusinessEntities.Models;
using eBatch.ResourceAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.BusinessLogic.Bpl
{
    public class CommonBpl
    {
        public bool GetUserDetails(string uName)
        {
            bool loginsuccess = false;
            var userDetails = new CommonRal().GetuserDetails<LoggedUserDetails>(uName);
            if (userDetails != null)
            {
                GlobalConstants.LogginInUserId = userDetails.LoggedUserid;
                GlobalConstants.LogginInUserDisplayName = userDetails.LoggedDisplayUserName;
                GlobalConstants.LogginInUserName = userDetails.LoggeduserName;
                GlobalConstants.LogginInUserRole = userDetails.LoggedUserRole;
                GlobalConstants.LogginInUserRoleId = userDetails.LoggedRoleId;
                GetSettings();
                loginsuccess = true;
            }
            return loginsuccess;
        }

       public void GetSettings()
        {
            GlobalConstants.lstSetting= new CommonRal().GetSettings();
        }

    }
}
