using eBatch.BusinessEntities.Enums;
using eBatch.Theme.Purple;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XsPDF.Pdf;

namespace eBatchApp.DataPrep
{
    public partial class FrmPDFView : eForm
    {
        public FrmPDFView()
        {
            InitializeComponent();
        }

        public void PdfImage_Selected(object sender, EventArgs e)
        {
            txtSelectedPages.Text = txtSelectedPages.Text + " "+ ((PdfThumbnail)sender).PdfImageId.Replace("pdfImage","");
        }

        public FrmPDFView(string strPDFPath)
        {
            InitializeComponent();
            LoadPdfThumbnails(strPDFPath);
        }

        private void LoadPdfThumbnails(string strPDFPath)
        {
            SavePDF2Images(strPDFPath);
            var images = GetImageFileNames();
            ShowImages(images);
        }

        private void ShowImages(List<string> images)
        {
            int i = 0;
            int j = 0;
            PictureBox[] pics = new PictureBox[images.Count];
            Panel[] flws = new Panel[images.Count];
            RadioButton[] rdo = new RadioButton[images.Count];

            PdfThumbnail[] pdfTN = new PdfThumbnail[images.Count];
           


            foreach (var item in images)
            {
                pdfTN[i] = new PdfThumbnail();
                pdfTN[i].ImageUrl = item;
                pdfTN[i].PdfImageId = "pdfImage"+i.ToString();
                pdfTN[i].locationX = j;
                pdfTN[i].locationY = 10;
                pdfTN[i].LoadImage(item);
                pdfTN[i].SelectImage += new EventHandler(PdfImage_Selected);


                j = j + 180;
               //int brh = 0;
               // flws[i] = new Panel();
               // flws[i].Name = "flw" + i;
               // flws[i].Location = new Point(3, brh);
               // flws[i].Size = new Size(200, 150);
               // flws[i].BackColor = Color.DarkCyan;
               //// flws[i].BorderStyle = BorderStyle.Fixed3D;

               // pics[i] = new PictureBox();
               // pics[i].Name = "pic" + i;
               // pics[i].Size = new Size(200, 150);
               // pics[i].Load(item);
               // flws[i].Controls.Add(pics[i]);


               // rdo[i] = new RadioButton();
               // rdo[i].Name = i.ToString();
               // rdo[i].Text = "Page " + i;
               // rdo[i].ForeColor = Color.Red;
               // rdo[i].Location = new Point(853, 186 + brh);
               // //rdo[i].Click += new EventHandler(rdo_Click);
               // flws[i].Controls.Add(rdo[i]);

               // this.Controls.Add(flws[i]);
                flowLayoutPanel1.Controls.Add(pdfTN[i]);
               // brh += 130;
                i++;

            }
        }


        private List<string> GetImageFileNames()
        {
            var path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Output\\Images";
            return Directory.GetFiles(path, "*.jpg", SearchOption.TopDirectoryOnly).ToList();
        }

        private void SavePDF2Images(string strPDFPath)
        {
            string sourcePath = strPDFPath;
            string outputPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Output\\Images\\";
            PdfImageConverter pdfConverter = new PdfImageConverter(sourcePath);

            pdfConverter.DPI = 96;
            Directory.CreateDirectory(Path.GetDirectoryName(outputPath));


            for (int i = 0; i < pdfConverter.PageCount - 1; i++)
            {
                Image pageImage = pdfConverter.PageToImage(i, 300, 300);
                pageImage.Save(outputPath + "Page" + i + ".jpg", ImageFormat.Jpeg);
            }
        }

        private void FrmPDFView_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lnkBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
