using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBatch.Theme.Purple
{
    public class eDataGridCheckBoxColumn : DataGridViewCheckBoxColumn
    {
        public eDataGridCheckBoxColumn()
        {
            this.CellTemplate = new SlideBoxCell();
        }
    }

    internal class SlideBoxCell : DataGridViewCell
    {

    }
}
