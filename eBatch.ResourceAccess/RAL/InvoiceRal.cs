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
    public class InvoiceRal
    {
        /// <summary>
        /// To get Invoice list
        /// </summary>
        /// <returns>List of Invoice</returns>

        public List<Invoice> GetInvoiceListDT(DateTime? FromDate = null, DateTime? ToDate = null, int? DifficutlyLevel = null, int ? InvoiceId = null, string SupplierEmail = null, int ?Status =0)
        {
            var dynParams = new DynamicParameters();
            dynParams.Add("@FromDate", FromDate);
            dynParams.Add("@ToDate", ToDate);
            dynParams.Add("@DifficultyLevel", DifficutlyLevel);
            dynParams.Add("@InvoiceId", InvoiceId);
            dynParams.Add("@SupplierEmail", SupplierEmail);
            dynParams.Add("@Status", Status);

            var res = Db.FetchDT<Invoice>(SPEnum.uspGetInvoiceList.ToString(), dynParams);
            return res;
        }
        public List<Invoice> GetInvoiceDT(DateTime? recpit = null, int? dl = null, string invnam = null, string supmail = null, string stat = null)
        {
            var dynParams = new DynamicParameters();
            dynParams.Add("@ReceiptDate", recpit);
            dynParams.Add("@DifficutlyLevel", dl);
            dynParams.Add("@InvoiceName", invnam);
            dynParams.Add("@SupplierEmail", supmail);
            dynParams.Add("@Status", stat);

            var res = Db.FetchDT<Invoice>(SPEnum.uspGetInvoice.ToString(), dynParams);
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
        /// To Save Invoice details
        /// </summary>
        /// <param name="Invoice">Invoice.</param>
        public void SaveInvoice(Invoice invoice)
        {
            //var dynParams = new DynamicParameters();
            //dynParams.Add("@UserId", user.id);
            //dynParams.Add("@UserName", user.username);s
            //// dynParams.Add("@RoleId", user.userRoles);
            //dynParams.Add("@RoleId", user.userRole.RoleId);
            //dynParams.Add("@DifficultyLevel", user.difficultylevel);
            //dynParams.Add("@Status", user.Status);
            //CommandDefinition cmd = new CommandDefinition(SPEnum.uspSaveInvoice.ToString(), dynParams, commandType: CommandType.StoredProcedure);
            //Db.Save(cmd);
        }

        /// <summary>
        /// To Delete(update status) Invoice record
        /// </summary>
        /// <param name="Invoice">Invoice.</param>
        public void DeleteInvoice(Invoice invoice)
        {
            //var dynParams = new DynamicParameters();
            //dynParams.Add("@UserId", user.id);
            //dynParams.Add("@Status", user.Status);
            //CommandDefinition cmd = new CommandDefinition(SPEnum.uspDeleteInvoice.ToString(), dynParams, commandType: CommandType.StoredProcedure);
            //Db.Save(cmd);
        }

        /// <summary>
        /// To Filter(grid search) Invoice record
        /// </summary>
        /// <param name="Invoice"></param>
        public void FilterGrid(string value, string field)
        {
            var dynParams = new DynamicParameters();
            dynParams.Add("@Field", field);
            dynParams.Add("@Value", value);
            CommandDefinition cmd = new CommandDefinition(SPEnum.uspSearchInvoice.ToString(), dynParams, commandType: CommandType.StoredProcedure);
            Db.Save(cmd);
        }

        //public List<User> GetUserRole(User User)
        //{
        //    var dynParams = new DynamicParameters();
        //    dynParams.Add("@UserId", User.id);
        //    return Db.Fetch<User>(SPEnum.spGetUserRole.ToString(), dynParams);


        //}
        /// <summary>
        /// To Save Invoice details
        /// </summary>
        /// <param name="Invoice">Invoice.</param>
        public void EditInvoice(Invoice invoice)
        {
            var dynParams = new DynamicParameters();
            dynParams.Add("@Id", invoice.Id);
            //dynParams.Add("@SupplierEmail", invoice.SupplierEmail);
            dynParams.Add("@ReceiptDate", invoice.ReceiptDate);
            dynParams.Add("@UserAssigned", invoice.UserAssigned);
            dynParams.Add("@DifficultyLevel", invoice.DifficultyLevel);
            dynParams.Add("@Status", invoice.Status);
            CommandDefinition cmd = new CommandDefinition(SPEnum.uspEditInvoice.ToString(), dynParams, commandType: CommandType.StoredProcedure);
            Db.Save(cmd);
        }
    }
}
