namespace eBatch.Theme.Purple
{
    partial class PdfThumbnail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlPDFImageContainer = new MetroFramework.Controls.MetroPanel();
            this.picPDFImage1 = new System.Windows.Forms.PictureBox();
            this.pnlPDFImagebottom = new MetroFramework.Controls.MetroPanel();
            this.chkPdfImage = new MetroFramework.Controls.MetroCheckBox();
            this.pnlPDFImageContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPDFImage1)).BeginInit();
            this.pnlPDFImagebottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPDFImageContainer
            // 
            this.pnlPDFImageContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPDFImageContainer.Controls.Add(this.picPDFImage1);
            this.pnlPDFImageContainer.Controls.Add(this.pnlPDFImagebottom);
            this.pnlPDFImageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPDFImageContainer.HorizontalScrollbarBarColor = true;
            this.pnlPDFImageContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlPDFImageContainer.HorizontalScrollbarSize = 10;
            this.pnlPDFImageContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlPDFImageContainer.Margin = new System.Windows.Forms.Padding(5);
            this.pnlPDFImageContainer.Name = "pnlPDFImageContainer";
            this.pnlPDFImageContainer.Padding = new System.Windows.Forms.Padding(2);
            this.pnlPDFImageContainer.Size = new System.Drawing.Size(177, 240);
            this.pnlPDFImageContainer.TabIndex = 2;
            this.pnlPDFImageContainer.VerticalScrollbarBarColor = true;
            this.pnlPDFImageContainer.VerticalScrollbarHighlightOnWheel = false;
            this.pnlPDFImageContainer.VerticalScrollbarSize = 10;
            // 
            // picPDFImage1
            // 
            this.picPDFImage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPDFImage1.Location = new System.Drawing.Point(2, 2);
            this.picPDFImage1.Name = "picPDFImage1";
            this.picPDFImage1.Size = new System.Drawing.Size(171, 200);
            this.picPDFImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPDFImage1.TabIndex = 3;
            this.picPDFImage1.TabStop = false;
            // 
            // pnlPDFImagebottom
            // 
            this.pnlPDFImagebottom.Controls.Add(this.chkPdfImage);
            this.pnlPDFImagebottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPDFImagebottom.HorizontalScrollbarBarColor = true;
            this.pnlPDFImagebottom.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlPDFImagebottom.HorizontalScrollbarSize = 10;
            this.pnlPDFImagebottom.Location = new System.Drawing.Point(2, 202);
            this.pnlPDFImagebottom.Name = "pnlPDFImagebottom";
            this.pnlPDFImagebottom.Size = new System.Drawing.Size(171, 34);
            this.pnlPDFImagebottom.TabIndex = 2;
            this.pnlPDFImagebottom.VerticalScrollbarBarColor = true;
            this.pnlPDFImagebottom.VerticalScrollbarHighlightOnWheel = false;
            this.pnlPDFImagebottom.VerticalScrollbarSize = 10;
            // 
            // chkPdfImage
            // 
            this.chkPdfImage.AutoSize = true;
            this.chkPdfImage.Location = new System.Drawing.Point(40, 11);
            this.chkPdfImage.Name = "chkPdfImage";
            this.chkPdfImage.Size = new System.Drawing.Size(83, 15);
            this.chkPdfImage.TabIndex = 2;
            this.chkPdfImage.Text = "Select Page";
            this.chkPdfImage.UseSelectable = true;
            this.chkPdfImage.CheckedChanged += new System.EventHandler(this.chkPdfImage_CheckedChanged);
            // 
            // PdfThumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPDFImageContainer);
            this.Name = "PdfThumbnail";
            this.Size = new System.Drawing.Size(177, 240);
            this.Load += new System.EventHandler(this.PdfThumbnail_Load);
            this.pnlPDFImageContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPDFImage1)).EndInit();
            this.pnlPDFImagebottom.ResumeLayout(false);
            this.pnlPDFImagebottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlPDFImageContainer;
        private System.Windows.Forms.PictureBox picPDFImage1;
        private MetroFramework.Controls.MetroPanel pnlPDFImagebottom;
        private MetroFramework.Controls.MetroCheckBox chkPdfImage;
    }
}
