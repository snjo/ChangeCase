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
        public Form mainform;
        private bool borderLess = false;

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
    }


}
