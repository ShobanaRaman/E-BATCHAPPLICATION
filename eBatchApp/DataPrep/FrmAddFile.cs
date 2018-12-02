using eBatch.BusinessEntities.Enums;
using eBatch.BusinessEntities.Models;
using eBatch.BusinessLogic.Bpl;
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
    public partial class FrmAddFile : eForm
    {
        FileLog fileLog = new FileLog();
        List<Supplier> lstSupplier = new List<Supplier>();
        string strSourceFilePath = string.Empty;
        public FrmAddFile()
        {
            InitializeComponent();
            txtFake.GotFocus += textBox1_GotFocus;
        }

        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            cbSupplier.Focus();
        }

        private void FrmAddFile_Load(object sender, EventArgs e)
        {
            lstSupplier = new SuppliersBpl().GetAllSuppliers();
            var lstFilteredAD = lstSupplier.Select(x => x.Email).Distinct();

            AutoCompleteStringCollection aa = new AutoCompleteStringCollection();
            aa.AddRange(lstFilteredAD.ToArray());

            cbSupplier.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbSupplier.AutoCompleteCustomSource = aa;
            cbSupplier.Items.AddRange(lstFilteredAD.ToArray());
            cbSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eNewButton1_Click(object sender, EventArgs e)
        {
          

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "PDF Files|*.pdf";
            openFileDialog1.Title = "Select a PDF File";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                strSourceFilePath= openFileDialog1.FileName;
                txtFileName.Text = Path.GetFileName(strSourceFilePath);
                var size = new FileInfo(openFileDialog1.FileName).Length;
                fileLog.AttachmentFileSize = size.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string pdfPath = "C:\\eBatchPDF\\{CIN}\\{RECEIPTDATE}";
           // string pdfPath = GlobalConstants.lstSetting.Where(x => x.KeyText == "PDFPATH").Select(y => y.ValueText).FirstOrDefault();
            string strCIN = lstSupplier.Where(x => x.Email == cbSupplier.Text).Select(y => y.CIN).FirstOrDefault();
            int SupplierId = lstSupplier.Where(x => x.Email == cbSupplier.Text).Select(y => y.Supplierid).FirstOrDefault();
            int? DifficultyLevel = lstSupplier.Where(x => x.Email == cbSupplier.Text).Select(y => y.DifficultyLevel).FirstOrDefault();
            string FileName = txtFileName.Text;
            pdfPath = pdfPath.Replace("{CIN}", strCIN);
            pdfPath = pdfPath.Replace("{RECEIPTDATE}", dtReceiptDate.Value.ToString("yyyy-MM-dd"));

            fileLog.ReceiptDate = dtReceiptDate.Value;
            fileLog.AttachmentFileName = FileName;
            fileLog.AttachmentFileDisplayName = FileName;
            fileLog.SupplierId = SupplierId;
            fileLog.SupplierEmail = cbSupplier.Text;
            fileLog.DifficultyLevel = (int)DifficultyLevel;

            SaveFile(pdfPath);
            new AttachmentLogBpl().SaveFile(fileLog);
            this.Close();
            //Fill all the fields and save fileLog object.
        
        }

        private void SaveFile(string destPath)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(destPath + "\\" + fileLog.AttachmentFileName));

            File.Copy(strSourceFilePath, destPath + "\\" + fileLog.AttachmentFileName);
        }
    }
}
