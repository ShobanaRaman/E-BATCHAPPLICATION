using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.Theme.Purple
{
    public class eFormPopup : eForm
    {
        public eFormPopup()
        {
            Text = "Dialog";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }
    }
}
