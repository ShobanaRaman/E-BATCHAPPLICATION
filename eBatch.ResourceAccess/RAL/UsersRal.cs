using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using eBatch.BusinessEntities.Models;
using eBatch.Common;
using System.Data;
using eBatch.BusinessEntities.Enums;

namespace eBatch.ResourceAccess
{
    public class UsersRal
    {
        /// <summary>
        /// To get Users
        /// </summary>
        /// <returns>List of Users</returns>
        //public List<User> GetUsers()
        //{
        //    return Db.Fetch<User>(SPEnum.spGetUsers.ToString());
        //}

        //public List<User> GetUsers()
        //{
        //    return Db.Fetch<User>(SPEnum.spGetUsers.ToString());
        //}
        public List<User> GetUsers()
        {
            var res = Db.Fetch<User, Role>(SPEnum.spGetUsers.ToString(), null, "userRole", new Role().FirstCol());
            return res;
        }


        public List<User> GetUsersDT(int? ur = null, int? dl = null, string un = null)
        {
            var dynParams = new DynamicParameters();
            dynParams.Add("@UserRoleId", ur);
            dynParams.Add("@DifficutlyLevel", dl);
            dynParams.Add("@UserName", un);

            var res = Db.FetchDT<User>(SPEnum.spGetUsers.ToString(), dynParams);
            return res;
        }

        public List<RoleMapping> GetUserRoleMapping(int userId)
        {
            var dynParams = new DynamicParameters();
            dynParams.Add("@UserId", userId);
            return Db.Fetch<RoleMapping>(SPEnum.spGetUserRoleMapping.ToString(), dynParams);
        }

        public void SaveUserRoleMapping(int UserId, DataTable dtUserRoleMapping)
        {
            var dynParams = new DynamicParameters(new
            {
                UserRoleMappingTVP = dtUserRoleMapping.AsTableValuedParameter("UserRoleMappingTVP"),
                UserId = UserId
            });
            //dynParams.Add("@UserRoleMappingTVP", dtUserRoleMapping.AsTableValuedParameter("UserRoleMappingTVP"));
            //dynParams.Add("@UserId", UserId);
            CommandDefinition cmd = new CommandDefinition(SPEnum.spSaveUserRoleMapping.ToString(), dynParams, commandType: CommandType.StoredProcedure);
            Db.Save(cmd);

        }

        /// <summary>
        /// To Save User details
        /// </summary>
        /// <param name="user">User.</param>
        public void SaveUsers(User user)
        {
            var dynParams = new DynamicParameters();
            dynParams.Add("@UserId", user.id);
            dynParams.Add("@UserName", user.username);
            // dynParams.Add("@RoleId", user.userRoles);
            dynParams.Add("@RoleId", user.userRole.RoleId);
            dynParams.Add("@DifficultyLevel", user.difficultylevel);
            dynParams.Add("@Status", user.Status);
            CommandDefinition cmd = new CommandDefinition(SPEnum.spSaveUsers.ToString(), dynParams, commandType: CommandType.StoredProcedure);
            Db.Save(cmd);
        }

        /// <summary>
        /// To Delete(update status) User record
        /// </summary>
        /// <param name="user">User.</param>
        public void DeleteUsers(User user)
        {
            var dynParams = new DynamicParameters();
            dynParams.Add("@UserId", user.id);
            dynParams.Add("@Status", user.Status);
            CommandDefinition cmd = new CommandDefinition(SPEnum.spDeleteUsers.ToString(), dynParams, commandType: CommandType.StoredProcedure);
            Db.Save(cmd);
        }

        /// <summary>
        /// To Filter(grid search) User record
        /// </summary>
        /// <param name="user">User Nmae/Diff_level/Role.</param>
        public void FilterGrid(string value, string field)
        {
            var dynParams = new DynamicParameters();
            dynParams.Add("@Field", field);
            dynParams.Add("@Value", value);
            CommandDefinition cmd = new CommandDefinition(SPEnum.spSearchUsers.ToString(), dynParams, commandType: CommandType.StoredProcedure);
            Db.Save(cmd);
        }

        public List<User> GetUserRole(User User)
        {
            var dynParams = new DynamicParameters();
            dynParams.Add("@UserId", User.id);
            return Db.Fetch<User>(SPEnum.spGetUserRole.ToString(), dynParams);


        }
    }
}
