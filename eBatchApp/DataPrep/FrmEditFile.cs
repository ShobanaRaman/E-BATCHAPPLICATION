using eBatch.BusinessEntities.Enums;
using eBatch.BusinessEntities.Models;
using eBatch.BusinessLogic.Bpl;
using eBatch.Theme.Purple;
using eBatchApp.Common;
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
    public partial class FrmEditFile : eFormPopup
    {
        string pdfPath = string.Empty;
        string strSourceFilePath = string.Empty;
        List<Supplier> lstSupplier = new List<Supplier>();
        FileLog fileLog = new FileLog();
        public FrmEditFile()
        {
            InitializeComponent();
            Utility.LoadCodeToCB(cbDifficultyLevel, CodeEnum.DifficultyLevel, "--Select--");
        }
        int FileId =0;
        public void AddFileId(int id)
        {
            FileId = id;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
           lstSupplier = new SuppliersBpl().GetAllSuppliers();
            pdfPath = "C:\\eBatchPDF\\{CIN}\\{RECEIPTDATE}";
            // string pdfPath = GlobalConstants.lstSetting.Where(x => x.KeyText == "PDFPATH").Select(y => y.ValueText).FirstOrDefault();
            string strCIN = lstSupplier.Where(x => x.Email == lblSupplierEmail.Text).Select(y => y.CIN).FirstOrDefault();          
            string FileName = txtFileName.Text;
            pdfPath = pdfPath.Replace("{CIN}", strCIN); 
            pdfPath = pdfPath.Replace("{RECEIPTDATE}", DateTime.Parse(lblReceiptDate.Text).ToString("yyyy-MM-dd"));
            fileLog.Id = FileId;
            fileLog.AttachmentFileName = FileName;
            fileLog.DifficultyLevel = cbDifficultyLevel.SelectedValue.toInt();
            string folderpath = pdfPath;
            string PDFPath = pdfPath + "\\" + fileLog.AttachmentFileName;
            SaveFile(PDFPath, pdfPath);
            new AttachmentLogBpl().EditFile(fileLog);
            Utility.ShowSuccessmessage("Edited the File " );
            this.Close();

        }

       private void SaveFile(string destPath,string folderPath) //considered saving single file
        {            
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(folderPath));        
            }
            MoveReplacedFiles();
            File.Copy(strSourceFilePath, destPath );
        }

        private void MoveReplacedFiles()
        {
            string DeletedpdfPath = "C:\\DeletedFiles";        
            FileInfo Fileresult = null;          
            var directory = new DirectoryInfo(pdfPath);
            var PDFList = directory.GetFiles("*.Pdf");
            if(PDFList.Count() > 0)
            {
                if (!Directory.Exists(DeletedpdfPath))
                {
                    //Directory.CreateDirectory(Path.GetDirectoryName(DeletedpdfPath));
                    Directory.CreateDirectory(DeletedpdfPath);

                }
                Fileresult = PDFList.OrderByDescending(f => f.LastWriteTime).First();
                var path = DeletedpdfPath + "\\" + Fileresult;
                if (File.Exists(path))
                {
                    File.Delete(DeletedpdfPath + "\\" + Fileresult);
                }
                    
                System.IO.File.Move(pdfPath+"\\"+ Fileresult, DeletedpdfPath+"\\" + Fileresult);
            }

      
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "PDF Files|*.pdf";
            openFileDialog1.Title = "Select a PDF File";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                strSourceFilePath = openFileDialog1.FileName;
                txtFileName.Text = Path.GetFileName(strSourceFilePath);
                var size = new FileInfo(openFileDialog1.FileName).Length;
                fileLog.AttachmentFileSize = size.ToString();
            }
        }
    }
}
