using eBatch.BusinessEntities.Enums;
using eBatch.BusinessLogic.Bpl;
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
using Transitions;

namespace eBatchApp.Common
{
    public partial class FrmHomeDashboard : eForm
    {
        Form _pForm = null;
        public FrmHomeDashboard()
        {
            InitializeComponent();
        }
        private void LoadGlobalValues()
        {
            GlobalConstants.lstUsers = new UsersBpl().GetUsers();
            GlobalConstants.lstAllSupplier = new SuppliersBpl().GetAllSuppliers();
        }

        public FrmHomeDashboard(Form pForm)
        {
            InitializeComponent();
            _pForm = pForm;
            lblUserName.Text = GlobalConstants.LogginInUserName + "!";
            lblDate.Text = System.DateTime.Now.ToLongDateString();
            lblTime.Text = System.DateTime.Now.ToShortTimeString();
            LoadGlobalValues();

            Transition.run(lblUserName, "BackColor", Color.Yellow, new TransitionType_Flash(1, 1000));

            //string strText1 = "Welcome to eBatch, " + GlobalConstants.LogginInUserName + "!"; ;
            //Color color1 = Color.Red;
            //string strText2 = "Welcome to eBatch, " + GlobalConstants.LogginInUserName + "!"; ;

            //Color color2 = Color.Blue;
            //Transition t = new Transition(new TransitionType_Linear(4000));
            //t.add(lblWelcome, "Text", strText1);
            //t.add(lblWelcome, "ForeColor", color1);
            //t.add(lblWelcome, "Text", strText2);
            //t.add(lblWelcome, "ForeColor", color2);
            //t.run();

        }
    }
}