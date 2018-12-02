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
    public class InvoiceBpl
    {
        //public List<Invoice> GetInvoiceList(int invId)
        //{
        //    var result = new InvoiceRal().GetInvoiceList(invId);

        //   / return result;
        //}

        public DataTable GetInvoiceLisDT(DateTime? Fromdate = null, DateTime ?ToDate = null, int? difficultyLevel = null, int?InvoiceId = null, int? Status = null ,string SupplierEmail = null)
        {
            return new InvoiceRal().GetInvoiceListDT(Fromdate, ToDate, difficultyLevel, InvoiceId, SupplierEmail, Status).ToDataTable();
        }


        public DataTable GetInvoiceDT( DateTime? receiptdate = null, int? difficultyLevel = null, string invoicename = null, string suppemil = null, string sts = null)
        {
            return new InvoiceRal().GetInvoiceDT(receiptdate, difficultyLevel, invoicename, suppemil, sts).ToDataTable();
        }

        public void SaveInvoice(Invoice invoice)
        {
            new InvoiceRal().SaveInvoice(invoice);
        }

        public void DeleteInvoice(Invoice invoice)
        {
            new InvoiceRal().DeleteInvoice(invoice);
        }

        public List<RoleMapping> GetUserRoleMapping(int userId)
        {
            return new InvoiceRal().GetUserRoleMapping(userId);
        }

        public void SaveUserRoleMapping(int UserId, List<RoleMapping> lstRoleMapping)
        {
            var dt = lstRoleMapping.ToDataTable();
            new InvoiceRal().SaveUserRoleMapping(UserId, dt);
        }


        public void EditInvoice(Invoice invoice)
        {
            new InvoiceRal().EditInvoice(invoice);
        }
        public object GetInvoiceList(string fromDate, string toDate, int? difficultyLevel, int? invoiceId, string userAssigned, string status)
        {
            throw new NotImplementedException();
        }
    }
}
