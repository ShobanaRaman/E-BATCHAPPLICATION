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
    public class FileStatusRal
    {
        

            public void SaveFileStatus(FileStatus file)
        {
            var dynParams = new DynamicParameters();
            dynParams.Add("@FileId", file.FileId);
            dynParams.Add("@Status", file.Status);
            
            CommandDefinition cmd = new CommandDefinition(SPEnum.uspSaveFileStatus.ToString(), dynParams, commandType: CommandType.StoredProcedure);
            Db.Save(cmd);
        }
    }
}
