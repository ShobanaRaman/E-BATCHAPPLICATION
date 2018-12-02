using eBatch.Theme.Purple;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBatchApp.DataPrep
{
    public partial class FrmRejectImage : eFormPopup
    {
        string pdfpath = string.Empty;
        int id = 0;
        public FrmRejectImage()
        {
            InitializeComponent();
            
        }

        public void holdpath(string path , int idvalue)
        {
            pdfpath = path;
            id = idvalue;
        }
        public void LoadPdfFile( )
        {
            if (!Directory.Exists(pdfpath))
            {
                axAcroPDF1.LoadFile(pdfpath);

            }
        }

        private void btnRejectImage_Click(object sender, EventArgs e)
        {
             using (FrmRejectReason RejectReason = new FrmRejectReason())
            {
                RejectReason.holdid(id);
                if (RejectReason.ShowDialog() != DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
