using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCaseGUI
{
    public partial class Toolbar : Form
    {
        public MainForm mainform;
        private bool borderLess = false;
        private bool alwaysOnTop = true;

        public Toolbar()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //string tooltipText = "...";
            //toolTip1.SetToolTip(buttonMemory1, tooltipText);
            //toolTip1.SetToolTip(buttonMemory2, tooltipText);
            //toolTip1.SetToolTip(buttonMemory3, tooltipText);

        }

        private void actionToolbarClose(object sender, EventArgs e)
        {
            mainform.Show();
            this.Close();
        }

        public void ShowForm()
        {
            Show();
        }

        private void actionBorderToggle(object sender, EventArgs e)
        {
            borderLess = !borderLess;
            if (borderLess)
            {                
                FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.FixedToolWindow;
            }
        }

        private void actionAlwaysOnTop(object sender, EventArgs e)
        {
            alwaysOnTop = !alwaysOnTop;
            if (alwaysOnTop)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
        }

        private void actionLower(object sender, EventArgs e)
        {
            mainform.actionLowerCaseOnce(sender, e);
        }

        private void actionUpper(object sender, EventArgs e)
        {
            mainform.actionUpperCaseOnce(sender, e);
        }

        private void actionPlain(object sender, EventArgs e)
        {
            mainform.actionPlainTextOnce(sender, e);
        }

        private void actionProcess(object sender, EventArgs e)
        {
            mainform.actionProcessText(sender, e);
        }

        private void saveload1(object sender, MouseEventArgs e)
        {
            saveLoad(1, e);
        }

        private void saveload2(object sender, MouseEventArgs e)
        {
            saveLoad(2, e);
        }
        private void saveload3(object sender, MouseEventArgs e)
        {
            saveLoad(3, e);
        }

        private void saveLoad(int num, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mainform.setClipboardFromTextBox(num);
            }
            if (e.Button == MouseButtons.Right)
            {
                mainform.setTextBoxFromClipboard(num);
            }
        }

        private void updateTooltip(int num)
        {
            toolTip1.SetToolTip(buttonMemory1, "Left Click to load to clipboard\nRight Click to save clipboard to this slot\n\n" + mainform.getMemorySlot(num));
        }

        private void updateTooltip1(object sender, EventArgs e)
        {
            updateTooltip(1);
        }

        private void updateTooltip2(object sender, EventArgs e)
        {
            updateTooltip(2);
        }

        private void updateTooltip3(object sender, EventArgs e)
        {
            updateTooltip(3);
        }
    }


}
