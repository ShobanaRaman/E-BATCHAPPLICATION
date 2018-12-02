using eBatch.BusinessEntities.Enums;
using eBatch.BusinessLogic.Bpl;
using eBatch.Theme.Purple;
using System;
using eBatchApp.Common;
using BL = eBatch.BusinessEntities.Models;
using System.Windows.Forms;

using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eBatchApp.Admin
{
    public partial class FrmAddUser : eFormPopup
    {
        List<string> lstAdusers = new List<string>();
        bool isEditMode = false;
        public FrmAddUser()
        {
            InitializeComponent();
            txtFake.GotFocus += textBox1_GotFocus;
            lstAdusers = GetADUsers();
        }

        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            cbUserName.Focus();
        }

        public int usrgrdid = 0;
        public void AddUserID(int uID)
        {
            usrgrdid = uID;
        }


        private void AddUser_Load(object sender, EventArgs e)
        {
            if (usrgrdid == 0)
            {
                //AutoCompleteStringCollection lstAdUsers = new AutoCompleteStringCollection();
                //lstAdUsers.AddRange(GetADUsers().ToArray());
                //cbUserName.AutoCompleteCustomSource = lstAdUsers;
                Utility.LoadCodeToCB(cbDifficultyLevel, CodeEnum.DifficultyLevel, "--Select--");
                Utility.LoadCodeToCB(cbRole, CodeEnum.UserRole, "--Select--");

                var lstFilteredAD = lstAdusers;

                AutoCompleteStringCollection aa = new AutoCompleteStringCollection();
                aa.AddRange(lstFilteredAD.ToArray());

                cbUserName.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbUserName.AutoCompleteCustomSource = aa;
                cbUserName.Items.AddRange(lstFilteredAD.ToArray());
                cbUserName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            }
            else
            {
                txtFake.Enabled = false;
                isEditMode = true;
            }
            lblSave.Text = "";
            lblValid.Text = "";
            listBox1.Hide();
            btnSelect.Hide();
            //lblAD.Hide();

        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            lblSave.Text = "";
            lblValid.Text = "";
           // Utility.Validate(this);
           if(!isEditMode)
            ValidateEnableUserForm();


            BL.User user = new BL.User()
            {
                id = usrgrdid,
                username = cbUserName.Text,
                userRole = new BL.Role() { RoleId = cbRole.SelectedValue.toInt() },
                difficultylevel = cbDifficultyLevel.SelectedValue.toInt(),
                Status = true// checkBox1.Checked
            };
            //if (usrgrdid == 0 & txtUserName.Text != "")
            //{
            //    lblSave.Text = "Saved User Successfully!";
            //}
            //if (usrgrdid != 0 & txtUserName.Text != "")
            //{
            //    lblSave.Text = "Updated User Successfully!";
            //}

            //if (txtUserName.Text == "")
            //{
            //    lblValid.Text = "*please provide User Name!";
            //}
            //else
                new UsersBpl().SaveUsers(user);
            Utility.ShowSuccessmessage("Enabled User " + cbUserName.Text);

             this.Close();
        }

        private void ValidateEnableUserForm()
        {
            bool isValid = true;
            StringBuilder sb = new StringBuilder();

            if (cbUserName.SelectedIndex < 1)
            {
                isValid = false;
                sb.Append("User Name \n");
            }
            if (cbRole.SelectedIndex < 1)
            {
                isValid = false;
                sb.Append(" User Role \n");
            }
            if (cbDifficultyLevel.SelectedIndex < 1)
            {
                isValid = false;
                sb.Append(" Difficulty Level \n");
            }

            if(!isValid)
            {
                Utility.ShowAlertmessage(sb.ToString());
                return;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // public UserPrincipal GetADUser(string argUserName)

        public List<string> GetADUser(string argUserName)
        {
            List<string> searchUsers = new List<string>();
            // UserPrincipal result = null;
            try
            {
                if (argUserName.Length > 0)
                {
                    // establishing the server connection
                    // providedAD = Trim(SCB.GetWithDefault("ActiveDirectoryName", ""));

                    // create your domain context
                    PrincipalContext AD = new PrincipalContext(ContextType.Domain, "ch-telliant.com"); // to test in domain

                    //'to test in local if it is workgroup, for dev.

                    // PrincipalContext AD = new PrincipalContext(ContextType.Machine, providedAD); // to test in domain

                    UserPrincipal user = new UserPrincipal(AD); // Environment.UserName/ADUserName from db
                    user.GivenName = argUserName + "*";           // search for user in Active Directory

                    // create your principal searcher passing in the user principal
                    PrincipalSearcher search = new PrincipalSearcher(user);


                    foreach (var found in search.FindAll())
                    {
                        listBox1.Show();
                        btnSelect.Show();

                        if (found != null && found.DisplayName != null)
                        {
                            // searchUsers.Add(found.DisplayName + "(" + found.SamAccountName + ")");

                            searchUsers.Sort();
                            searchUsers.Add(found.SamAccountName);

                            // search.Dispose();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            listBox1.DataSource = searchUsers;
            return searchUsers;
            // return result;
        }

        public List<string> GetADUsers()
        {
            listBox1.Show();
            btnSelect.Show();
            //lblAD.Show();
            List<string> allUsers = new List<string>();
            // UserPrincipal result = null;
            try
            {
                PrincipalContext AD = new PrincipalContext(ContextType.Domain, "ch-telliant.com"); // to test in domain
                UserPrincipal user = new UserPrincipal(AD);
                PrincipalSearcher search = new PrincipalSearcher(user);
                //foreach (var found in search.FindAll())
                //{
                //    allUsers.Add(found.DisplayName + "(" + found.SamAccountName + ")");
                //    allUsers.Sort();   
                //}

                foreach (UserPrincipal result in search.FindAll())
                {
                    //if (result.EmailAddress != null)
                    if (result.DisplayName != null && result.Enabled == true)
                    {
                        if (result.DistinguishedName != "CN=" + result.DisplayName + ",OU=Internal User,DC=abcgroup,DC=internal" && result.Enabled == true)
                            // allUsers.Add(result.DisplayName);
                            allUsers.Add(result.SamAccountName);

                        //comboBox1.Items.Add(allUsers);
                        // listBox1.DataSource = allUsers;
                    }
                }

            }
            catch (Exception ex)
            {

            }
            listBox1.DataSource = allUsers;

            return allUsers;
        }

        // <summary>
        /// Active Directory User.
        /// </summary>

        private void btnADsearch_Click(object sender, EventArgs e)
        {
            lblSave.Text = "";
            lblValid.Text = "";
            if (txtUserName.Text != string.Empty)
                GetADUser(txtUserName.Text);
            else
                GetADUsers();

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            lblSave.Text = "";
            lblValid.Text = "";
            txtUserName.Text = listBox1.GetItemText(listBox1.SelectedItem);
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            lblSave.Text = "";
            lblValid.Text = "";
        }

        private void cbUserName_KeyPress(object sender, KeyPressEventArgs e)
        {



        }

        private void cbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbUserName_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void eLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblUserNameValidation.Visible = false;
            var lstusers=  Utility.GeteBatchUsers();
            ComboBox cb = (ComboBox)sender;
            if (!cb.Focused) { return; }

            if(lstusers.Count(x => x.username == cb.SelectedItem.ToString()) > 0)
            {
                lblUserNameValidation.Visible = true;
            }
        }
    }
}
