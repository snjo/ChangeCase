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
    public partial class Form1 : Form
    {
        string clipBoardText;
         
        public Form1()
        {
            InitializeComponent();

            timer1.Start();
 
        }

        private void changeCase()
        {
            try
            {

                if (Clipboard.ContainsText())
                {
                    clipBoardText = Clipboard.GetText(TextDataFormat.Text);
                    if (clipBoardText.Length > 0)
                    {
                        if (radioLower.Checked)
                        {
                            clipBoardText = clipBoardText.ToLower();
                        }
                        else if (radioUpper.Checked)
                        {
                            clipBoardText = clipBoardText.ToUpper();
                        }
                        Clipboard.SetText(clipBoardText);
                    }
                }
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            changeCase();
        }
    }
}
