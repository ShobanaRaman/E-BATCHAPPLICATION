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
    public class eParentForm : MetroForm
    {
        public eParentForm()
        {
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //BackgroundImage = global::eBatch.Theme.Properties.Resources.BG_2x;
            ClientSize = new System.Drawing.Size(708, 358);
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Style = MetroFramework.MetroColorStyle.Purple;

        }
    }
}
