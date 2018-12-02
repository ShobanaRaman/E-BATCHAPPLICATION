using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBatch.BusinessEntities.Models;
using eBatch.ResourceAccess;

namespace eBatch.BusinessLogic.Bpl
{
    public class SuppliersBpl
    {
        /// <summary>
        /// This method will return all the supplier email ids from Compass
        /// </summary>
        /// <param name="CIN"></param>
        /// <param name="Email"></param>
        /// <returns></returns>
        public List<Supplier> GetCompassSuppliers(string CIN=null, string Email=null)
        {
            return new SuppliersRal().GetCompassSuppliers();
        }

        /// <summary>
        /// This method will return all the supplier email ids Compass + eBatch
        /// </summary>
        /// <returns></returns>
        public List<Supplier> GetAllSuppliers()
        {
            return new SuppliersRal().GetAllSuppliers();
        }
        public List<Supplier> GetEBatchSuppliers()
        {
            return new SuppliersRal().GetEBatchSuppliers();
        }        

        public void SaveSuppliers(Supplier supplier)
        {
            new SuppliersRal().SaveSuppliers(supplier);
        }
    }
}
