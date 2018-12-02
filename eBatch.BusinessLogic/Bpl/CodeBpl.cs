using eBatch.BusinessEntities.Enums;
using eBatch.BusinessEntities.Models;
using eBatch.ResourceAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.BusinessLogic.Bpl
{
    public class CodeBpl
    {
        public List<Codevalue> GetCode(CodeEnum code)
        {
            return new CommonRal().GetCode(code);
        }
    }
}
