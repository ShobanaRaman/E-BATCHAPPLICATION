using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBatch.BusinessEntities.Enums;
using eBatch.ResourceAccess;

namespace eBatch.BusinessLogic.Bpl
{
    public class AuditBpl
    {
        public string GetAdminAudit()
        {
            List<string> auditText = new List<string>();
          var auditInformation=  new CommonRal().GetAudit("Admin");

            foreach(var audit in auditInformation)
            {
                string action = audit.ActionType == "I" ? "Enabled" : "Changed to";
                auditText.Add($"{audit.UpdateDate},{GlobalConstants.LogginInUserName}: {audit.UserName} {audit.FieldName} {action} {audit.NewValue}");
            }

            return string.Join("\n", auditText.ToArray()) ;
        }
    }
}
