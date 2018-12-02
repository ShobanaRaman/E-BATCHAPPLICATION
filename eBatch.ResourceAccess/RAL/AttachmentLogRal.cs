using Dapper;
using eBatch.BusinessEntities.Enums;
using eBatch.BusinessEntities.Models;
using eBatch.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.ResourceAccess.RAL
{
    public class AttachmentLogRal
    {
        public List<FileLog> GetFileListDT(string FromDate = null, string ToDate = null, int? DifficultyLevel = 0, string FileName = null)
        {

            var dynParams = new DynamicParameters();
            dynParams.Add("@FromDate", FromDate?.ToString());
            dynParams.Add("@ToDate", ToDate);
            dynParams.Add("@DifficultyLevel", DifficultyLevel);
            dynParams.Add("@FileName", FileName);

            var res = Db.FetchDT<FileLog>(SPEnum.uspGetFileList.ToString(), dynParams);
            return res;
          //  return Db.Fetch<FileLog>(SPEnum.spGetFileList.ToString());
        }

        public void SaveFile(FileLog fileLog)
        {
            var dynParams = new DynamicParameters(new
            {
                SupplierId = fileLog.SupplierId,
                SupplierEmail = fileLog.SupplierEmail,
                ReceiptDate = fileLog.ReceiptDate,
                DifficultyLevel = fileLog.DifficultyLevel,
                User = GlobalConstants.LogginInUserId,
                FileName = fileLog.AttachmentFileName,
                DisplayName = fileLog.AttachmentFileDisplayName,
                FileSize = fileLog.AttachmentFileSize
            });
            CommandDefinition cmd = new CommandDefinition(SPEnum.uspSaveFile.ToString(), dynParams, commandType: CommandType.StoredProcedure);
            Db.Save(cmd);
        }

        public void EditFile(FileLog fileLog)
        {
            var dynParams = new DynamicParameters(new
            {
                Id=fileLog.Id,
                FileSize= fileLog.AttachmentFileSize,            
                DifficultyLevel = fileLog.DifficultyLevel,               
                FileName = fileLog.AttachmentFileName,
                DisplayName = fileLog.AttachmentFileName,

            });
            CommandDefinition cmd = new CommandDefinition(SPEnum.uspEditFiles.ToString(), dynParams, commandType: CommandType.StoredProcedure);
            Db.Save(cmd);
        }
    }
}
