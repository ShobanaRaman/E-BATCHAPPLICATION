using eBatch.BusinessEntities.Enums;
using eBatch.BusinessLogic.Bpl;
using eBatch.Theme.Purple;
using eBatchApp.Admin;
using eBatchApp.DataEntry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBatchApp.Common
{
    public partial class Login : eForm
    {
        public Login()
        {
            InitializeComponent();
            LoadCurrentUser();
        }

        private void LoadCurrentUser()
        {
            textBox1.Text = Environment.UserName;
            textBox2.Text = "************";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Login as " + Environment.UserName + ". Please wait...";
            imgLoading.Visible = true;
            await Task.Delay(1000);

            if (Utility.GetLoggedUserDetails(Environment.UserName))
            {
                this.Hide();
                Home home = new Home();
                home.Show();
            }
            else
            {
                lblMessage.Text = "User " + Environment.UserName + " doesn't have acess.";
            }
        }

    }
}
