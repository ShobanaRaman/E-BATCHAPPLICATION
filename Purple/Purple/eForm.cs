using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;


namespace eBatch.Theme.Purple
{
    public class eForm : MetroForm
    {
        public eForm()
        {
            
               AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           // BackgroundImage = global::eBatch.Theme.Properties.Resources.BG_2x;
            ClientSize = new System.Drawing.Size(708, 358);
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.None;
            Style = MetroFramework.MetroColorStyle.Purple;
            Location = new Point(3, 3);
            Padding = new Padding(0, 0, 0, 0);
           // InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // eForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.ControlBox = false;
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "eForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.ResumeLayout(false);

        }
    }
}
