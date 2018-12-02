using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBatch.Theme.Purple
{
    public partial class PdfThumbnail : UserControl
    {
        public string ImageUrl { get; set; }
        public string PdfImageId { get; set; }

        public int locationX { get; set; }
        public int locationY { get; set; }

        public event EventHandler SelectImage;

        public PdfThumbnail()
        {
            InitializeComponent();
            
        }

        private void chkPdfImage_CheckedChanged(object sender, EventArgs e)
        {
            if (this.SelectImage != null)
            {
                SelectImage(this, e);
            }
        }

        private void PdfThumbnail_Load(object sender, EventArgs e)
        {
            //this.picPDFImage1.Load(ImageUrl);
        }

        public void LoadImage(string imageUrl)
        {
            this.picPDFImage1.Load(imageUrl);
            this.Location = new Point(locationX, locationY);
        }
    }
}
