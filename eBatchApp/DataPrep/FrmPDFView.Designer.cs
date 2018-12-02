namespace eBatchApp.DataPrep
{
    partial class FrmPDFView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblInvoiceText = new eBatch.Theme.Purple.eLabel();
            this.txtSelectedPages = new eBatch.Theme.Purple.eTextBox();
            this.btnCreateInvoice = new eBatch.Theme.Purple.eNewButton();
            this.chkPDFImage1 = new MetroFramework.Controls.MetroCheckBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lnkBack = new MetroFramework.Controls.MetroLink();
            this.lblTitle = new eBatch.Theme.Purple.eLabel();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.pnlLeft.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(323, 60);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(588, 452);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblInvoiceText
            // 
            this.lblInvoiceText.AutoSize = true;
            this.lblInvoiceText.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblInvoiceText.ForeColor = System.Drawing.Color.Black;
            this.lblInvoiceText.Location = new System.Drawing.Point(8, 37);
            this.lblInvoiceText.Name = "lblInvoiceText";
            this.lblInvoiceText.Size = new System.Drawing.Size(99, 19);
            this.lblInvoiceText.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblInvoiceText.TabIndex = 2;
            this.lblInvoiceText.Text = "Selected Pages";
            this.lblInvoiceText.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblInvoiceText.UseCustomBackColor = true;
            this.lblInvoiceText.UseCustomForeColor = true;
            this.lblInvoiceText.UseStyleColors = true;
            this.lblInvoiceText.UseWaitCursor = true;
            // 
            // txtSelectedPages
            // 
            // 
            // 
            // 
            this.txtSelectedPages.CustomButton.Image = null;
            this.txtSelectedPages.CustomButton.Location = new System.Drawing.Point(121, 2);
            this.txtSelectedPages.CustomButton.Name = "";
            this.txtSelectedPages.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtSelectedPages.CustomButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtSelectedPages.CustomButton.TabIndex = 1;
            this.txtSelectedPages.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSelectedPages.CustomButton.UseSelectable = true;
            this.txtSelectedPages.CustomButton.Visible = false;
            this.txtSelectedPages.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSelectedPages.Lines = new string[0];
            this.txtSelectedPages.Location = new System.Drawing.Point(113, 26);
            this.txtSelectedPages.MaxLength = 32767;
            this.txtSelectedPages.Multiline = true;
            this.txtSelectedPages.Name = "txtSelectedPages";
            this.txtSelectedPages.PasswordChar = '\0';
            this.txtSelectedPages.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSelectedPages.SelectedText = "";
            this.txtSelectedPages.SelectionLength = 0;
            this.txtSelectedPages.SelectionStart = 0;
            this.txtSelectedPages.ShortcutsEnabled = true;
            this.txtSelectedPages.ShowClearButton = true;
            this.txtSelectedPages.Size = new System.Drawing.Size(159, 40);
            this.txtSelectedPages.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtSelectedPages.TabIndex = 3;
            this.txtSelectedPages.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSelectedPages.UseCustomBackColor = true;
            this.txtSelectedPages.UseCustomForeColor = true;
            this.txtSelectedPages.UseSelectable = true;
            this.txtSelectedPages.UseStyleColors = true;
            this.txtSelectedPages.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSelectedPages.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.AutoSize = true;
            this.btnCreateInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnCreateInvoice.DisplayFocus = true;
            this.btnCreateInvoice.ForeColor = System.Drawing.Color.White;
            this.btnCreateInvoice.Highlight = true;
            this.btnCreateInvoice.Location = new System.Drawing.Point(171, 82);
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(100, 35);
            this.btnCreateInvoice.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnCreateInvoice.TabIndex = 4;
            this.btnCreateInvoice.Text = "Create Invoice";
            this.btnCreateInvoice.UseCustomBackColor = true;
            this.btnCreateInvoice.UseCustomForeColor = true;
            this.btnCreateInvoice.UseSelectable = true;
            this.btnCreateInvoice.UseStyleColors = true;
            // 
            // chkPDFImage1
            // 
            this.chkPDFImage1.AutoSize = true;
            this.chkPDFImage1.Location = new System.Drawing.Point(40, 11);
            this.chkPDFImage1.Name = "chkPDFImage1";
            this.chkPDFImage1.Size = new System.Drawing.Size(83, 15);
            this.chkPDFImage1.TabIndex = 2;
            this.chkPDFImage1.Text = "Select Page";
            this.chkPDFImage1.UseSelectable = true;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnCreateInvoice);
            this.pnlLeft.Controls.Add(this.lblInvoiceText);
            this.pnlLeft.Controls.Add(this.txtSelectedPages);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 60);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(299, 452);
            this.pnlLeft.TabIndex = 5;
            // 
            // lnkBack
            // 
            this.lnkBack.Location = new System.Drawing.Point(0, 31);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.Size = new System.Drawing.Size(51, 23);
            this.lnkBack.TabIndex = 6;
            this.lnkBack.Text = "Back";
            this.lnkBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkBack.UseSelectable = true;
            this.lnkBack.Click += new System.EventHandler(this.lnkBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(394, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(96, 19);
            this.lblTitle.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Create Invoice";
            this.lblTitle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblTitle.UseCustomBackColor = true;
            this.lblTitle.UseCustomForeColor = true;
            this.lblTitle.UseStyleColors = true;
            this.lblTitle.UseWaitCursor = true;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(40, 11);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(83, 15);
            this.metroCheckBox1.TabIndex = 2;
            this.metroCheckBox1.Text = "Select Page";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.chkPDFImage1);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(2, 195);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(163, 34);
            this.metroPanel5.TabIndex = 2;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // FrmPDFView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 512);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lnkBack);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmPDFView";
            this.Load += new System.EventHandler(this.FrmPDFView_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private eBatch.Theme.Purple.eLabel lblInvoiceText;
        private eBatch.Theme.Purple.eTextBox txtSelectedPages;
        private eBatch.Theme.Purple.eNewButton btnCreateInvoice;
        private MetroFramework.Controls.MetroCheckBox chkPDFImage1;
        private System.Windows.Forms.Panel pnlLeft;
        private MetroFramework.Controls.MetroLink lnkBack;
        private eBatch.Theme.Purple.eLabel lblTitle;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroPanel metroPanel5;
    }
}