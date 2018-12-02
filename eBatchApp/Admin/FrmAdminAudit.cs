using eBatch.Theme.Purple;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL = eBatch.BusinessLogic.Bpl;

namespace eBatchApp.Admin
{
    public partial class FrmAdminAudit : eForm
    {
        public FrmAdminAudit()
        {
            InitializeComponent();
        }

        private void AdminAuditForm_Load(object sender, EventArgs e)
        {
            var auditText = new BL.AuditBpl().GetAdminAudit();
            richTextBox1.Text = auditText;
        }
    }
}
