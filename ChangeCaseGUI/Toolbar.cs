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
        public Form1 mainform;
        private bool borderLess = false;
        private bool alwaysOnTop = true;

        public Toolbar()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
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
    }


}
