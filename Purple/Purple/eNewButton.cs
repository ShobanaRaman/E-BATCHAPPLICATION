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
    public class eNewButton : MetroFramework.Controls.MetroButton
    {
        public eNewButton()
        {
            AutoSize = true;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(21)))), ((int)(((byte)(108)))));
            Cursor = System.Windows.Forms.Cursors.Hand;
            DisplayFocus = true;
            ForeColor = System.Drawing.Color.White;
            Highlight = true;
            Location = new System.Drawing.Point(403, 310);
            Style = MetroFramework.MetroColorStyle.Purple;
            UseCustomBackColor = true;
            UseCustomForeColor = true;
            UseSelectable = true;
            UseStyleColors = true;
            Size = new System.Drawing.Size(100, 35);

        }

    }
}
