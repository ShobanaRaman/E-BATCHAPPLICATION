using eBatch.BusinessEntities.Enums;
using eBatch.Theme.Purple;
using eBatchApp.Common;
using System;
using BL = eBatch.BusinessEntities.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eBatch.BusinessLogic.Bpl;

namespace eBatchApp.DataPrep
{
    public partial class FrmRejectReason : eFormPopup
    {
        int id = 0;
        public FrmRejectReason()
        {
            InitializeComponent();
            Utility.LoadCodeToCB(cbRejectionReason, CodeEnum.InvoiceRejectReason, "--Select--");
        }

        public void holdid( int idvalue)
        {         
            id = idvalue;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BL.FileStatus file = new BL.FileStatus()
            {
                FileId = id,                      
                Status = cbRejectionReason.SelectedValue.toInt()
            
            };
      
            new FileSatusBpl().SaveUsers(file);
            Utility.ShowSuccessmessage("File Rejected " );

            this.Close();
        }
    }
}
