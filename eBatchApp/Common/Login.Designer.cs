using eBatch.Theme.Purple;

namespace eBatchApp.Common
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new eBatch.Theme.Purple.eTextBox();
            this.textBox2 = new eBatch.Theme.Purple.eTextBox();
            this.button1 = new eBatch.Theme.Purple.eNewButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.imgLoading = new System.Windows.Forms.PictureBox();
            this.lblMessage = new eBatch.Theme.Purple.eLabel();
            this.eLabel1 = new eBatch.Theme.Purple.eLabel();
            this.metroLabel1 = new eBatch.Theme.Purple.eLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlLoginTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new eBatch.Theme.Purple.eLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).BeginInit();
            this.pnlLoginTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            // 
            // 
            // 
            this.textBox1.CustomButton.Image = null;
            this.textBox1.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.textBox1.CustomButton.Name = "";
            this.textBox1.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.textBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox1.CustomButton.TabIndex = 1;
            this.textBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox1.CustomButton.UseSelectable = true;
            this.textBox1.CustomButton.Visible = false;
            this.textBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox1.Lines = new string[0];
            this.textBox1.Location = new System.Drawing.Point(191, 32);
            this.textBox1.MaxLength = 32767;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.ShortcutsEnabled = true;
            this.textBox1.ShowClearButton = true;
            this.textBox1.Size = new System.Drawing.Size(221, 35);
            this.textBox1.Style = MetroFramework.MetroColorStyle.Purple;
            this.textBox1.TabIndex = 0;
            this.textBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox1.UseCustomBackColor = true;
            this.textBox1.UseCustomForeColor = true;
            this.textBox1.UseSelectable = true;
            this.textBox1.UseStyleColors = true;
            this.textBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox2
            // 
            // 
            // 
            // 
            this.textBox2.CustomButton.Image = null;
            this.textBox2.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.textBox2.CustomButton.Name = "";
            this.textBox2.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.textBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox2.CustomButton.TabIndex = 1;
            this.textBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox2.CustomButton.UseSelectable = true;
            this.textBox2.CustomButton.Visible = false;
            this.textBox2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox2.Lines = new string[0];
            this.textBox2.Location = new System.Drawing.Point(191, 74);
            this.textBox2.MaxLength = 32767;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox2.SelectedText = "";
            this.textBox2.SelectionLength = 0;
            this.textBox2.SelectionStart = 0;
            this.textBox2.ShortcutsEnabled = true;
            this.textBox2.ShowClearButton = true;
            this.textBox2.Size = new System.Drawing.Size(221, 35);
            this.textBox2.Style = MetroFramework.MetroColorStyle.Purple;
            this.textBox2.TabIndex = 1;
            this.textBox2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox2.UseCustomBackColor = true;
            this.textBox2.UseCustomForeColor = true;
            this.textBox2.UseSelectable = true;
            this.textBox2.UseStyleColors = true;
            this.textBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.DisplayFocus = true;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Highlight = true;
            this.button1.Location = new System.Drawing.Point(312, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.Style = MetroFramework.MetroColorStyle.Purple;
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseCustomBackColor = true;
            this.button1.UseCustomForeColor = true;
            this.button1.UseSelectable = true;
            this.button1.UseStyleColors = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroPanel1.Controls.Add(this.imgLoading);
            this.metroPanel1.Controls.Add(this.lblMessage);
            this.metroPanel1.Controls.Add(this.eLabel1);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.textBox2);
            this.metroPanel1.Controls.Add(this.button1);
            this.metroPanel1.Controls.Add(this.textBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(113, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(492, 195);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = false;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // imgLoading
            // 
            this.imgLoading.Image = global::eBatchApp.Properties.Resources.loadingsqure;
            this.imgLoading.Location = new System.Drawing.Point(191, 115);
            this.imgLoading.Name = "imgLoading";
            this.imgLoading.Size = new System.Drawing.Size(56, 10);
            this.imgLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLoading.TabIndex = 6;
            this.imgLoading.TabStop = false;
            this.imgLoading.Visible = false;
            
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(191, 172);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 0);
            this.lblMessage.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblMessage.UseCustomBackColor = true;
            this.lblMessage.UseCustomForeColor = true;
            this.lblMessage.UseStyleColors = true;
            this.lblMessage.UseWaitCursor = true;
            // 
            // eLabel1
            // 
            this.eLabel1.AutoSize = true;
            this.eLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.eLabel1.ForeColor = System.Drawing.Color.Black;
            this.eLabel1.Location = new System.Drawing.Point(91, 84);
            this.eLabel1.Name = "eLabel1";
            this.eLabel1.Size = new System.Drawing.Size(67, 19);
            this.eLabel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.eLabel1.TabIndex = 4;
            this.eLabel1.Text = "Password";
            this.eLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.eLabel1.UseCustomBackColor = true;
            this.eLabel1.UseCustomForeColor = true;
            this.eLabel1.UseStyleColors = true;
            this.eLabel1.UseWaitCursor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(81, 43);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "User Name";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            this.metroLabel1.UseWaitCursor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnlLoginTitle
            // 
            this.pnlLoginTitle.Controls.Add(this.lblTitle);
            this.pnlLoginTitle.Location = new System.Drawing.Point(113, 11);
            this.pnlLoginTitle.Name = "pnlLoginTitle";
            this.pnlLoginTitle.Size = new System.Drawing.Size(492, 46);
            this.pnlLoginTitle.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTitle.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(191, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(125, 25);
            this.lblTitle.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "eBatch - Login";
            this.lblTitle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblTitle.UseCustomBackColor = true;
            this.lblTitle.UseCustomForeColor = true;
            this.lblTitle.UseStyleColors = true;
            this.lblTitle.UseWaitCursor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(708, 358);
            this.ControlBox = true;
            this.Controls.Add(this.pnlLoginTitle);
            this.Controls.Add(this.metroPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).EndInit();
            this.pnlLoginTitle.ResumeLayout(false);
            this.pnlLoginTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private eTextBox textBox1;
        private eTextBox textBox2;
        private eNewButton button1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private eLabel eLabel1;
        private eLabel metroLabel1;
        private eLabel lblMessage;
        private System.Windows.Forms.PictureBox imgLoading;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlLoginTitle;
        private eLabel lblTitle;
    }
}