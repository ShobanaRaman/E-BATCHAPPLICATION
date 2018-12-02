using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using eBatch.BusinessEntities.Enums;
using eBatch.BusinessLogic.Bpl;
using eBatch.Theme.Purple;
using eBatchApp.Common;
using BL = eBatch.BusinessEntities.Models;
using System.Threading.Tasks;

namespace eBatchApp.Admin
{
    public partial class FrmDataEntryHome : eForm
    {
        //int userId = 0;
        //List<BL.User> lstusers = new List<BL.User>();
        //List<string> lstAdusers = new List<string>();
        public FrmDataEntryHome()
        {
            InitializeComponent();
            dgvInvoice.AutoGenerateColumns = false;
                    
        }

     
        private async void DataEntryHome_Load(object sender, EventArgs e)
        {
            tbAdminModule.SelectedTab = tbInvoice;
            tbAdminModule.Location = new Point(0, 0);
              //LoadInvoice();
            //loadFieldComboBoxValue();
            await Task.Delay(500);
            //((Button)GlobalConstants.baseForm.Controls.Find("btnTogglemenu", true).FirstOrDefault()).PerformClick();
            GlobalConstants.baseForm.Controls.Find("pnlMenuContainer", true).FirstOrDefault().Visible = true;
        }

        // bool entryFound = false;
        //public void LoadUsers(int? userrole = null, int? difficultyLevel = null, string username = null)
        //{


        //    GlobalConstants.lstUsers =  new UsersBpl().GetUsers();
        //    var res = new UsersBpl().GetUsersDT(userrole, difficultyLevel, username);
        //    dgvInvoice.DataSource = res;

        //    dgvInvoice.PageSize = 10;
        //    dgvInvoice.SetPagedDataSource(res, bindingNavigator1);

        //    DataGridViewColumn column = dgvInvoice.Columns[6];
        //    column.Width = 50;
        //    DataGridViewColumn column1 = dgvInvoice.Columns[7];
        //    column1.Width = 50;

        //}
        public void LoadInvoice(DateTime? receiptdate = null, int? difficultyLevel = null, string invoicename = null, string supplieremail = null, string status = null)
        {
            
            //GlobalConstants.lstUsers = new UsersBpl().GetUsers();
            var result = new InvoiceBpl().GetInvoiceDT(receiptdate, difficultyLevel, invoicename, supplieremail,status);
            dgvInvoice.DataSource = result;

            dgvInvoice.PageSize = 10;
            dgvInvoice.SetPagedDataSource(result, bindingNavigator1);

            DataGridViewColumn column = dgvInvoice.Columns[6];
            column.Width = 50;
            DataGridViewColumn column1 = dgvInvoice.Columns[7];
            column1.Width = 50;

        }

        //private void btnAddUser_Click(object sender, EventArgs e)
        //{
        //    using (FrmAddUser aduser = new FrmAddUser())
        //    {
        //        if (aduser.ShowDialog() != DialogResult.Cancel)
        //        {
        //            LoadUsers();
        //        }
        //    }
        //}

