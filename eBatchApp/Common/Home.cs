using eBatch.BusinessEntities.Enums;
using eBatch.Theme.Purple;
using eBatchApp.Admin;
using eBatchApp.DataEntry;
using eBatchApp.DataPrep;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace eBatchApp.Common
{
    public partial class Home : eForm
    {
        public Home()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
           
            RemoveCloseButton();
            researchandRejectToolStripMenuItem.Text = "RESEARCH " + Environment.NewLine + " && REJECT";
            //dataPrepToolStripMenuItem
            dataPrepToolStripMenuItem.Text = "DATA " + Environment.NewLine + "PREP";
            //dataEntryToolStripMenuItem
            dataEntryToolStripMenuItem.Text = "DATA " + Environment.NewLine + "ENTRY";
        }

        private void mnuApplication_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            ToolStripItem clickedItem = e.ClickedItem;
            string itemName = clickedItem.Text;

            switch (itemName)
            {
                case "ADMIN":
                    break;
                case "Users":
                    LoadAdminHome();
                    break;
                //case "Suppliers":
                //    FrmSupplier frmSupplier = new FrmSupplier();
                //    frmSupplier.MdiParent = this;
                //    frmSupplier.WindowState = FormWindowState.Maximized;
                //    frmSupplier.Show();
                //    break;
                //case "Data Entry":
                //    FrmDataEntry frmDataEntry = new FrmDataEntry();
                //    frmDataEntry.MdiParent = this;
                //    frmDataEntry.WindowState = FormWindowState.Maximized;
                //    frmDataEntry.Show();
                //    break;
                //case "Invoice Details":
                //    FrmDataEntry frmDataEntry = new FrmDataEntry();
                //    frmDataEntry.MdiParent = this;
                //    frmDataEntry.WindowState = FormWindowState.Maximized;
                //    frmDataEntry.Show();
                //    break;
                //case "File List":
                //    FrmFilelist FrmFilelist = new FrmFilelist();
                //    FrmFilelist.MdiParent = this;
                //    FrmFilelist.WindowState = FormWindowState.Maximized;
                //    FrmFilelist.Show();
                //    break;
                case "Exit":
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

       
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAdminHome();
            //HandleMenu();
            //FrmAdminHome frmAdmin = new FrmAdminHome();
            //frmAdmin.MdiParent = this;
            //frmAdmin.WindowState = FormWindowState.Maximized;
            //frmAdmin.Show();

            //User u.Show();ser = new User();
            //user.MdiParent = this;
            //user.WindowState = FormWindowState.Maximized;
            //user.Show();
        }

     
        // dataEntryToolStripMenuItem
        private void dataEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmDataEntry frmDataEntry = new FrmDataEntry();
            //frmDataEntry.MdiParent = this;
            //frmDataEntry.WindowState = FormWindowState.Maximized;
            //frmDataEntry.Show();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //FrmFilelist FrmFilelist = new FrmFilelist();
            //FrmFilelist.MdiParent = this;
            //FrmFilelist.WindowState = FormWindowState.Maximized;
            //FrmFilelist.Show();
        }


        private void FrmBase_MdiChildActivate(object sender, EventArgs e)
        {
            /*

            if (this.ActiveMdiChild == null)
                tabForms.Visible = false;
            // If no any child form, hide tabControl 
            else
            {
                this.ActiveMdiChild.WindowState =
                FormWindowState.Maximized;
                // Child form always maximized 

                // If child form is new and no has tabPage, 
                // create new tabPage 
                if (this.ActiveMdiChild.Tag == null)
                {
                    // Add a tabPage to tabControl with child 
                    // form caption 
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                    tp.Tag = this.ActiveMdiChild;
                    tp.Parent = tabForms;
                    tabForms.SelectedTab = tp;
                    this.ActiveMdiChild.Tag = tp;
                    this.ActiveMdiChild.FormClosed += new FormClosedEventHandler(ActiveMdiChild_FormClosed);
                }

                if (!tabForms.Visible) tabForms.Visible = true;

            }
            */
        }


        private void FrmBase_Load(object sender, EventArgs e)
        {

            //Control ctrlOnScreen, ctrlOffScreen;
            //ctrlOnScreen = this.pnlMenuLarge;
            //ctrlOffScreen = this.pnlMenuSmall;
            //ctrlOnScreen.SendToBack();
            //ctrlOffScreen.BringToFront();

            //Transition t = new Transition(new TransitionType_EaseInEaseOut(1000));
            //t.add(ctrlOnScreen, "Left", -1 * ctrlOnScreen.Width);
            //t.add(ctrlOffScreen, "Left", 12);
            //t.run();



            tileTopUser.Text = GlobalConstants.LogginInUserDisplayName;
            LoadHomeDashBoard();
           // panel2.Visible = false;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.ControlBox = false;
            //this.Text = String.Empty;
        }

        private async void LoadHomeDashBoard()
        {           
            // HomeDashboard frmHomeDashboard = new HomeDashboard(this);
            FrmHomeDashboard frmHomeDashboard = new FrmHomeDashboard(this);
            frmHomeDashboard.MdiParent = this;
            frmHomeDashboard.WindowState = FormWindowState.Maximized;
            frmHomeDashboard.Show();
            await Task.Delay(500);
            HandleLeftMenu();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmSupplier frmSupplier = new FrmSupplier();
            //frmSupplier.MdiParent = this;
            //// Home.WindowState = FormWindowState.Maximized;
            //frmSupplier.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandleLeftMenu(true);
        }

        private void HandleLeftMenu(bool toggle = false)
        {
            if (pnlMenuLarge.Visible == pnlMenuSmall.Visible)
            {
                pnlMenuContainer.Visible = true;
                pnlMenuLarge.Visible = true;
                pnlMenuSmall.Visible = false;
                pnlMenuContainer.Width = 235;
                pnlToggleContainer.Location = new Point(240, 145);
                imgToggle.Image = eBatchApp.Properties.Resources.collapse;
                return;
            }

            if (toggle)
            {
                pnlMenuLarge.Visible = !pnlMenuLarge.Visible;
                pnlMenuSmall.Visible = !pnlMenuSmall.Visible;

                if (pnlMenuLarge.Visible)
                {
                    pnlMenuContainer.Width = 235;
                    pnlToggleContainer.Location = new Point(240, 145);
                    imgToggle.Image = eBatchApp.Properties.Resources.collapse;
                }
                else
                {
                    pnlMenuContainer.Width = 70;
                    pnlToggleContainer.Location = new Point(72, 145);
                    imgToggle.Image = eBatchApp.Properties.Resources.expand;
                }
            }
        }

        private void InvoiceEntry_Click(object sender, EventArgs e)
        {
            //InvoiceEntry frmInvoiceEntry = new InvoiceEntry();
            //frmInvoiceEntry.MdiParent = this;
            //frmInvoiceEntry.WindowState = FormWindowState.Maximized;
            //frmInvoiceEntry.Show();
            LoadDataEntryHome();
        }


        private void tileTopUser_Click(object sender, EventArgs e)
        {
            LoadHomeDashBoard();
            this.pnlMenuContainer.Visible = false;
        }

        private void lnkExit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void tileLeftMenuAdmin_Click(object sender, EventArgs e)
        {
            LoadAdminHome();
        }

        private void LoadAdminHome()
        {
            pnlMenuContainer.Visible = false;
            GlobalConstants.baseForm = this;
            FrmAdminHome Home = new FrmAdminHome();
            Home.MdiParent = this;
            Home.WindowState = FormWindowState.Maximized;
            Home.Show();
        }
        private void LoadDataPrep()
        {
            pnlMenuContainer.Visible = false;
            GlobalConstants.baseForm = this;
            FrmDataPrepHome Home = new FrmDataPrepHome();
            Home.MdiParent = this;
            Home.WindowState = FormWindowState.Maximized;
            Home.Show();
        }

        private void filelisttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDataPrep();
        }

        private void InvoiceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDataPrep();
        }


        private void tileLeftLargeDataPrep_Click(object sender, EventArgs e)
        {
            LoadDataPrep();
        }

        private void InvoiceDetails_Click(object sender, EventArgs e)
        {
            ////pnlMenuContainer.Visible = false;
            ////GlobalConstants.baseForm = this;
            //FrmDataEntryHome fDataEntryHome = new FrmDataEntryHome();
            //fDataEntryHome.MdiParent = this;
            //fDataEntryHome.WindowState = FormWindowState.Maximized;
            //fDataEntryHome.Show();
            LoadDataEntryHome();
        }

        private void LoadDataEntryHome()
        {
            pnlMenuContainer.Visible = false;
            GlobalConstants.baseForm = this;
            FrmDataEntryHome fDataEntryHome = new FrmDataEntryHome();
            fDataEntryHome.MdiParent = this;
            fDataEntryHome.WindowState = FormWindowState.Maximized;
            fDataEntryHome.Show();
        }

       
        private void tileLeftLargeDataEntry_Click(object sender, EventArgs e)
        {
            LoadDataEntryHome();
        }

        private void dataEntryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoadDataEntryHome();
        }

        //Tool strips
        private void InvoiceList_Click(object sender, EventArgs e)
        {
            LoadDataEntryHome();
        }

        private void InvoiceDetail_Click(object sender, EventArgs e)
        {
            LoadDataEntryHome();
        }

    }
}
