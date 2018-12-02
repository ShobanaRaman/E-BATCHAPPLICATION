using eBatch.BusinessEntities.Enums;
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
using BL = eBatch.BusinessEntities.Models;
using eBatch.BusinessLogic.Bpl;
using eBatchApp.Common;
using AxAcroPDFLib;
using System.IO;

namespace eBatchApp.DataPrep
{
    public partial class FrmDataPrepHome : eForm
    {
        //List<BL.AttachmentLog> FileLst = new List<BL.AttachmentLog>();

        BL.FileLog fileLog = new BL.FileLog();
        public FrmDataPrepHome()
        {
            InitializeComponent();
            GlobalConstants.baseForm.Controls.Find("pnlMenuContainer", true).FirstOrDefault().Visible = true;
            dgvFileList.AutoGenerateColumns = false;
            dgvInvoiceList.AutoGenerateColumns = false;
            Utility.LoadCodeToCB(cbDifficultyLevel, CodeEnum.DifficultyLevel, "--Select--");
            Utility.LoadCodeToCB(cbInvoiceStatus, CodeEnum.InvoiceStatus, "--Select--");

            LoadFileList();
            LoadInvoiceList();


        }
        public void LoadFileList(string FromDate = null, string ToDate =null, int?DifficultyLevel=0 , string FileName =null )
        {

        
             var FileLst = new AttachmentLogBpl().GetFileListDT(FromDate,ToDate, DifficultyLevel, FileName);
            dgvFileList.DataSource = FileLst;
            dgvFileList.PageSize = 10;
            dgvFileList.SetPagedDataSource(FileLst, bindingNavigator1);
           

        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            using (FrmAddFile addFile = new FrmAddFile())
            {
                if (addFile.ShowDialog() != DialogResult.Cancel)
                {

                }
            }
            LoadFileList();
        }

        private void dgvFileList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 7)  //View record
                {
                    var strPdfPath = "C:\\eBatchPDF\\{CIN}\\{RECEIPTDATE}";
                    //var strPdfPath = GlobalConstants.lstSetting.Where(x => x.KeyText == "PDFPATH").Select(y => y.ValueText).FirstOrDefault();               
                    var strCIN = GlobalConstants.lstAllSupplier.Where(x => x.Email == dgvFileList.CurrentRow.Cells[3].Value.ToString()).Select(y => y.CIN).FirstOrDefault();
                    var strReceiptDate = Convert.ToDateTime(dgvFileList.CurrentRow.Cells[1].Value).ToString("yyyy-MM-dd");

                    strPdfPath = strPdfPath.Replace("{CIN}", strCIN);
                    strPdfPath = strPdfPath.Replace("{RECEIPTDATE}", strReceiptDate);
                    strPdfPath = strPdfPath + "\\" + dgvFileList.CurrentRow.Cells[8].Value.ToString();

                    using (FrmPDFView frmPdfView = new FrmPDFView(strPdfPath))
                    {
                        if (frmPdfView.ShowDialog() != DialogResult.Cancel)
                        {
                            //LoadFileList();
                        }
                    }
                }