        //Edit and Delete users
        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int userid = 0;
                userid = (int)dgvInvoice.CurrentRow.Cells[0].Value;
                int difflevel = (int)dgvInvoice.CurrentRow.Cells[2].Value;
                try
                {
                    if (e.ColumnIndex == 6)  //edit record
                    {

                        FrmAddUser objUser = new FrmAddUser();
                        //To bring the text from grid to combo box in FrmAddUser
                        Utility.LoadCodeToCB(objUser.cbDifficultyLevel, CodeEnum.DifficultyLevel);
                        Utility.LoadCodeToCB(objUser.cbRole, CodeEnum.UserRole);

                        objUser.AddUserID(userid);
                        objUser.txtUserName.Text = (string)dgvInvoice.CurrentRow.Cells[1].Value;

                        objUser.cbRole.Text = (string)dgvInvoice.CurrentRow.Cells[4].Value;
                        objUser.cbDifficultyLevel.Text = difflevel.ToString();
                        objUser.cbUserName.Text = (string)dgvInvoice.CurrentRow.Cells[1].Value;
                        objUser.cbUserName.Enabled = false;
                        objUser.BringToFront();
                        var res = objUser.ShowDialog();


                        //if (!res.Equals(DialogResult.Cancel))
                        //{
                        //    LoadUsers();
                        //}
                    }
                    if (e.ColumnIndex == 7) //delete
                    {
                        var res = Utility.Showconfirmation("Are you sure you want to DISABLE the selected user: " + dgvInvoice.CurrentRow.Cells[1].Value);

                        if (res.Equals(DialogResult.Yes))
                        {

                            Utility.Validate();
                            BL.User user = new BL.User()
                            {
                                id = userid,
                                Status = false  //update only the status column
                            };

                            new UsersBpl().DeleteUsers(user);
                            Utility.ShowSuccessmessage("disabled User " + dgvInvoice.CurrentRow.Cells[1].Value);
                           // LoadUsers();
                        }
                      
                        // this.Close();
                    }
                }
                catch
                {
                   // Console.WriteLine("An error occurred: '{0}'", e);
                }
            }

            //LoadUsers();

        }


        private void loadFieldComboBoxValue()
        {
            //cbField.Text = "--Select--";
            //cbField.Items.Add("User Name");
            //// cbField.Items.Add("Difficulty Level");
            //cbField.Items.Add("User Roles");
        }
       

        private void tbSupplier_Click(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
           
            dgvSuppliers.DataSource = new SuppliersBpl().GetAllSuppliers();
            // var res = new UsersBpl().GetUsersDT();
            // dgvSuppliers.DataSource = res;

            dgvSuppliers.PageSize = 10;
            // dgvSuppliers.SetPagedDataSource(res, bindingNavigator1);


        }

        private void tbSupplier_Enter(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void tbRoleMapping_Enter(object sender, EventArgs e)
        {
            //txtFake.GotFocus += textBox1_GotFocus;
            ////lstAdusers = Utility.GetADUsers();
            //LoadRoleMapping();
           
        }
        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            //cbUsers.Focus();
        }

      
        private void btnAudit_Click(object sender, EventArgs e)
        {
            FrmAdminAudit aaf = new FrmAdminAudit();
            aaf.ShowDialog();
        }


        //bindingNavigator
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            using (FrmAddUser aduser = new FrmAddUser())
            {
                if (aduser.ShowDialog() != DialogResult.Cancel)
                {
                    //LoadUsers();
                }
            }
        }

        //bindingNavigator
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int userid = 0;
            userid = (int)dgvInvoice.CurrentRow.Cells[0].Value;

            Utility.Validate();
            BL.User user = new BL.User()
            {
                id = userid,
                Status = false  //update only the status column
            };

            new UsersBpl().DeleteUsers(user);
        }

       
        private void tbAdminModule_Enter(object sender, EventArgs e)
        {
            LoadFilterDifficultyLevel();
        }

        private void LoadFilterDifficultyLevel()
        {
            Utility.LoadCodeToCB(cbFilterDifficulty, CodeEnum.DifficultyLevel, "--All--");
            Utility.LoadCodeToCB(cbInvoiceStatus, CodeEnum.UserRole, "--All--");
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //LoadUsers((int)cbInvoiceStatus.SelectedValue, (int)cbFilterDifficulty.SelectedValue, txtSuppEmail.Text);
        }


        private void dgvUsers_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvInvoice.CurrentCell.ColumnIndex == 2)
            {
                ComboBox combo = e.Control as ComboBox;

                if (combo == null)
                    return;

                combo.DropDownStyle = ComboBoxStyle.DropDown;
            }
        }
        

        private void lnkClearFilter_Click(object sender, EventArgs e)
        {
            txtSuppEmail.Text = "";
            cbFilterDifficulty.SelectedIndex = 0;
            cbInvoiceStatus.SelectedIndex = 0;
            //LoadUsers();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNewBatch_Click(object sender, EventArgs e)
        {

        }
    }
}
