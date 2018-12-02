using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.BusinessEntities.Enums
{
    public enum SPEnum
    {
        spSaveUsers,
        spGetUsers,
        spSearchUsers,
        spDeleteUsers,

        spGetUserRoleMapping,
        spSaveUserRoleMapping,
        spGetCodes,
        GetAccess,
        GetMenu,
        spGetUserRole,

        spGetAudtiTrail,
               
        spGetSuppliers,
        spGetAllSuppliers,
        spGetEbatchSuppliers,
        spSaveSuppliers,
        spDeleteSuppliers,
        spGetUserLoginDetails,

       
     //Invoice Data Entry
        uspGetInvoice,
        uspSaveInvoice,
        uspDeleteInvoice,
        uspSearchInvoice,

            //Batches in Data Entry
        uspGetBatch,
        uspSaveBatch,
        uspDeleteBatch,
        uspSearchBatch,
        spGetSettings,
        

        //FileList
        uspGetFileList,
        uspEditFiles,
        uspSaveFile,

        //FileStatus
        uspSaveFileStatus,

       //Invoice DataPrep
        uspGetInvoiceList,
         uspEditInvoice
    }
}
