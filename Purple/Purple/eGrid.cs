using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBatch.Theme.Purple
{
    public class eGrid : System.Windows.Forms.DataGridView
    {
        public string EmptyResultText { get; set; }
        public eGrid()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle HeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();

            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            HeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            HeaderStyle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            HeaderStyle.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            HeaderStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            HeaderStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            HeaderStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            HeaderStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;



            AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dock = System.Windows.Forms.DockStyle.Fill;
            Size = new System.Drawing.Size(694, 272);
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToOrderColumns = true;
            AllowUserToResizeColumns = false;
            AllowUserToResizeRows = false;
            AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            BackgroundColor = System.Drawing.Color.WhiteSmoke;
            ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            ColumnHeadersDefaultCellStyle = HeaderStyle;
            ColumnHeadersHeight = 40;
            ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DefaultCellStyle = dataGridViewCellStyle1;
            Dock = System.Windows.Forms.DockStyle.Fill;
            GridColor = System.Drawing.Color.Silver;
            MultiSelect = false;
            ReadOnly = true;
            RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            RowHeadersVisible = false;
            RowsDefaultCellStyle = dataGridViewCellStyle1;
            RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            RowTemplate.DividerHeight = 1;
            RowTemplate.Height = 40;
            Size = new System.Drawing.Size(694, 196);
            EmptyResultText = "No Records Found.";
            this.Paint += MyDataGridView_Paint;

        }


        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = value;
            }
        }
        public int _pageSize = 10;
        BindingSource bs = new BindingSource();
        BindingList<DataTable> tables = new BindingList<DataTable>();
        public void SetPagedDataSource(DataTable dataTable, BindingNavigator bnav)
        {
            bs = new BindingSource();
            tables = new BindingList<DataTable>();
            DataTable dt = null;
            int counter = 1;
            foreach (DataRow dr in dataTable.Rows)
            {
                if (counter == 1)
                {
                    dt = dataTable.Clone();
                    tables.Add(dt);
                }
                dt.Rows.Add(dr.ItemArray);
                if (PageSize < ++counter)
                {
                    counter = 1;
                }
            }
            bnav.BindingSource = bs;
            bs.DataSource = tables;
            bs.PositionChanged += bs_PositionChanged;
            bs_PositionChanged(bs, EventArgs.Empty);
        }
        void bs_PositionChanged(object sender, EventArgs e)
        {
            if (bs.Position > 0)
                this.DataSource = tables[bs.Position];
        }


        protected override void OnCellFormatting(DataGridViewCellFormattingEventArgs e)
        {
            if ((this.Rows[e.RowIndex].DataBoundItem != null) && (this.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(this.Rows[e.RowIndex].DataBoundItem, this.Columns[e.ColumnIndex].DataPropertyName
             );
            }
        }

        private string BindProperty(object property, string propertyName)
        {
            string retValue = "";

            if (propertyName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;

                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                arrayProperties = property.GetType().GetProperties();

                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = BindProperty(
                          propertyInfo.GetValue(property, null),
                          propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;

                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);
                retValue = propertyInfo.GetValue(property, null).ToString();
            }

            return retValue;
        }

        private void MyDataGridView_Paint(object sender, PaintEventArgs e)
        {
            if (!string.IsNullOrEmpty(EmptyResultText))
            {
                if (this.Rows.Count == 0)
                {
                    using (var gfx = e.Graphics)
                    {
                        gfx.DrawString(this.EmptyResultText, this.Font, Brushes.Black,
                            new PointF((this.Width - this.Font.Size * EmptyResultText.Length) / 2, this.Height / 2));
                    }
                }
            }

        }
    }
}
