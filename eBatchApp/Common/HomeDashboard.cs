using eBatch.Theme.Purple;
using eBatchApp.Admin;
using MetroFramework.Controls;
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
using MarkupConverter;

namespace eBatchApp.Common
{
    public partial class HomeDashboard : eForm
    {
        Form _pForm = null;
        public HomeDashboard()
        {
            InitializeComponent();
        }
        public HomeDashboard(Form pForm)
        {
            InitializeComponent();
            _pForm = pForm;
        }

        private void HomeDashboard_Load(object sender, EventArgs e)
        {


            var message = "<p style=\"font-family:verdana;font-size:6;\"><p>Welcome to eBatch Application.</p><br><br> hi User, Good Morning.<br><br>                    " +
                                 "<p><strong>Messages:</strong></p> <br>                                                    " +
                                 "<p><span style=\"text - decoration: underline; \">13 Nov 2018:</span></p>                  " +
                                    "<p style=\"padding - left: 30px; \">3 Invoices been assigned to you by Admin.</p>          " +
                                       "<p style=\"padding - left: 30px; \">10 Invoices been sent to disbursement</p> <br>             " +
                                          "<p><span style=\"text - decoration: underline; \">12 Nov 2018:</span></p>                  " +
                                             "<p style=\"padding - left: 30px; \">13 Invoices been assigned to you by Admin.</p>         " +
                                                "<p style=\"padding - left: 30px; \">15&nbsp;Invoices been sent to disbursement</p>         " +
                                                   "<p>&nbsp;</p>" +
                                                   "<p>&nbsp;</p></p>";
         


           string rtfString= HtmlToRtfConverter.ConvertHtmlToRtf(message);
            richTextBox1.Rtf = rtfString;
            ManageTileColor();
        }

        private void ManageTileColor()
        {
            foreach (var mtile in this.Controls.OfType<MetroTile>())
            {
                mtile.MouseEnter += MetroTile_MouseEnter;
                mtile.MouseLeave += MetroTile_MouseLeave;
                mtile.Cursor = Cursors.Hand;
                // this.AdminTile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AdminTile_MouseClick);
            }
        }

        private void MetroTile_MouseEnter(object sender, EventArgs e)
        {
            ((MetroTile)sender).BackColor = Color.FromArgb(79, 21, 108);
        }

        private void MetroTile_MouseLeave(object sender, EventArgs e)
        {
            ((MetroTile)sender).BackColor = Color.FromArgb(132, 118, 132); ;
        }

        private void AdminTile_Click(object sender, EventArgs e)
        {

            FrmAdminHome frmAdmin = new FrmAdminHome();
            frmAdmin.MdiParent = _pForm;
            frmAdmin.WindowState = FormWindowState.Maximized;
            frmAdmin.Show();
            this.Hide();
            _pForm.Controls["panel2"].Visible = true;
        }

        private void AdminTile_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void AdminTile_MouseEnter(object sender, EventArgs e)
        {
            //AdminTile.BackColor = Color.FromArgb(79, 21, 108);
        }

        private void AdminTile_MouseHover(object sender, EventArgs e)
        {
        }

        private void AdminTile_MouseLeave(object sender, EventArgs e)
        {
            //AdminTile.BackColor = Color.FromArgb(132, 118, 132);
        }
    }
}
