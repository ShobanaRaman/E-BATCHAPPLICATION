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
    public class SuppliersRal
    {
        /// <summary>
        /// To get Suppliers
        /// </summary>
        /// <returns>List of Suppliers</returns>
        public List<Supplier> GetCompassSuppliers(string CIN = null, string Email = null)
        {
            var dynParams = new DynamicParameters();
            dynParams.Add("@CIN", CIN);
            dynParams.Add("@email", Email);
            return Db.Fetch<Supplier>("compass." + SPEnum.spGetSuppliers.ToString(), dynParams);
        }

        public List<Supplier> GetAllSuppliers(string CIN = null, string Email = null)
        {
            var dynParams = new DynamicParameters();
            dynParams.Add("@CIN", CIN);
            dynParams.Add("@email", Email);
            return Db.Fetch<Supplier>(SPEnum.spGetAllSuppliers.ToString(), dynParams);
        }

        public List<Supplier> GetEBatchSuppliers(string CIN = null, string Email = null)
        {
            var dynParams = new DynamicParameters();
            dynParams.Add("@CIN", CIN);
            dynParams.Add("@email", Email);
            return Db.Fetch<Supplier>(SPEnum.spGetEbatchSuppliers.ToString(), dynParams);
        }

        /// <summary>
        /// To Save Supplier details
        /// </summary>
        /// <param name="Supplier">Supplier.</param>
        public void SaveSuppliers(Supplier supplier)
        {
            var dynParams = new DynamicParameters();
            dynParams.Add("@SupplierId", supplier.Supplierid);
            dynParams.Add("@approval_number", supplier.ApprovalNumber);
            dynParams.Add("@email", supplier.Email);
            dynParams.Add("@DifficultyLevel", supplier.DifficultyLevel);
            dynParams.Add("@Status", supplier.Status);
            dynParams.Add("@suppliername", supplier.SupplierName);
            dynParams.Add("@invoice_type", supplier.InvoiceType);
            CommandDefinition cmd = new CommandDefinition(SPEnum.spSaveSuppliers.ToString(), dynParams, commandType: CommandType.StoredProcedure);
            Db.Save(cmd);
        }
    }
}
