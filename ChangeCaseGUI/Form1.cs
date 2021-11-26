using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotkeys;

namespace ChangeCaseGUI
{
    public partial class Form1 : Form
    {
        string clipBoardText;
        private Hotkeys.GlobalHotkey ghkUpper;
        private Hotkeys.GlobalHotkey ghkLower;

        public Form1()
        {
            InitializeComponent();

            timer1.Start();
            ghkUpper = new Hotkeys.GlobalHotkey(Constants.ALT + Constants.SHIFT, Keys.U, this);
            ghkLower = new Hotkeys.GlobalHotkey(Constants.ALT + Constants.SHIFT, Keys.L, this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //trying to register hotkey
            if (!ghkUpper.Register())
                writeMessage("HkUpper not registered");
            if (!ghkLower.Register())
                writeMessage("HkLower not registered");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ghkUpper.Unregister())
            {
                MessageBox.Show("Hotkey failed to unregister");
                //writeMessage("Hotkey failed to unregister");
            }
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

        private void HandleHotkey(int id)
        {
            //hotkey pressed
            //MessageBox.Show("Hotkey pressed");

            //writeMessage("Hotkey pressed");

            if (id == ghkLower.id)
            {
                if (Clipboard.ContainsText()) {
                    clipBoardText = Clipboard.GetText(TextDataFormat.Text);
                    clipBoardText = clipBoardText.ToLower();
                    Clipboard.SetText(clipBoardText);
                }
            }

            if (id == ghkUpper.id)
            {
                if (Clipboard.ContainsText()) {
                    clipBoardText = Clipboard.GetText(TextDataFormat.Text);
                    clipBoardText = clipBoardText.ToUpper();
                    Clipboard.SetText(clipBoardText);
                }
            }
        }

        private void writeMessage(string text)
        {
            label1.Text = text;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);            
            if (m.Msg == Hotkeys.Constants.WM_HOTKEY_MSG_ID)
            {
                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);                  // The key of the hotkey that was pressed.
                KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF);       // The modifier of the hotkey that was pressed.
                int id = m.WParam.ToInt32();                                        // The id of the hotkey that was pressed.
                //MessageBox.Show("Hotkey " + id + " has been pressed!");
                HandleHotkey(id);
            }            
        }

    }
}
