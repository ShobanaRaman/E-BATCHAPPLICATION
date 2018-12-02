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
    public class BatchBpl
    {
        public List<Batch> GetBatch()
        {
            var res = new BatchRal().GetBatch();
            var resdt = res.ToDataTable();
            return res;
        }

        public DataTable GetBatchDT(int? userrole = null, int? diffLevel = null, string username = null)
        {
            return new BatchRal().GetBatchDT(userrole,diffLevel,username).ToDataTable();
        }

        public void SaveBatches(Batch batch)
        {
            new BatchRal().SaveBatches(batch);
        }

        public void DeleteBatches(Batch batch)
        {
            new BatchRal().DeleteBatch(batch);
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

       
    }
}
