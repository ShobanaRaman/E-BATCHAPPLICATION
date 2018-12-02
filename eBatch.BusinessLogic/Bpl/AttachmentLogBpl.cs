using eBatch.BusinessEntities.Models;
using eBatch.BusinessLogic.Bpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBatch.ResourceAccess;
using eBatch.ResourceAccess.RAL;
using System.Data;

namespace eBatch.BusinessLogic.Bpl
{
    public class AttachmentLogBpl
    {

        //public DataTable GetFileList()
        //{
        //    return new AttachmentLogRal().GetFileList().ToDataTable();
        //}
            public DataTable GetFileListDT(DateTime? FromDate = null, DateTime? ToDate = null, int? DifficultyLevel = 0, string FileName = null)
        {
            return new AttachmentLogRal().GetFileListDT(FromDate, ToDate, DifficultyLevel, FileName).ToDataTable();
        }

        public void SaveFile(FileLog fileLog)
        {
            new AttachmentLogRal().SaveFile(fileLog);
        }

        public void EditFile(FileLog fileLog)
        {
            new AttachmentLogRal().EditFile(fileLog);
        }
    }
}
