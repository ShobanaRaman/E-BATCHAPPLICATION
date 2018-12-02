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
    public class MapInvoiceBpl 
    {
        public List<MapInvoice> GetInvoice()
        {
            var res = new InvoiceRal().GetInvoice();
            var resdt = res.ToDataTable();
            return res;
        }

        public DataTable GetInvoiceDT(int? userrole = null, int? diffLevel = null, string username = null)
        {
            return new InvoiceRal().GetInvoiceDT(userrole,diffLevel,username).ToDataTable();
        }

        public void SaveInvoice(MapInvoice mapInvoice)
        {
            new InvoiceRal().SaveUsers(mapInvoice);
        }

        public void DeleteInvoice(MapInvoice mapInvoice)
        {
            new InvoiceRal().DeleteInvoice(mapInvoice);
        }

        public List<RoleMapping> GetUserRoleMapping(int userId)
        {
            return new UsersRal().GetUserRoleMapping(userId);
        }
        
    }
}
