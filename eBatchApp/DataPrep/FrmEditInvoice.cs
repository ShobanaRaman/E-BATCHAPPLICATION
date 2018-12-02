using eBatch.BusinessEntities.Enums;
using eBatch.BusinessEntities.Models;
using eBatch.BusinessLogic.Bpl;
using eBatch.Theme.Purple;
using eBatchApp.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL = eBatch.BusinessEntities.Models;

namespace eBatchApp.DataPrep
{
    public partial class FrmEditInvoice : eForm
    {
        List<BL.User> lstusers = new List<BL.User>();
        List<string> lstAdusers = new List<string>();
        public FrmEditInvoice()
        {
            InitializeComponent();

            Utility.LoadCodeToCB(cbDifficultyLevel, CodeEnum.DifficultyLevel, "--Select--");
            Utility.LoadCodeToCB(cbStatus, CodeEnum.InvoiceStatus, "--Select--");
            LoadUserRoleCB();

        }
        private void LoadUserRoleCB()
        {
            lstusers = Utility.GeteBatchUsers();
            var userNames = lstusers.Select(x => x.username);
            AutoCompleteStringCollection aa = new AutoCompleteStringCollection();
            aa.AddRange(userNames.ToArray());
            cbUsers.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbUsers.AutoCompleteCustomSource = aa;
            cbUsers.Items.AddRange(userNames.ToArray());
            cbUsers.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbUsers.SelectedText = "----Select User----";

        }

        int InvoiceId = 0;
        public void AddFileId(int id)
        {
            InvoiceId = id;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            invoice.Id = InvoiceId;
            invoice.InvoiceId = txtInvoiceId.Text;
            invoice.ReceiptDate=Convert.ToDateTime( TimePickerReceiptDate.Text);
            invoice.Status = Convert.ToString(cbStatus.SelectedValue.toInt());
            invoice.DifficultyLevel = cbDifficultyLevel.SelectedValue.toInt();
            invoice.UserAssigned = Convert.ToString(cbUsers.Text);
            new InvoiceBpl().EditInvoice(invoice);
            Utility.ShowSuccessmessage("Edited the invoice ");
            this.Close();
        }

        private void cbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //ComboBox cb = (ComboBox)sender;
            //if (!cb.Focused) { return; }

            //var selectedItem = lstusers.Where(x => x.username == cb.SelectedItem.ToString()).SingleOrDefault();
   

        
    }
    }
}
