namespace eBatchApp.DataPrep
{
    partial class FrmRejectReason
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
            this.eLabel1 = new eBatch.Theme.Purple.eLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.eLabel2 = new eBatch.Theme.Purple.eLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbRejectionReason = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.eLabel3 = new eBatch.Theme.Purple.eLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtComment = new eBatch.Theme.Purple.eTextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnCancel = new eBatch.Theme.Purple.eNewButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // eLabel1
            // 
            this.eLabel1.AutoSize = true;
            this.eLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.eLabel1.ForeColor = System.Drawing.Color.Black;
            this.eLabel1.Location = new System.Drawing.Point(212, 30);
            this.eLabel1.Name = "eLabel1";
            this.eLabel1.Size = new System.Drawing.Size(269, 19);
            this.eLabel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.eLabel1.TabIndex = 0;
            this.eLabel1.Text = "Are you sure you want to reject this image";
            this.eLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.eLabel1.UseCustomBackColor = true;
            this.eLabel1.UseCustomForeColor = true;
            this.eLabel1.UseStyleColors = true;
            this.eLabel1.UseWaitCursor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.16514F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.83486F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(129, 77);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(545, 224);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.eLabel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 50);
            this.panel4.TabIndex = 2;
            // 
            // eLabel2
            // 
            this.eLabel2.AutoSize = true;
            this.eLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.eLabel2.ForeColor = System.Drawing.Color.Black;
            this.eLabel2.Location = new System.Drawing.Point(85, 19);
            this.eLabel2.Name = "eLabel2";
            this.eLabel2.Size = new System.Drawing.Size(108, 19);
            this.eLabel2.Style = MetroFramework.MetroColorStyle.Purple;
            this.eLabel2.TabIndex = 22;
            this.eLabel2.Text = "RejectionReason";
            this.eLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.eLabel2.UseCustomBackColor = true;
            this.eLabel2.UseCustomForeColor = true;
            this.eLabel2.UseStyleColors = true;
            this.eLabel2.UseWaitCursor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbRejectionReason);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(211, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(331, 50);
            this.panel5.TabIndex = 3;
            // 
            // cbRejectionReason
            // 
            this.cbRejectionReason.FormattingEnabled = true;
            this.cbRejectionReason.Location = new System.Drawing.Point(12, 19);
            this.cbRejectionReason.Name = "cbRejectionReason";
            this.cbRejectionReason.Size = new System.Drawing.Size(227, 21);
            this.cbRejectionReason.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.eLabel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 59);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(202, 85);
            this.panel6.TabIndex = 4;
            // 
            // eLabel3
            // 
            this.eLabel3.AutoSize = true;
            this.eLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.eLabel3.ForeColor = System.Drawing.Color.Black;
            this.eLabel3.Location = new System.Drawing.Point(85, 18);
            this.eLabel3.Name = "eLabel3";
            this.eLabel3.Size = new System.Drawing.Size(76, 19);
            this.eLabel3.Style = MetroFramework.MetroColorStyle.Purple;
            this.eLabel3.TabIndex = 23;
            this.eLabel3.Text = "Comments";
            this.eLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.eLabel3.UseCustomBackColor = true;
            this.eLabel3.UseCustomForeColor = true;
            this.eLabel3.UseStyleColors = true;
            this.eLabel3.UseWaitCursor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtComment);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(211, 59);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(331, 85);
            this.panel7.TabIndex = 5;
            // 
            // txtComment
            // 
            // 
            // 
            // 
            this.txtComment.CustomButton.Image = null;
            this.txtComment.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.txtComment.CustomButton.Name = "";
            this.txtComment.CustomButton.Size = new System.Drawing.Size(49, 49);
            this.txtComment.CustomButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtComment.CustomButton.TabIndex = 1;
            this.txtComment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtComment.CustomButton.UseSelectable = true;
            this.txtComment.CustomButton.Visible = false;
            this.txtComment.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtComment.Lines = new string[0];
            this.txtComment.Location = new System.Drawing.Point(12, 18);
            this.txtComment.MaxLength = 32767;
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.PasswordChar = '\0';
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComment.SelectedText = "";
            this.txtComment.SelectionLength = 0;
            this.txtComment.SelectionStart = 0;
            this.txtComment.ShortcutsEnabled = true;
            this.txtComment.ShowClearButton = true;
            this.txtComment.Size = new System.Drawing.Size(270, 51);
            this.txtComment.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtComment.TabIndex = 0;
            this.txtComment.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtComment.UseCustomBackColor = true;
            this.txtComment.UseCustomForeColor = true;
            this.txtComment.UseSelectable = true;
            this.txtComment.UseStyleColors = true;
            this.txtComment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtComment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnSave);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 150);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(202, 71);
            this.panel8.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisplayFocus = true;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Highlight = true;
            this.btnSave.Location = new System.Drawing.Point(85, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnCancel);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(211, 150);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(331, 71);
            this.panel9.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisplayFocus = true;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Highlight = true;
            this.btnCancel.Location = new System.Drawing.Point(22, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseCustomForeColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseStyleColors = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmRejectReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 380);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.eLabel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmRejectReason";
            this.Text = "";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private eBatch.Theme.Purple.eLabel eLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private eBatch.Theme.Purple.eLabel eLabel2;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.ComboBox cbRejectionReason;
        private System.Windows.Forms.Panel panel6;
        private eBatch.Theme.Purple.eLabel eLabel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        public MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.Panel panel9;
        public eBatch.Theme.Purple.eNewButton btnCancel;
        private eBatch.Theme.Purple.eTextBox txtComment;
    }
}