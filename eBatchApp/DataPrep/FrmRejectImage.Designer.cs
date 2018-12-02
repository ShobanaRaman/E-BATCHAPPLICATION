namespace eBatchApp.DataPrep
{
    partial class FrmRejectImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRejectImage));
            this.btnBack = new eBatch.Theme.Purple.eNewButton();
            this.btnRejectImage = new eBatch.Theme.Purple.eNewButton();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisplayFocus = true;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Highlight = true;
            this.btnBack.Location = new System.Drawing.Point(20, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.UseStyleColors = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRejectImage
            // 
            this.btnRejectImage.AutoSize = true;
            this.btnRejectImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnRejectImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRejectImage.DisplayFocus = true;
            this.btnRejectImage.ForeColor = System.Drawing.Color.White;
            this.btnRejectImage.Highlight = true;
            this.btnRejectImage.Location = new System.Drawing.Point(673, 19);
            this.btnRejectImage.Name = "btnRejectImage";
            this.btnRejectImage.Size = new System.Drawing.Size(100, 35);
            this.btnRejectImage.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnRejectImage.TabIndex = 1;
            this.btnRejectImage.Text = "Reject Image";
            this.btnRejectImage.UseCustomBackColor = true;
            this.btnRejectImage.UseCustomForeColor = true;
            this.btnRejectImage.UseSelectable = true;
            this.btnRejectImage.UseStyleColors = true;
            this.btnRejectImage.Click += new System.EventHandler(this.btnRejectImage_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(20, 75);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(842, 548);
            this.axAcroPDF1.TabIndex = 2;
            // 
            // FrmRejectImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 642);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.btnRejectImage);
            this.Controls.Add(this.btnBack);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmRejectImage";
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private eBatch.Theme.Purple.eNewButton btnBack;
        private eBatch.Theme.Purple.eNewButton btnRejectImage;
        public AxAcroPDFLib.AxAcroPDF axAcroPDF1;
    }
}