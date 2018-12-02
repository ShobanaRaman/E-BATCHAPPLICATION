namespace eBatchApp.DataPrep
{
    partial class FrmAddFile
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
            this.eNewButton1 = new eBatch.Theme.Purple.eNewButton();
            this.txtFileName = new eBatch.Theme.Purple.eTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblSupplierEmail = new eBatch.Theme.Purple.eLabel();
            this.lblReceiptDate = new eBatch.Theme.Purple.eLabel();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.dtReceiptDate = new MetroFramework.Controls.MetroDateTime();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnSave = new eBatch.Theme.Purple.eNewButton();
            this.btnCancel = new eBatch.Theme.Purple.eNewButton();
            this.lblTitle = new eBatch.Theme.Purple.eLabel();
            this.txtFake = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // eNewButton1
            // 
            this.eNewButton1.AutoSize = true;
            this.eNewButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.eNewButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eNewButton1.DisplayFocus = true;
            this.eNewButton1.ForeColor = System.Drawing.Color.White;
            this.eNewButton1.Highlight = true;
            this.eNewButton1.Location = new System.Drawing.Point(19, 7);
            this.eNewButton1.Name = "eNewButton1";
            this.eNewButton1.Size = new System.Drawing.Size(98, 29);
            this.eNewButton1.Style = MetroFramework.MetroColorStyle.Purple;
            this.eNewButton1.TabIndex = 0;
            this.eNewButton1.Text = "Browse...";
            this.eNewButton1.UseCustomBackColor = true;
            this.eNewButton1.UseCustomForeColor = true;
            this.eNewButton1.UseSelectable = true;
            this.eNewButton1.UseStyleColors = true;
            this.eNewButton1.Click += new System.EventHandler(this.eNewButton1_Click);
            // 
            // txtFileName
            // 
            // 
            // 
            // 
            this.txtFileName.CustomButton.Image = null;
            this.txtFileName.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtFileName.CustomButton.Name = "";
            this.txtFileName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtFileName.CustomButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtFileName.CustomButton.TabIndex = 1;
            this.txtFileName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFileName.CustomButton.UseSelectable = true;
            this.txtFileName.CustomButton.Visible = false;
            this.txtFileName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFileName.Lines = new string[0];
            this.txtFileName.Location = new System.Drawing.Point(12, 7);
            this.txtFileName.MaxLength = 32767;
            this.txtFileName.Multiline = true;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.PasswordChar = '\0';
            this.txtFileName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFileName.SelectedText = "";
            this.txtFileName.SelectionLength = 0;
            this.txtFileName.SelectionStart = 0;
            this.txtFileName.ShortcutsEnabled = true;
            this.txtFileName.ShowClearButton = true;
            this.txtFileName.Size = new System.Drawing.Size(221, 29);
            this.txtFileName.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtFileName.TabIndex = 1;
            this.txtFileName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFileName.UseCustomBackColor = true;
            this.txtFileName.UseCustomForeColor = true;
            this.txtFileName.UseSelectable = true;
            this.txtFileName.UseStyleColors = true;
            this.txtFileName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFileName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.eNewButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 46);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtFileName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(138, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 46);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblSupplierEmail);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(129, 46);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblReceiptDate);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(129, 46);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtFake);
            this.panel5.Controls.Add(this.cbSupplier);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(138, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(309, 46);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtReceiptDate);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(138, 107);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(309, 46);
            this.panel6.TabIndex = 5;
            // 
            // lblSupplierEmail
            // 
            this.lblSupplierEmail.AutoSize = true;
            this.lblSupplierEmail.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSupplierEmail.ForeColor = System.Drawing.Color.Black;
            this.lblSupplierEmail.Location = new System.Drawing.Point(15, 8);
            this.lblSupplierEmail.Name = "lblSupplierEmail";
            this.lblSupplierEmail.Size = new System.Drawing.Size(98, 19);
            this.lblSupplierEmail.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblSupplierEmail.TabIndex = 0;
            this.lblSupplierEmail.Text = " Supplier Email";
            this.lblSupplierEmail.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSupplierEmail.UseCustomBackColor = true;
            this.lblSupplierEmail.UseCustomForeColor = true;
            this.lblSupplierEmail.UseStyleColors = true;
            this.lblSupplierEmail.UseWaitCursor = true;
            // 
            // lblReceiptDate
            // 
            this.lblReceiptDate.AutoSize = true;
            this.lblReceiptDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblReceiptDate.ForeColor = System.Drawing.Color.Black;
            this.lblReceiptDate.Location = new System.Drawing.Point(27, 8);
            this.lblReceiptDate.Name = "lblReceiptDate";
            this.lblReceiptDate.Size = new System.Drawing.Size(86, 19);
            this.lblReceiptDate.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblReceiptDate.TabIndex = 1;
            this.lblReceiptDate.Text = "Receipt Date";
            this.lblReceiptDate.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblReceiptDate.UseCustomBackColor = true;
            this.lblReceiptDate.UseCustomForeColor = true;
            this.lblReceiptDate.UseStyleColors = true;
            this.lblReceiptDate.UseWaitCursor = true;
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(12, 11);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(221, 21);
            this.cbSupplier.TabIndex = 0;
            // 
            // dtReceiptDate
            // 
            this.dtReceiptDate.Location = new System.Drawing.Point(12, 8);
            this.dtReceiptDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtReceiptDate.Name = "dtReceiptDate";
            this.dtReceiptDate.Size = new System.Drawing.Size(221, 29);
            this.dtReceiptDate.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.panel6, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(119, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(450, 210);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnSave);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 159);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(129, 48);
            this.panel7.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnCancel);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(138, 159);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(309, 48);
            this.panel8.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisplayFocus = true;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Highlight = true;
            this.btnSave.Location = new System.Drawing.Point(23, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisplayFocus = true;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Highlight = true;
            this.btnCancel.Location = new System.Drawing.Point(12, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseCustomForeColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseStyleColors = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(276, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(67, 19);
            this.lblTitle.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "ADD FILE";
            this.lblTitle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblTitle.UseCustomBackColor = true;
            this.lblTitle.UseCustomForeColor = true;
            this.lblTitle.UseStyleColors = true;
            this.lblTitle.UseWaitCursor = true;
            // 
            // txtFake
            // 
            this.txtFake.AllowDrop = true;
            this.txtFake.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFake.Location = new System.Drawing.Point(207, 15);
            this.txtFake.Name = "txtFake";
            this.txtFake.Size = new System.Drawing.Size(22, 13);
            this.txtFake.TabIndex = 26;
            // 
            // FrmAddFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 358);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmAddFile";
            this.Load += new System.EventHandler(this.FrmAddFile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private eBatch.Theme.Purple.eNewButton eNewButton1;
        private eBatch.Theme.Purple.eTextBox txtFileName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private eBatch.Theme.Purple.eLabel lblSupplierEmail;
        private System.Windows.Forms.Panel panel4;
        private eBatch.Theme.Purple.eLabel lblReceiptDate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbSupplier;
        private MetroFramework.Controls.MetroDateTime dtReceiptDate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel7;
        private eBatch.Theme.Purple.eNewButton btnSave;
        private System.Windows.Forms.Panel panel8;
        private eBatch.Theme.Purple.eNewButton btnCancel;
        private eBatch.Theme.Purple.eLabel lblTitle;
        private System.Windows.Forms.TextBox txtFake;
    }
}