using eBatch.Theme.Purple;

namespace eBatchApp.Admin
{
    partial class FrmDataEntryHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDataEntryHome));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbAdminModule = new MetroFramework.Controls.MetroTabControl();
            this.tbInvoice = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAudit = new eBatch.Theme.Purple.eNewButton();
            this.dgvInvoice = new eBatch.Theme.Purple.eGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtSuppEmail = new eBatch.Theme.Purple.eTextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtcalanderto = new eBatch.Theme.Purple.eTextBox();
            this.txtCalFrm = new eBatch.Theme.Purple.eTextBox();
            this.lblFrom = new eBatch.Theme.Purple.eLabel();
            this.lblTo = new eBatch.Theme.Purple.eLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblStatus = new eBatch.Theme.Purple.eLabel();
            this.cbInvoiceStatus = new MetroFramework.Controls.MetroComboBox();
            this.cbFilterDifficulty = new MetroFramework.Controls.MetroComboBox();
            this.lblFilterDifficulty = new eBatch.Theme.Purple.eLabel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtInvName = new eBatch.Theme.Purple.eTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lnkClearFilter = new System.Windows.Forms.LinkLabel();
            this.btnFilter = new eBatch.Theme.Purple.eNewButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNewBatch = new eBatch.Theme.Purple.eNewButton();
            this.tbBatch = new System.Windows.Forms.TabPage();
            this.dgvSuppliers = new eBatch.Theme.Purple.eGrid();
            this.BatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifficultyLevelinBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserAssigned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUserActionColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbAdminModule.SuspendLayout();
            this.tbInvoice.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tbBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAdminModule
            // 
            this.tbAdminModule.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbAdminModule.Controls.Add(this.tbInvoice);
            this.tbAdminModule.Controls.Add(this.tbBatch);
            this.tbAdminModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdminModule.Location = new System.Drawing.Point(0, 60);
            this.tbAdminModule.Margin = new System.Windows.Forms.Padding(0);
            this.tbAdminModule.Name = "tbAdminModule";
            this.tbAdminModule.SelectedIndex = 0;
            this.tbAdminModule.Size = new System.Drawing.Size(1283, 298);
            this.tbAdminModule.Style = MetroFramework.MetroColorStyle.Purple;
            this.tbAdminModule.TabIndex = 0;
            this.tbAdminModule.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAdminModule.UseCustomBackColor = true;
            this.tbAdminModule.UseCustomForeColor = true;
            this.tbAdminModule.UseSelectable = true;
            this.tbAdminModule.UseStyleColors = true;
            this.tbAdminModule.Enter += new System.EventHandler(this.tbAdminModule_Enter);
            // 
            // tbInvoice
            // 
            this.tbInvoice.Controls.Add(this.panel2);
            this.tbInvoice.Controls.Add(this.dgvInvoice);
            this.tbInvoice.Controls.Add(this.panel1);
            this.tbInvoice.Location = new System.Drawing.Point(4, 41);
            this.tbInvoice.Name = "tbInvoice";
            this.tbInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tbInvoice.Size = new System.Drawing.Size(1275, 253);
            this.tbInvoice.TabIndex = 0;
            this.tbInvoice.Text = "Invoice List";
            this.tbInvoice.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.bindingNavigator1);
            this.panel2.Controls.Add(this.btnAudit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1269, 44);
            this.panel2.TabIndex = 2;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(146, 13);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(255, 25);
            this.bindingNavigator1.TabIndex = 10;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAudit
            // 
            this.btnAudit.AutoSize = true;
            this.btnAudit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnAudit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAudit.DisplayFocus = true;
            this.btnAudit.ForeColor = System.Drawing.Color.White;
            this.btnAudit.Highlight = true;
            this.btnAudit.Location = new System.Drawing.Point(3, 4);
            this.btnAudit.Name = "btnAudit";
            this.btnAudit.Size = new System.Drawing.Size(100, 35);
            this.btnAudit.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnAudit.TabIndex = 9;
            this.btnAudit.Text = "Audit Trail";
            this.btnAudit.UseCustomBackColor = true;
            this.btnAudit.UseCustomForeColor = true;
            this.btnAudit.UseSelectable = true;
            this.btnAudit.UseStyleColors = true;
            this.btnAudit.Click += new System.EventHandler(this.btnAudit_Click);
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            this.dgvInvoice.AllowUserToOrderColumns = true;
            this.dgvInvoice.AllowUserToResizeColumns = false;
            this.dgvInvoice.AllowUserToResizeRows = false;
            this.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoice.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoice.ColumnHeadersHeight = 40;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ReceiptDate,
            this.invoicename,
            this.SupplierEmail,
            this.difficulty,
            this.Status,
            this.UserAssigned,
            this.dgvUserActionColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoice.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoice.EmptyResultText = "No Records Found.";
            this.dgvInvoice.GridColor = System.Drawing.Color.Silver;
            this.dgvInvoice.Location = new System.Drawing.Point(3, 54);
            this.dgvInvoice.MultiSelect = false;
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.PageSize = 10;
            this.dgvInvoice.ReadOnly = true;
            this.dgvInvoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInvoice.RowHeadersVisible = false;
            this.dgvInvoice.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoice.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInvoice.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.dgvInvoice.Size = new System.Drawing.Size(1269, 196);
            this.dgvInvoice.TabIndex = 3;
            this.dgvInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            this.dgvInvoice.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvUsers_EditingControlShowing);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 51);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.118977F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.35209F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.07149F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.63083F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.98959F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.769271F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.06775F));
            this.tableLayoutPanel1.Controls.Add(this.panel7, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 6, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1269, 51);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtSuppEmail);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(588, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(191, 45);
            this.panel7.TabIndex = 9;
            // 
            // txtSuppEmail
            // 
            // 
            // 
            // 
            this.txtSuppEmail.CustomButton.Image = null;
            this.txtSuppEmail.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.txtSuppEmail.CustomButton.Name = "";
            this.txtSuppEmail.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSuppEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtSuppEmail.CustomButton.TabIndex = 1;
            this.txtSuppEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSuppEmail.CustomButton.UseSelectable = true;
            this.txtSuppEmail.CustomButton.Visible = false;
            this.txtSuppEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSuppEmail.Lines = new string[0];
            this.txtSuppEmail.Location = new System.Drawing.Point(3, 8);
            this.txtSuppEmail.MaxLength = 32767;
            this.txtSuppEmail.Multiline = true;
            this.txtSuppEmail.Name = "txtSuppEmail";
            this.txtSuppEmail.PasswordChar = '\0';
            this.txtSuppEmail.PromptText = "Supplier Email";
            this.txtSuppEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSuppEmail.SelectedText = "";
            this.txtSuppEmail.SelectionLength = 0;
            this.txtSuppEmail.SelectionStart = 0;
            this.txtSuppEmail.ShortcutsEnabled = true;
            this.txtSuppEmail.ShowClearButton = true;
            this.txtSuppEmail.Size = new System.Drawing.Size(185, 29);
            this.txtSuppEmail.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtSuppEmail.TabIndex = 5;
            this.txtSuppEmail.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSuppEmail.UseCustomBackColor = true;
            this.txtSuppEmail.UseCustomForeColor = true;
            this.txtSuppEmail.UseSelectable = true;
            this.txtSuppEmail.UseStyleColors = true;
            this.txtSuppEmail.WaterMark = "Supplier Email";
            this.txtSuppEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSuppEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtcalanderto);
            this.panel9.Controls.Add(this.txtCalFrm);
            this.panel9.Controls.Add(this.lblFrom);
            this.panel9.Controls.Add(this.lblTo);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(4, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(275, 45);
            this.panel9.TabIndex = 11;
            // 
            // txtcalanderto
            // 
            // 
            // 
            // 
            this.txtcalanderto.CustomButton.Image = null;
            this.txtcalanderto.CustomButton.Location = new System.Drawing.Point(57, 1);
            this.txtcalanderto.CustomButton.Name = "";
            this.txtcalanderto.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtcalanderto.CustomButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtcalanderto.CustomButton.TabIndex = 1;
            this.txtcalanderto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcalanderto.CustomButton.UseSelectable = true;
            this.txtcalanderto.CustomButton.Visible = false;
            this.txtcalanderto.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtcalanderto.Lines = new string[0];
            this.txtcalanderto.Location = new System.Drawing.Point(172, 8);
            this.txtcalanderto.MaxLength = 32767;
            this.txtcalanderto.Multiline = true;
            this.txtcalanderto.Name = "txtcalanderto";
            this.txtcalanderto.PasswordChar = '\0';
            this.txtcalanderto.PromptText = "Receipt Date";
            this.txtcalanderto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcalanderto.SelectedText = "";
            this.txtcalanderto.SelectionLength = 0;
            this.txtcalanderto.SelectionStart = 0;
            this.txtcalanderto.ShortcutsEnabled = true;
            this.txtcalanderto.ShowClearButton = true;
            this.txtcalanderto.Size = new System.Drawing.Size(85, 29);
            this.txtcalanderto.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtcalanderto.TabIndex = 17;
            this.txtcalanderto.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcalanderto.UseCustomBackColor = true;
            this.txtcalanderto.UseCustomForeColor = true;
            this.txtcalanderto.UseSelectable = true;
            this.txtcalanderto.UseStyleColors = true;
            this.txtcalanderto.WaterMark = "Receipt Date";
            this.txtcalanderto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcalanderto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCalFrm
            // 
            // 
            // 
            // 
            this.txtCalFrm.CustomButton.Image = null;
            this.txtCalFrm.CustomButton.Location = new System.Drawing.Point(51, 1);
            this.txtCalFrm.CustomButton.Name = "";
            this.txtCalFrm.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCalFrm.CustomButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtCalFrm.CustomButton.TabIndex = 1;
            this.txtCalFrm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCalFrm.CustomButton.UseSelectable = true;
            this.txtCalFrm.CustomButton.Visible = false;
            this.txtCalFrm.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCalFrm.Lines = new string[0];
            this.txtCalFrm.Location = new System.Drawing.Point(50, 8);
            this.txtCalFrm.MaxLength = 32767;
            this.txtCalFrm.Multiline = true;
            this.txtCalFrm.Name = "txtCalFrm";
            this.txtCalFrm.PasswordChar = '\0';
            this.txtCalFrm.PromptText = "Receipt Date";
            this.txtCalFrm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCalFrm.SelectedText = "";
            this.txtCalFrm.SelectionLength = 0;
            this.txtCalFrm.SelectionStart = 0;
            this.txtCalFrm.ShortcutsEnabled = true;
            this.txtCalFrm.ShowClearButton = true;
            this.txtCalFrm.Size = new System.Drawing.Size(79, 29);
            this.txtCalFrm.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtCalFrm.TabIndex = 16;
            this.txtCalFrm.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCalFrm.UseCustomBackColor = true;
            this.txtCalFrm.UseCustomForeColor = true;
            this.txtCalFrm.UseSelectable = true;
            this.txtCalFrm.UseStyleColors = true;
            this.txtCalFrm.WaterMark = "Receipt Date";
            this.txtCalFrm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCalFrm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblFrom.ForeColor = System.Drawing.Color.Black;
            this.lblFrom.Location = new System.Drawing.Point(3, 12);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(41, 19);
            this.lblFrom.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblFrom.TabIndex = 15;
            this.lblFrom.Text = "From";
            this.lblFrom.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblFrom.UseCustomBackColor = true;
            this.lblFrom.UseCustomForeColor = true;
            this.lblFrom.UseStyleColors = true;
            this.lblFrom.UseWaitCursor = true;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTo.ForeColor = System.Drawing.Color.Black;
            this.lblTo.Location = new System.Drawing.Point(142, 12);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(24, 19);
            this.lblTo.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblTo.TabIndex = 14;
            this.lblTo.Text = "To";
            this.lblTo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblTo.UseCustomBackColor = true;
            this.lblTo.UseCustomForeColor = true;
            this.lblTo.UseStyleColors = true;
            this.lblTo.UseWaitCursor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblStatus);
            this.panel6.Controls.Add(this.cbInvoiceStatus);
            this.panel6.Controls.Add(this.cbFilterDifficulty);
            this.panel6.Controls.Add(this.lblFilterDifficulty);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(285, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(297, 45);
            this.panel6.TabIndex = 8;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(127, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 19);
            this.lblStatus.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";
            this.lblStatus.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblStatus.UseCustomBackColor = true;
            this.lblStatus.UseCustomForeColor = true;
            this.lblStatus.UseStyleColors = true;
            this.lblStatus.UseWaitCursor = true;
            // 
            // cbInvoiceStatus
            // 
            this.cbInvoiceStatus.FormattingEnabled = true;
            this.cbInvoiceStatus.ItemHeight = 23;
            this.cbInvoiceStatus.Location = new System.Drawing.Point(180, 8);
            this.cbInvoiceStatus.Name = "cbInvoiceStatus";
            this.cbInvoiceStatus.Size = new System.Drawing.Size(116, 29);
            this.cbInvoiceStatus.TabIndex = 7;
            this.cbInvoiceStatus.UseSelectable = true;
            // 
            // cbFilterDifficulty
            // 
            this.cbFilterDifficulty.FormattingEnabled = true;
            this.cbFilterDifficulty.ItemHeight = 23;
            this.cbFilterDifficulty.Location = new System.Drawing.Point(68, 8);
            this.cbFilterDifficulty.Name = "cbFilterDifficulty";
            this.cbFilterDifficulty.Size = new System.Drawing.Size(53, 29);
            this.cbFilterDifficulty.TabIndex = 2;
            this.cbFilterDifficulty.UseSelectable = true;
            // 
            // lblFilterDifficulty
            // 
            this.lblFilterDifficulty.AutoSize = true;
            this.lblFilterDifficulty.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblFilterDifficulty.ForeColor = System.Drawing.Color.Black;
            this.lblFilterDifficulty.Location = new System.Drawing.Point(3, 12);
            this.lblFilterDifficulty.Name = "lblFilterDifficulty";
            this.lblFilterDifficulty.Size = new System.Drawing.Size(62, 19);
            this.lblFilterDifficulty.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblFilterDifficulty.TabIndex = 3;
            this.lblFilterDifficulty.Text = "Difficulty";
            this.lblFilterDifficulty.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblFilterDifficulty.UseCustomBackColor = true;
            this.lblFilterDifficulty.UseCustomForeColor = true;
            this.lblFilterDifficulty.UseStyleColors = true;
            this.lblFilterDifficulty.UseWaitCursor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtInvName);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(790, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(171, 45);
            this.panel8.TabIndex = 10;
            // 
            // txtInvName
            // 
            // 
            // 
            // 
            this.txtInvName.CustomButton.Image = null;
            this.txtInvName.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtInvName.CustomButton.Name = "";
            this.txtInvName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtInvName.CustomButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtInvName.CustomButton.TabIndex = 1;
            this.txtInvName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvName.CustomButton.UseSelectable = true;
            this.txtInvName.CustomButton.Visible = false;
            this.txtInvName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtInvName.Lines = new string[0];
            this.txtInvName.Location = new System.Drawing.Point(9, 8);
            this.txtInvName.MaxLength = 32767;
            this.txtInvName.Multiline = true;
            this.txtInvName.Name = "txtInvName";
            this.txtInvName.PasswordChar = '\0';
            this.txtInvName.PromptText = "Invoice Name";
            this.txtInvName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvName.SelectedText = "";
            this.txtInvName.SelectionLength = 0;
            this.txtInvName.SelectionStart = 0;
            this.txtInvName.ShortcutsEnabled = true;
            this.txtInvName.ShowClearButton = true;
            this.txtInvName.Size = new System.Drawing.Size(161, 29);
            this.txtInvName.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtInvName.TabIndex = 6;
            this.txtInvName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvName.UseCustomBackColor = true;
            this.txtInvName.UseCustomForeColor = true;
            this.txtInvName.UseSelectable = true;
            this.txtInvName.UseStyleColors = true;
            this.txtInvName.WaterMark = "Invoice Name";
            this.txtInvName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInvName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lnkClearFilter);
            this.panel4.Controls.Add(this.btnFilter);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(967, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(183, 45);
            this.panel4.TabIndex = 7;
            // 
            // lnkClearFilter
            // 
            this.lnkClearFilter.AutoSize = true;
            this.lnkClearFilter.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lnkClearFilter.Location = new System.Drawing.Point(64, 22);
            this.lnkClearFilter.Name = "lnkClearFilter";
            this.lnkClearFilter.Size = new System.Drawing.Size(56, 13);
            this.lnkClearFilter.TabIndex = 1;
            this.lnkClearFilter.TabStop = true;
            this.lnkClearFilter.Text = "Clear Filter";
            this.lnkClearFilter.Click += new System.EventHandler(this.lnkClearFilter_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.AutoSize = true;
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.DisplayFocus = true;
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Highlight = true;
            this.btnFilter.Location = new System.Drawing.Point(4, 8);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(50, 29);
            this.btnFilter.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnFilter.TabIndex = 0;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseCustomBackColor = true;
            this.btnFilter.UseCustomForeColor = true;
            this.btnFilter.UseSelectable = true;
            this.btnFilter.UseStyleColors = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.btnNewBatch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1156, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 45);
            this.panel3.TabIndex = 8;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnNewBatch
            // 
            this.btnNewBatch.AutoSize = true;
            this.btnNewBatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.btnNewBatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewBatch.DisplayFocus = true;
            this.btnNewBatch.ForeColor = System.Drawing.Color.White;
            this.btnNewBatch.Highlight = true;
            this.btnNewBatch.Location = new System.Drawing.Point(5, 8);
            this.btnNewBatch.Name = "btnNewBatch";
            this.btnNewBatch.Size = new System.Drawing.Size(105, 29);
            this.btnNewBatch.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnNewBatch.TabIndex = 11;
            this.btnNewBatch.Text = "Open New Batch";
            this.btnNewBatch.UseCustomBackColor = true;
            this.btnNewBatch.UseCustomForeColor = true;
            this.btnNewBatch.UseSelectable = true;
            this.btnNewBatch.UseStyleColors = true;
            this.btnNewBatch.Click += new System.EventHandler(this.btnNewBatch_Click);
            // 
            // tbBatch
            // 
            this.tbBatch.Controls.Add(this.dgvSuppliers);
            this.tbBatch.Location = new System.Drawing.Point(4, 41);
            this.tbBatch.Name = "tbBatch";
            this.tbBatch.Padding = new System.Windows.Forms.Padding(3);
            this.tbBatch.Size = new System.Drawing.Size(1275, 253);
            this.tbBatch.TabIndex = 1;
            this.tbBatch.Text = " My Batches";
            this.tbBatch.UseVisualStyleBackColor = true;
            this.tbBatch.Click += new System.EventHandler(this.tbSupplier_Click);
            this.tbBatch.Enter += new System.EventHandler(this.tbSupplier_Enter);
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AllowUserToOrderColumns = true;
            this.dgvSuppliers.AllowUserToResizeColumns = false;
            this.dgvSuppliers.AllowUserToResizeRows = false;
            this.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuppliers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSuppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSuppliers.ColumnHeadersHeight = 40;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BatchID,
            this.CreatedDate,
            this.BatchNumber,
            this.InvoiceCount,
            this.DifficultyLevelinBatch,
            this.dataGridViewTextBoxColumn1});
            this.dgvSuppliers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuppliers.EmptyResultText = "No Records Found.";
            this.dgvSuppliers.GridColor = System.Drawing.Color.Black;
            this.dgvSuppliers.Location = new System.Drawing.Point(3, 3);
            this.dgvSuppliers.MultiSelect = false;
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.PageSize = 10;
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSuppliers.RowHeadersVisible = false;
            this.dgvSuppliers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSuppliers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSuppliers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            this.dgvSuppliers.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.RowTemplate.DividerHeight = 1;
            this.dgvSuppliers.Size = new System.Drawing.Size(1269, 247);
            this.dgvSuppliers.TabIndex = 1;
            // 
            // BatchID
            // 
            this.BatchID.HeaderText = "Batch ID";
            this.BatchID.Name = "BatchID";
            this.BatchID.ReadOnly = true;
            // 
            // CreatedDate
            // 
            this.CreatedDate.HeaderText = "Created Date";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            // 
            // BatchNumber
            // 
            this.BatchNumber.HeaderText = "BatchNumber";
            this.BatchNumber.Name = "BatchNumber";
            this.BatchNumber.ReadOnly = true;
            // 
            // InvoiceCount
            // 
            this.InvoiceCount.HeaderText = "Invoice Count";
            this.InvoiceCount.Name = "InvoiceCount";
            this.InvoiceCount.ReadOnly = true;
            // 
            // DifficultyLevelinBatch
            // 
            this.DifficultyLevelinBatch.HeaderText = "Difficulty Level";
            this.DifficultyLevelinBatch.Name = "DifficultyLevelinBatch";
            this.DifficultyLevelinBatch.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Status";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 101.6019F;
            this.dataGridViewImageColumn1.HeaderText = "Actions";
            this.dataGridViewImageColumn1.Image = global::eBatchApp.Properties.Resources.edit;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 316;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::eBatchApp.Properties.Resources.delete1;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 253;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "InvoiceID";
            this.Column1.FillWeight = 99.85529F;
            this.Column1.HeaderText = "Invoice ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ReceiptDate
            // 
            this.ReceiptDate.DataPropertyName = "ReceiptDate";
            this.ReceiptDate.HeaderText = "Receipt Date";
            this.ReceiptDate.Name = "ReceiptDate";
            this.ReceiptDate.ReadOnly = true;
            // 
            // invoicename
            // 
            this.invoicename.DataPropertyName = "InvoiceName";
            this.invoicename.FillWeight = 99.35419F;
            this.invoicename.HeaderText = "Invoice Name";
            this.invoicename.Name = "invoicename";
            this.invoicename.ReadOnly = true;
            // 
            // SupplierEmail
            // 
            this.SupplierEmail.DataPropertyName = "SupplierEmail";
            this.SupplierEmail.HeaderText = "Supplier Email";
            this.SupplierEmail.Name = "SupplierEmail";
            this.SupplierEmail.ReadOnly = true;
            // 
            // difficulty
            // 
            this.difficulty.DataPropertyName = "DifficultyLevel";
            this.difficulty.FillWeight = 100.0996F;
            this.difficulty.HeaderText = "Difficulty Level";
            this.difficulty.Name = "difficulty";
            this.difficulty.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // UserAssigned
            // 
            this.UserAssigned.DataPropertyName = "UserAssigned";
            this.UserAssigned.HeaderText = "User Assigned";
            this.UserAssigned.Name = "UserAssigned";
            this.UserAssigned.ReadOnly = true;
            // 
            // dgvUserActionColumn
            // 
            this.dgvUserActionColumn.FillWeight = 101.6019F;
            this.dgvUserActionColumn.HeaderText = "Actions";
            this.dgvUserActionColumn.Image = global::eBatchApp.Properties.Resources.edit1;
            this.dgvUserActionColumn.Name = "dgvUserActionColumn";
            this.dgvUserActionColumn.ReadOnly = true;
            // 
            // FrmDataEntryHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 358);
            this.Controls.Add(this.tbAdminModule);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmDataEntryHome";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.DataEntryHome_Load);
            this.tbAdminModule.ResumeLayout(false);
            this.tbInvoice.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tbBatch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tbInvoice;
        private System.Windows.Forms.TabPage tbBatch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private eGrid dgvInvoice;
        private eGrid dgvSuppliers;
        private eNewButton btnAudit;
        private MetroFramework.Controls.MetroTabControl tbAdminModule;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private eNewButton btnFilter;
        private eTextBox txtSuppEmail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.LinkLabel lnkClearFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifficultyLevelinBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private eLabel lblFrom;
        private eLabel lblTo;
        private MetroFramework.Controls.MetroComboBox cbFilterDifficulty;
        private eLabel lblFilterDifficulty;
        private System.Windows.Forms.Panel panel8;
        private eTextBox txtInvName;
        private MetroFramework.Controls.MetroComboBox cbInvoiceStatus;
        private eLabel lblStatus;
        private eTextBox txtcalanderto;
        private eTextBox txtCalFrm;
        private eNewButton btnNewBatch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicename;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn difficulty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserAssigned;
        private System.Windows.Forms.DataGridViewImageColumn dgvUserActionColumn;
    }
}