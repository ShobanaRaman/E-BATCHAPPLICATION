using eBatch.Theme.Purple;

namespace eBatchApp.Admin
{
    partial class FrmAddUser
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
            this.txtUserName = new eBatch.Theme.Purple.eTextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.cbDifficultyLevel = new System.Windows.Forms.ComboBox();
            this.btnCancel = new eBatch.Theme.Purple.eNewButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnADsearch = new eBatch.Theme.Purple.eNewButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSelect = new eBatch.Theme.Purple.eNewButton();
            this.lblSave = new eBatch.Theme.Purple.eLabel();
            this.lblValid = new eBatch.Theme.Purple.eLabel();
            this.lblUserName = new eBatch.Theme.Purple.eLabel();
            this.eLabel1 = new eBatch.Theme.Purple.eLabel();
            this.eLabel2 = new eBatch.Theme.Purple.eLabel();
            this.cbUserName = new System.Windows.Forms.ComboBox();
            this.txtFake = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblUserNameValidation = new eBatch.Theme.Purple.eLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.eLabel3 = new eBatch.Theme.Purple.eLabel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.AllowDrop = true;
            this.txtUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(81, 1);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(3, 8);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.ShowClearButton = true;
            this.txtUserName.Size = new System.Drawing.Size(105, 25);
            this.txtUserName.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.UseCustomBackColor = true;
            this.txtUserName.UseCustomForeColor = true;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.UseStyleColors = true;
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(3, 19);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(121, 21);
            this.cbRole.TabIndex = 3;
            this.cbRole.SelectedIndexChanged += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // cbDifficultyLevel
            // 
            this.cbDifficultyLevel.FormattingEnabled = true;
            this.cbDifficultyLevel.Location = new System.Drawing.Point(3, 18);
            this.cbDifficultyLevel.Name = "cbDifficultyLevel";
            this.cbDifficultyLevel.Size = new System.Drawing.Size(121, 21);
            this.cbDifficultyLevel.TabIndex = 4;
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
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisplayFocus = true;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Highlight = true;
            this.btnSave.Location = new System.Drawing.Point(118, 6);
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
            // btnADsearch
            // 
            this.btnADsearch.AutoSize = true;
            this.btnADsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnADsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnADsearch.DisplayFocus = true;
            this.btnADsearch.ForeColor = System.Drawing.Color.White;
            this.btnADsearch.Highlight = true;
            this.btnADsearch.Location = new System.Drawing.Point(114, 10);
            this.btnADsearch.Name = "btnADsearch";
            this.btnADsearch.Size = new System.Drawing.Size(51, 23);
            this.btnADsearch.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnADsearch.TabIndex = 15;
            this.btnADsearch.Text = "&Search";
            this.btnADsearch.UseCustomBackColor = true;
            this.btnADsearch.UseCustomForeColor = true;
            this.btnADsearch.UseSelectable = true;
            this.btnADsearch.UseStyleColors = true;
            this.btnADsearch.Click += new System.EventHandler(this.btnADsearch_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(162, 173);
            this.listBox1.TabIndex = 16;
            // 
            // btnSelect
            // 
            this.btnSelect.AutoSize = true;
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.DisplayFocus = true;
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Highlight = true;
            this.btnSelect.Location = new System.Drawing.Point(3, 218);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(82, 25);
            this.btnSelect.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnSelect.TabIndex = 17;
            this.btnSelect.Text = "&Select";
            this.btnSelect.UseCustomBackColor = true;
            this.btnSelect.UseCustomForeColor = true;
            this.btnSelect.UseSelectable = true;
            this.btnSelect.UseStyleColors = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSave.ForeColor = System.Drawing.Color.Black;
            this.lblSave.Location = new System.Drawing.Point(170, 334);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(0, 0);
            this.lblSave.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblSave.TabIndex = 19;
            this.lblSave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSave.UseCustomBackColor = true;
            this.lblSave.UseCustomForeColor = true;
            this.lblSave.UseStyleColors = true;
            this.lblSave.UseWaitCursor = true;
            // 
            // lblValid
            // 
            this.lblValid.AutoSize = true;
            this.lblValid.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblValid.ForeColor = System.Drawing.Color.Red;
            this.lblValid.Location = new System.Drawing.Point(183, 100);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(0, 0);
            this.lblValid.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblValid.TabIndex = 20;
            this.lblValid.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblValid.UseCustomBackColor = true;
            this.lblValid.UseCustomForeColor = true;
            this.lblValid.UseStyleColors = true;
            this.lblValid.UseWaitCursor = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(105, 21);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(77, 19);
            this.lblUserName.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblUserName.TabIndex = 21;
            this.lblUserName.Text = "User Name";
            this.lblUserName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblUserName.UseCustomBackColor = true;
            this.lblUserName.UseCustomForeColor = true;
            this.lblUserName.UseStyleColors = true;
            this.lblUserName.UseWaitCursor = true;
            // 
            // eLabel1
            // 
            this.eLabel1.AutoSize = true;
            this.eLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.eLabel1.ForeColor = System.Drawing.Color.Black;
            this.eLabel1.Location = new System.Drawing.Point(115, 19);
            this.eLabel1.Name = "eLabel1";
            this.eLabel1.Size = new System.Drawing.Size(67, 19);
            this.eLabel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.eLabel1.TabIndex = 22;
            this.eLabel1.Text = "User Role";
            this.eLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.eLabel1.UseCustomBackColor = true;
            this.eLabel1.UseCustomForeColor = true;
            this.eLabel1.UseStyleColors = true;
            this.eLabel1.UseWaitCursor = true;
            this.eLabel1.Click += new System.EventHandler(this.eLabel1_Click);
            // 
            // eLabel2
            // 
            this.eLabel2.AutoSize = true;
            this.eLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.eLabel2.ForeColor = System.Drawing.Color.Black;
            this.eLabel2.Location = new System.Drawing.Point(85, 18);
            this.eLabel2.Name = "eLabel2";
            this.eLabel2.Size = new System.Drawing.Size(97, 19);
            this.eLabel2.Style = MetroFramework.MetroColorStyle.Purple;
            this.eLabel2.TabIndex = 23;
            this.eLabel2.Text = "Difficulty Level";
            this.eLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.eLabel2.UseCustomBackColor = true;
            this.eLabel2.UseCustomForeColor = true;
            this.eLabel2.UseStyleColors = true;
            this.eLabel2.UseWaitCursor = true;
            // 
            // cbUserName
            // 
            this.cbUserName.FormattingEnabled = true;
            this.cbUserName.ItemHeight = 13;
            this.cbUserName.Location = new System.Drawing.Point(3, 21);
            this.cbUserName.MaxDropDownItems = 5;
            this.cbUserName.Name = "cbUserName";
            this.cbUserName.Size = new System.Drawing.Size(121, 21);
            this.cbUserName.Sorted = true;
            this.cbUserName.TabIndex = 24;
            this.cbUserName.SelectedIndexChanged += new System.EventHandler(this.cbUserName_SelectedIndexChanged);
            this.cbUserName.TextChanged += new System.EventHandler(this.cbUserName_TextChanged);
            this.cbUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbUserName_KeyPress);
            this.cbUserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbUserName_KeyUp);
            // 
            // txtFake
            // 
            this.txtFake.AllowDrop = true;
            this.txtFake.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFake.Location = new System.Drawing.Point(100, 25);
            this.txtFake.Name = "txtFake";
            this.txtFake.Size = new System.Drawing.Size(22, 13);
            this.txtFake.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.btnADsearch);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Location = new System.Drawing.Point(597, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 261);
            this.panel1.TabIndex = 26;
            this.panel1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(83, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 224);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 50);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblUserNameValidation);
            this.panel3.Controls.Add(this.txtFake);
            this.panel3.Controls.Add(this.cbUserName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(227, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 50);
            this.panel3.TabIndex = 1;
            // 
            // lblUserNameValidation
            // 
            this.lblUserNameValidation.AutoSize = true;
            this.lblUserNameValidation.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblUserNameValidation.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblUserNameValidation.ForeColor = System.Drawing.Color.Red;
            this.lblUserNameValidation.Location = new System.Drawing.Point(3, 2);
            this.lblUserNameValidation.Name = "lblUserNameValidation";
            this.lblUserNameValidation.Size = new System.Drawing.Size(190, 15);
            this.lblUserNameValidation.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblUserNameValidation.TabIndex = 26;
            this.lblUserNameValidation.Text = "Invalid Entry: User already enabled.";
            this.lblUserNameValidation.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblUserNameValidation.UseCustomBackColor = true;
            this.lblUserNameValidation.UseCustomForeColor = true;
            this.lblUserNameValidation.UseStyleColors = true;
            this.lblUserNameValidation.UseWaitCursor = true;
            this.lblUserNameValidation.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.eLabel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 50);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbRole);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(227, 59);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(218, 50);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.eLabel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 115);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(218, 52);
            this.panel6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbDifficultyLevel);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(227, 115);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(218, 52);
            this.panel7.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnSave);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 173);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(218, 48);
            this.panel8.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnCancel);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(227, 173);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(218, 48);
            this.panel9.TabIndex = 7;
            // 
            // eLabel3
            // 
            this.eLabel3.AutoSize = true;
            this.eLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.eLabel3.ForeColor = System.Drawing.Color.Black;
            this.eLabel3.Location = new System.Drawing.Point(268, 14);
            this.eLabel3.Name = "eLabel3";
            this.eLabel3.Size = new System.Drawing.Size(93, 19);
            this.eLabel3.Style = MetroFramework.MetroColorStyle.Purple;
            this.eLabel3.TabIndex = 28;
            this.eLabel3.Text = "ENABLE USER";
            this.eLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.eLabel3.UseCustomBackColor = true;
            this.eLabel3.UseCustomForeColor = true;
            this.eLabel3.UseStyleColors = true;
            this.eLabel3.UseWaitCursor = true;
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 338);
            this.Controls.Add(this.eLabel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblValid);
            this.Controls.Add(this.lblSave);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmAddUser";
            this.Text = "";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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

        //private eTextBox txtUserName;
        //private System.Windows.Forms.ComboBox cbRole;
        //private System.Windows.Forms.ComboBox cbDifficultyLevel;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.Label label4;
        //private System.Windows.Forms.CheckBox checkBox1;
        //private System.Windows.Forms.Label label5;
        //private System.Windows.Forms.Button button1;
        //private eNewButton btnCancel;
        //private MetroFramework.Controls.MetroButton btnSave;
        //private MetroFramework.Controls.MetroTextBox metroTextBox1;

        public eTextBox txtUserName;
        public System.Windows.Forms.ComboBox cbRole;
        public System.Windows.Forms.ComboBox cbDifficultyLevel;
        public eNewButton btnCancel;
        public MetroFramework.Controls.MetroButton btnSave;
        private eNewButton btnADsearch;
        private System.Windows.Forms.ListBox listBox1;
        private eNewButton btnSelect;
        private eLabel lblSave;
        private eLabel lblValid;
        private eLabel lblUserName;
        private eLabel eLabel1;
        private eLabel eLabel2;
        // private System.Windows.Forms.ComboBox cbUserName;
        public new System.Windows.Forms.ComboBox cbUserName;
        private System.Windows.Forms.TextBox txtFake;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private eLabel eLabel3;
        private eLabel lblUserNameValidation;
    }
}