                if (e.ColumnIndex == 6)  //edit record
                {
                    int Id = 0;
                    using (FrmEditFile EditFile = new FrmEditFile())

                    {
                        int difflevel = (int)dgvFileList.CurrentRow.Cells[4].Value;
                        EditFile.lblReceiptDate.Text = Convert.ToString(dgvFileList.CurrentRow.Cells[1].Value);
                        EditFile.lblAttachementID.Text = Convert.ToString(dgvFileList.CurrentRow.Cells[2].Value);
                        EditFile.lblSupplierEmail.Text = Convert.ToString(dgvFileList.CurrentRow.Cells[3].Value);
                        EditFile.cbDifficultyLevel.Text = Convert.ToString(difflevel);
                        Id = Convert.ToInt32(dgvFileList.CurrentRow.Cells[0].Value);

                        EditFile.AddFileId(Id);
                        if (EditFile.ShowDialog() != DialogResult.Cancel)
                        {
                            this.Close();
                        }
                        LoadFileList();
                    }
                }
                if (e.ColumnIndex == 5)
                {
                    using (FrmRejectImage frmrejectimage = new FrmRejectImage())
                    {   
                        var strPdfPath = "C:\\eBatchPDF\\{CIN}\\{RECEIPTDATE}";
                        var strCIN = GlobalConstants.lstAllSupplier.Where(x => x.Email == dgvFileList.CurrentRow.Cells[3].Value.ToString()).Select(y => y.CIN).FirstOrDefault();
                        var strReceiptDate = Convert.ToDateTime(dgvFileList.CurrentRow.Cells[1].Value).ToString("yyyy-MM-dd");

                        strPdfPath = strPdfPath.Replace("{CIN}", strCIN);
                        strPdfPath = strPdfPath.Replace("{RECEIPTDATE}", strReceiptDate);
                        var directory = new DirectoryInfo(strPdfPath);
                        if (Directory.Exists(strPdfPath))
                        {
                            var PDFList = directory.GetFiles("*.Pdf");
                            if (PDFList.Count() > 0)
                            {
                                var Fileresult = PDFList.OrderByDescending(f => f.LastWriteTime).First();
                                var path = strPdfPath + "\\" + Fileresult;

                                if (path != null)
                                {
                                    int  Idvalue = Convert.ToInt32(dgvFileList.CurrentRow.Cells[0].Value);
                                   
                                    frmrejectimage.holdpath(path , Idvalue);
                                    frmrejectimage.LoadPdfFile();
                                    if (frmrejectimage.ShowDialog() != DialogResult.Cancel)
                                    {
                                        this.Close();
                                    }

                                    // use the LoadFile(ByVal fileName As String) function for open the pdf in control



                                }
                            }
                        }


                    }
                    LoadFileList();
                }
            }
        }

        private void lnkClearFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FromDateTimePicker.Text = "";
            cbFilterDifficultyLevel.SelectedIndex = 0;
            FromDateTimePicker.Text = "";
            txtFilterFileName.Text = "";
            LoadFileList();
        }

        public void LoadInvoiceList(DateTime? FromDate = null, DateTime? ToDate = null, int? DifficultyLevel = 0, int? invoiceId = 0, int? Status = 0, string UserAssigned = null)
        {


            var InvoiceList = new InvoiceBpl().GetInvoiceLisDT(FromDate, ToDate, DifficultyLevel, invoiceId, Status,UserAssigned);
            dgvInvoiceList.DataSource = InvoiceList;
            dgvInvoiceList.PageSize = 10;
            dgvInvoiceList.SetPagedDataSource(InvoiceList, bindingNavigator1);
         


        }

        private void BtnInvoiceFilter_Click(object sender, EventArgs e)
        {
            LoadInvoiceList(FromDateTimePicker1.Value, ToDateTimePicker1.Value, (int)cbDifficultyLevel.SelectedValue,Convert.ToInt32( txtInvoiceId.Text), (int)cbInvoiceStatus.SelectedValue,txtSupplierEmail.Text);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadFileList(FromDateTimePicker.Value.ToShortDateString(), ToDateTimePicker.Value.ToShortDateString(), (int)cbFilterDifficultyLevel.SelectedValue, txtFilterFileName.Text);
        }
        private void ClearFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FromDateTimePicker.Text = "";
            cbFilterDifficultyLevel.SelectedIndex = 0;
            FromDateTimePicker.Text = "";
            txtFilterFileName.Text = "";
            LoadFileList();
        }

        private void dgvInvoiceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 7)  //Edit record
                {
                    int Id = 0;
                    using (FrmEditInvoice EditInvoice = new FrmEditInvoice())
                    {
                        int difflevel = (int)dgvInvoiceList.CurrentRow.Cells[4].Value;
                        EditInvoice.TimePickerReceiptDate.Value = Convert.ToDateTime(dgvInvoiceList.CurrentRow.Cells[1].Value);
                        EditInvoice.txtSupplierEmail.Text = Convert.ToString(dgvInvoiceList.CurrentRow.Cells[3].Value);
                        EditInvoice.cbStatus.Text = Convert.ToString(dgvInvoiceList.CurrentRow.Cells[5].Value);
                        EditInvoice.cbDifficultyLevel.Text = Convert.ToString(difflevel);
                        EditInvoice.txtInvoiceId.Text = Convert.ToString(dgvInvoiceList.CurrentRow.Cells[2].Value);
                        EditInvoice.cbUsers.Text= Convert.ToString(dgvInvoiceList.CurrentRow.Cells[6].Value);
              
                        Id = Convert.ToInt32(dgvInvoiceList.CurrentRow.Cells[0].Value);

                        EditInvoice.AddFileId(Id);
                        if (EditInvoice.ShowDialog() != DialogResult.Cancel)
                        {
                            this.Close();
                        }
                        LoadInvoiceList();
                    }

                    if (e.ColumnIndex == 8)  //View record
                    {


                    }
                }
            }
            }
    }
}
