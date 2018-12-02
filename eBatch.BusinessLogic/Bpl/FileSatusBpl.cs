using eBatch.BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBatch.ResourceAccess.RAL;

namespace eBatch.BusinessLogic.Bpl
{
    public class FileSatusBpl
    {

        public void SaveUsers(FileStatus File)
        {
            new FileStatusRal().SaveFileStatus(File);
        }
    }
}
