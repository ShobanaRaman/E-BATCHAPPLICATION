using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.Theme.Purple
{
    public class eTextBox : MetroFramework.Controls.MetroTextBox
    {
        public eTextBox()
        {
            CustomButton.Image = null;
            CustomButton.Location = new System.Drawing.Point(187, 1);
            CustomButton.Name = "";
            CustomButton.Size = new System.Drawing.Size(33, 33);
            CustomButton.Style = MetroFramework.MetroColorStyle.Purple;
            CustomButton.TabIndex = 1;
            CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            CustomButton.UseSelectable = true;
            CustomButton.Visible = false;
            FontSize = MetroFramework.MetroTextBoxSize.Medium;
            Lines = new string[] { };
            MaxLength = 32767;
            Multiline = true;
            PasswordChar = '\0';
            ScrollBars = System.Windows.Forms.ScrollBars.None;
            SelectedText = "";
            SelectionLength = 0;
            SelectionStart = 0;
            ShortcutsEnabled = true;
            ShowClearButton = true;
            Size = new System.Drawing.Size(221, 29);
            Style = MetroFramework.MetroColorStyle.Purple;
            Theme = MetroFramework.MetroThemeStyle.Light;
            UseCustomBackColor = true;
            UseCustomForeColor = true;
            UseSelectable = true;
            UseStyleColors = true;
            WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);

        }
    }
}
