using eBatch.Theme.Purple;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBatchApp.DataEntry
{
    public partial class InvoiceEntry : eForm
    {
        string actualHtml = string.Empty;
        public InvoiceEntry()
        {
            InitializeComponent();
        }

        private void InvoiceEntry_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://ga.whiteclarke.com:8443/app/control");
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            var elems = webBrowser1.Document.GetElementsByTagName("div");
            foreach(HtmlElement el in elems)
            {
                if(el.Id !=null && el.Id.Contains("a3tlbInvoice"))
                {
                    actualHtml = el.InnerHtml;
                    el.InnerHtml = "ERROR! PLEASE FIX ERROS BEFORE YOU SAVE.";
                   // el.Children[0].Style = "display:none";
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var elems = webBrowser1.Document.GetElementsByTagName("div");
            foreach (HtmlElement el in elems)
            {
                if (el.Id != null && el.Id.Contains("a3tlbInvoice"))
                {
                    el.InnerHtml = actualHtml;
                }
            }
        }
    }
}
