namespace eBatchApp.Common
{
    partial class FrmHomeDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTime = new eBatch.Theme.Purple.eLabel();
            this.lblDate = new eBatch.Theme.Purple.eLabel();
            this.lblWelcome = new eBatch.Theme.Purple.eLabel();
            this.lblUserName = new eBatch.Theme.Purple.eLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 298);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.lblWelcome);
            this.panel2.Location = new System.Drawing.Point(134, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 186);
            this.panel2.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(124, 82);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 19);
            this.lblTime.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "time";
            this.lblTime.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblTime.UseCustomBackColor = true;
            this.lblTime.UseCustomForeColor = true;
            this.lblTime.UseStyleColors = true;
            this.lblTime.UseWaitCursor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(124, 59);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 19);
            this.lblDate.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "date";
            this.lblDate.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDate.UseCustomBackColor = true;
            this.lblDate.UseCustomForeColor = true;
            this.lblDate.UseStyleColors = true;
            this.lblDate.UseWaitCursor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblWelcome.Location = new System.Drawing.Point(124, 30);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(147, 19);
            this.lblWelcome.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to eBatch, ";
            this.lblWelcome.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblWelcome.UseCustomBackColor = true;
            this.lblWelcome.UseCustomForeColor = true;
            this.lblWelcome.UseStyleColors = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblUserName.Location = new System.Drawing.Point(262, 30);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(21, 19);
            this.lblUserName.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "hi";
            this.lblUserName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblUserName.UseCustomBackColor = true;
            this.lblUserName.UseCustomForeColor = true;
            this.lblUserName.UseStyleColors = true;
            this.lblUserName.UseWaitCursor = true;
            // 
            // FrmHomeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(708, 358);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmHomeDashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private eBatch.Theme.Purple.eLabel lblWelcome;
        private eBatch.Theme.Purple.eLabel lblDate;
        private eBatch.Theme.Purple.eLabel lblTime;
        private eBatch.Theme.Purple.eLabel lblUserName;
    }
}