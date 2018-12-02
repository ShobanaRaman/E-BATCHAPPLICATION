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
    public partial class FrmAdminHome : eForm
    {
        int userId = 0;
        List<BL.User> lstusers = new List<BL.User>();
        List<string> lstAdusers = new List<string>();
        public FrmAdminHome()
        {
            InitializeComponent();
            dgvUsers.AutoGenerateColumns = false;
            dgvSuppliers.AutoGenerateColumns = false;
            dgvUserRoleMapping.AutoGenerateColumns = false;
            dgvUserRoleMapping.ReadOnly = false;
            dgvUserRoleMapping.Columns["ModuleName"].ReadOnly = true;
        }

        private async void AdminHome_Load(object sender, EventArgs e)
        {
            tbAdminModule.SelectedTab = tbUser;
            tbAdminModule.Location = new Point(0, 0);
            LoadUsers();
            loadFieldComboBoxValue();
            await Task.Delay(500);
            //((Button)GlobalConstants.baseForm.Controls.Find("btnTogglemenu", true).FirstOrDefault()).PerformClick();
            GlobalConstants.baseForm.Controls.Find("pnlMenuContainer", true).FirstOrDefault().Visible = true;
        }

        bool entryFound = false;
        public void LoadUsers(int? userrole = null, int? difficultyLevel = null, string username = null)
        {

            
            var res = new UsersBpl().GetUsersDT(userrole, difficultyLevel, username);
            dgvUsers.DataSource = res;

            dgvUsers.PageSize = 10;
            dgvUsers.SetPagedDataSource(res, bindingNavigator1);

            DataGridViewColumn column = dgvUsers.Columns[6];
            column.Width = 50;
            DataGridViewColumn column1 = dgvUsers.Columns[7];
            column1.Width = 50;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using (FrmAddUser aduser = new FrmAddUser())
            {
                if (aduser.ShowDialog() != DialogResult.Cancel)
                {
                    LoadUsers();
                }
            }
        }

        //Edit and Delete users
        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int userid = 0;
                userid = (int)dgvUsers.CurrentRow.Cells[0].Value;
                int difflevel = (int)dgvUsers.CurrentRow.Cells[2].Value;
                if (e.ColumnIndex == 6)  //edit record
                {
                    //  e.Handled = true;
                    // DataGridViewCell cell = dataGridView1.Rows[0].Cells[0];
                    //dataGridView1.CurrentCell = cell;
                    //dgvUsers.BeginEdit(true);
                    //int selectedRowIndex = dgvUsers.SelectedCells[0].RowIndex;
                    //DataGridViewRow selectedRow = dgvUsers.Rows[selectedRowIndex];
                    
                    FrmAddUser objUser = new FrmAddUser();
                    //To bring the text from grid to combo box in FrmAddUser
                    Utility.LoadCodeToCB(objUser.cbDifficultyLevel, CodeEnum.DifficultyLevel);
                    Utility.LoadCodeToCB(objUser.cbRole, CodeEnum.UserRole);

                    objUser.AddUserID(userid);
                    objUser.txtUserName.Text = (string)dgvUsers.CurrentRow.Cells[1].Value;

                    objUser.cbRole.Text = (string)dgvUsers.CurrentRow.Cells[4].Value;
                    objUser.cbDifficultyLevel.SelectedText = difflevel.ToString();
                    objUser.cbUserName.Text = (string)dgvUsers.CurrentRow.Cells[1].Value;
                    objUser.cbUserName.Enabled = false;

                   var res= objUser.ShowDialog();
                    if(!res.Equals(DialogResult.Cancel))
                    {
                        LoadUsers();
                    }
                }
                if (e.ColumnIndex == 7) //delete
                {
                    var res = Utility.Showconfirmation("Are you sure you want to DISABLE the selected user: " + dgvUsers.CurrentRow.Cells[1].Value);

                    if (res.Equals(DialogResult.Yes))
                    {

                        Utility.Validate();
                        BL.User user = new BL.User()
                        {
                            id = userid,
                            Status = false  //update only the status column
                        };

                        new UsersBpl().DeleteUsers(user);
                        Utility.ShowSuccessmessage("disabled User " + dgvUsers.CurrentRow.Cells[1].Value);
                    }
                    // this.Close();
                }
            }

            LoadUsers();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // CbFieldType.DisplayMember = "username";
            //string field = cbField.Text;
            //string value = txtFieldValue.Text;
            //appendSearchItems(field, value);

        }

        private void loadFieldComboBoxValue()
        {
            //cbField.Text = "--Select--";
            //cbField.Items.Add("User Name");
            //// cbField.Items.Add("Difficulty Level");
            //cbField.Items.Add("User Roles");
        }
        private void appendSearchItems(string fieldValue, string searchValue)
        {
            try
            {
                string field = fieldValue.ToLower().Replace(" ", "");
                var res = new UsersBpl().GetUsersDT();

                if (field == "difficultylevel")
                {
                    res = res.AsEnumerable().Where(row => row.Field<int>(field) == Convert.ToInt32(searchValue)).CopyToDataTable();
                }
                else
                {
                    res = res.AsEnumerable().Where(row => row.Field<String>(field) == searchValue).CopyToDataTable();
                }

                dgvUsers.DataSource = null;
                dgvUsers.Refresh();
                //dgvUsers.DataSource = UsersBpl().FilterGrid(field, value);
                dgvUsers.DataSource = res;
                dgvUsers.PageSize = 10;
                dgvUsers.SetPagedDataSource(res, bindingNavigator1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void tbSupplier_Click(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            ////grid column
            //DataGridViewButtonColumn EditColumn = new DataGridViewButtonColumn();
            //EditColumn.Text = "Edit";
            //EditColumn.Name = "Edit";
            //// EditColumn.DataPropertyName = "Edit";
            //EditColumn.UseColumnTextForButtonValue = true;
            //dgvSuppliers.Columns.Add(EditColumn);

            //DataGridViewButtonColumn DelColumn = new DataGridViewButtonColumn();
            //DelColumn.Text = "Delete";
            //DelColumn.Name = "Delete";
            //// DelColumn.DataPropertyName = "Delete";
            //DelColumn.UseColumnTextForButtonValue = true;
            //dgvSuppliers.Columns.Add(DelColumn);


            dgvSuppliers.DataSource = new SuppliersBpl().GetEBatchSuppliers();
            // var res = new UsersBpl().GetUsersDT();
            // dgvSuppliers.DataSource = res;

            dgvSuppliers.PageSize = 10;
            // dgvSuppliers.SetPagedDataSource(res, bindingNavigator1);


        }

        private void tbSupplier_FontChanged(object sender, EventArgs e)
        {

        }

        private void tbSupplier_Enter(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void tbRoleMapping_Enter(object sender, EventArgs e)
        {
            txtFake.GotFocus += textBox1_GotFocus;
            //lstAdusers = Utility.GetADUsers();
            LoadRoleMapping();
        }
        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            cbUsers.Focus();
        }

        private void LoadRoleMapping()
        {
            LoadUserRoleCB();

            //if (!cbUsers.Focused) { return; }

            //dgvUserRoleMapping.DataSource = new UsersBpl().GetUserRoleMapping();
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

            //var users = new UsersBpl().GetUsersDT();

            //users.Insert(0, new BL.User() { id = 0, username = "--Select User--" });
            //cbUsers.DataSource = users;
            //cbUsers.ValueMember = "id";
            //cbUsers.DisplayMember = "username";
        }

        private void LoadUserRoleMappingList(int userId)
        {
            var result = new UsersBpl().GetUserRoleMapping(userId);

            dgvUserRoleMapping.DataSource = result;
            dgvUserRoleMapping.EmptyResultText = "No Records Found";
        }
        private void cbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (!cb.Focused) { return; }

            var selectedItem = lstusers.Where(x => x.username == cb.SelectedItem.ToString()).SingleOrDefault();
            lblRoleValue.Text = selectedItem.userRole.RoleName;
            pnlRoleDisplay.Visible = true;

            LoadUserRoleMappingList(selectedItem.id);
            userId = selectedItem.id;
            //BL.User user = new BL.User()
            //{
            //    id = userId,

            //};
            //List<BL.User> lst = new UsersBpl().GetUserRole(user);

            //if (lst.Count > 0)
            //{
            //    lblRoleValue.Text = lst[0].userRoles;
            //}
            //else
            //{
            //    lblRoleValue.Text = string.Empty;
            //}

        }

        private void dgvUserRoleMapping_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUserRoleSave_Click(object sender, EventArgs e)
        {
            var dt = (List<BL.RoleMapping>)dgvUserRoleMapping.DataSource;
            new UsersBpl().SaveUserRoleMapping(userId, dt);
            Utility.ShowSuccessmessage1("User Role Mapping Saved");
        }

        private void btnAudit_Click(object sender, EventArgs e)
        {
            FrmAdminAudit aaf = new FrmAdminAudit();
            aaf.ShowDialog();
        }

        private void eNewButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //bindingNavigator
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            using (FrmAddUser aduser = new FrmAddUser())
            {
                if (aduser.ShowDialog() != DialogResult.Cancel)
                {
                    LoadUsers();
                }
            }
        }

        //bindingNavigator
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int userid = 0;
            userid = (int)dgvUsers.CurrentRow.Cells[0].Value;

            Utility.Validate();
            BL.User user = new BL.User()
            {
                id = userid,
                Status = false  //update only the status column
            };

            new UsersBpl().DeleteUsers(user);

            // dgvUsers.Refresh();
            RefreshUser();

        }

        //Refresh
        public void RefreshUser()
        {
            entryFound = true;
            LoadUsers();
        }

        private void tbAdminModule_Enter(object sender, EventArgs e)
        {
            LoadFilterDifficultyLevel();
        }

        private void LoadFilterDifficultyLevel()
        {
            Utility.LoadCodeToCB(cbFilterDifficulty, CodeEnum.DifficultyLevel, "--All--");
            Utility.LoadCodeToCB(cbFilterUserRole, CodeEnum.UserRole, "--All--");
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadUsers((int)cbFilterUserRole.SelectedValue, (int)cbFilterDifficulty.SelectedValue, txtFilterUserName.Text);
        }

        private void dgvUsers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //    if(e.ColumnIndex ==6 )
            //    {
            //        DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();

            //        datagridviewcell
            //       e.CellStyle.
            //    }
        }

        private void dgvUsers_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvUsers.CurrentCell.ColumnIndex == 2)
            {
                ComboBox combo = e.Control as ComboBox;

                if (combo == null)
                    return;

                combo.DropDownStyle = ComboBoxStyle.DropDown;
            }
        }

        private void lnkClearFilter_Click(object sender, EventArgs e)
        {
            txtFilterUserName.Text = "";
            txtFilterUserName.Text = "";
            cbFilterDifficulty.SelectedIndex = 0;
            cbFilterUserRole.SelectedIndex = 0;
            LoadUsers();
        }


    }
}
