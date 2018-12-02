using eBatch.BusinessEntities.Enums;
using eBatch.BusinessLogic.Bpl;
using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL = eBatch.BusinessEntities.Models;

namespace eBatchApp.Common
{
    public static class Utility
    {

        internal static void ShowAlertmessage(string message)
        {
            MessageBox.Show("Please enter the following:\n\n\n " + message, "Validation Error:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void ShowSuccessmessage(string message)
        {
            MessageBox.Show("Successfully " + message, "Success");
        }
        public static void ShowSuccessmessage1(string message)
        {
            MessageBox.Show(message + " Successfully", "Success");
        }
        public static DialogResult Showconfirmation(string message)
        {
            return MessageBox.Show(message,
      "confirmation",
      MessageBoxButtons.YesNo,
      MessageBoxIcon.Question,
      MessageBoxDefaultButton.Button2);
        }


        public static List<string> GetADUsers()
        {
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

            return allUsers;
        }


        public static bool GetLoggedUserDetails(string uName)
        {
            return new CommonBpl().GetUserDetails(uName);
        }

        public static void LoadCodeToCB(ComboBox cb, CodeEnum code, string defaultValue = null)
        {
            var lstCode = new CodeBpl().GetCode(code);
            if (!string.IsNullOrEmpty(defaultValue))
            {
                lstCode.Insert(0, new BL.Codevalue() { id = 0, CodeValue = defaultValue });
            }
            cb.DataSource = lstCode.Select(x => new { id = x.id, codevalue = x.CodeValue }).ToList();
            cb.DisplayMember = "Codevalue";
            cb.ValueMember = "id";
        }

        public static List<BL.Codevalue> LoadCode(CodeEnum code)
        {
            return new CodeBpl().GetCode(code);
        }

        public static int toInt(this object value)
        {
            return Convert.ToInt32(value);
        }

        internal static void Validate()
        {
            ///... Common validation has to be coded.
        }

        internal static bool Validate(Form currentForm)
        {
            bool isValid = true;
            StringBuilder sb = new StringBuilder();
            foreach (var c in currentForm.Controls)
            {
                if (c is TextBox)
                {
                    if (((TextBox)c).Text.Length < 1)
                    {
                        isValid = false;
                    }
                }
                if (c is ComboBox)
                {
                    if (((ComboBox)c).SelectedValue.ToString() == "0")
                    {
                        isValid = false;
                    }
                }
            }
            return isValid;
        }

        internal static List<BL.User> GeteBatchUsers()
        {
            List<BL.User> lstUser = new List<eBatch.BusinessEntities.Models.User>();
            if (GlobalConstants.lstUsers != null)
            {
                lstUser = GlobalConstants.lstUsers;
            }
            else
            {
                lstUser = new UsersBpl().GetUsers();
            }
            return lstUser;
        }
    }
}
