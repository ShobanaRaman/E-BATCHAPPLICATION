using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.Theme.Purple
{
    public class eLabel : MetroFramework.Controls.MetroLabel
    {
        public eLabel()
        {
            AutoSize = true;
            FontWeight = MetroFramework.MetroLabelWeight.Regular;
            ForeColor = System.Drawing.Color.Black;
            Size = new System.Drawing.Size(77, 19);
            Style = MetroFramework.MetroColorStyle.Purple;
            Theme = MetroFramework.MetroThemeStyle.Light;
            UseCustomBackColor = true;
            UseCustomForeColor = true;
            UseStyleColors = true;
            UseWaitCursor = true;
        }
    }
}
