using eBatch.BusinessEntities.Models;
using eBatch.ResourceAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.BusinessLogic.Bpl
{
    public class UsersBpl
    {
        public List<User> GetUsers()
        {
            var res = new UsersRal().GetUsers();
            var resdt = res.ToDataTable();
            return res;
        }

        public DataTable GetUsersDT(int? userrole = null, int? diffLevel = null, string username = null)
        {
            return new UsersRal().GetUsersDT(userrole,diffLevel,username).ToDataTable();
        }

        public void SaveUsers(User user)
        {
            new UsersRal().SaveUsers(user);
        }

        public void DeleteUsers(User user)
        {
            new UsersRal().DeleteUsers(user);
        }

        public List<RoleMapping> GetUserRoleMapping(int userId)
        {
            return new UsersRal().GetUserRoleMapping(userId);
        }

        public void SaveUserRoleMapping(int UserId, List<RoleMapping> lstRoleMapping)
        {
            var dt = lstRoleMapping.ToDataTable();
            new UsersRal().SaveUserRoleMapping(UserId, dt);
        }

        // For UI
        public List<User> GetUserRole(User user)
        {
            return new UsersRal().GetUserRole(user);
        }
    }
}
