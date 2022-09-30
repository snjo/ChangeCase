using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotkeys;

namespace ChangeCaseGUI
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        string clipBoardText;
        private Hotkeys.GlobalHotkey ghkUpper;
        private Hotkeys.GlobalHotkey ghkLower;
        private Hotkeys.GlobalHotkey ghkCapsLock;
        //private Hotkeys.GlobalHotkey ghkPasteUpperCase;
        private Hotkeys.GlobalHotkey ghkPlainText;
        private Icon iconUpper;
        private Icon iconLower;
        private bool oldCapslockState;
        private bool capLockStateSet = false;
        public Form Current;

        public Form1()
        {
            InitializeComponent();
            Current = this;
            timer1.Start();
            ghkUpper = new Hotkeys.GlobalHotkey(Constants.ALT + Constants.SHIFT, Keys.U, this);
            ghkLower = new Hotkeys.GlobalHotkey(Constants.ALT + Constants.SHIFT, Keys.L, this);
            ghkCapsLock = new Hotkeys.GlobalHotkey(Constants.CTRL + Constants.SHIFT, Keys.Back, this);
            ghkPlainText = new Hotkeys.GlobalHotkey(Constants.ALT + Constants.SHIFT, Keys.P, this);
            //ghkPasteUpperCase = new Hotkeys.GlobalHotkey(Constants.ALT + Constants.SHIFT, Keys.V, this);

            iconUpper = notifyIcon1.Icon;
            iconLower = systrayIcon.Icon;



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string errorMessages = "";
            //trying to register hotkey
            if (!ghkUpper.Register())
                errorMessages += "Hotkey Upper not registered\n";
            if (!ghkLower.Register())
                errorMessages += "Hotkey Lower not registered\n";
            if (!ghkCapsLock.Register())
                errorMessages += "Hotkey CapsLock not registered\n";
            if (!ghkPlainText.Register())
                errorMessages += "Hotkey PlainText not registered\n";
            //if (!ghkPasteUpperCase.Register())
            //    writeMessage("Hotkey PasteUpperCase not registered");
            if (errorMessages.Length > 0)
            {
                writeMessage(errorMessages);
            }

            if (Properties.Settings.Default.StartHidden)
            {
                //writeMessage("hiding");

                WindowState = FormWindowState.Minimized;
                Hide();
            }
            else
            {
                //writeMessage("show");
                //Show();
                this.WindowState = FormWindowState.Normal;
                //Show();
            }

            if (Properties.Settings.Default.StartToolbar)
            {
                actionShowToolbar(sender, e);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string errorMessages = "";
            if (!ghkUpper.Unregister())
            {
                errorMessages += "Hotkey ghkUpper failed to unregister\n";
            }
            if (!ghkLower.Unregister())
            {
                errorMessages += "Hotkey ghkLower failed to unregister\n";
            }
            if (!ghkCapsLock.Unregister())
            {
                errorMessages += "Hotkey ghkCapsLock failed to unregister\n";
            }
            if (!ghkPlainText.Unregister())
            {
                errorMessages += "Hotkey ghkPlainText failed to unregister\n";
            }
            //if (!ghkPasteUpperCase.Unregister())
            //{
            //    MessageBox.Show("Hotkey ghkPasteUpperCase failed to unregister");
            //}
            if (errorMessages.Length > 0)
            {
                writeMessage(errorMessages);
            }
        }

        private void changeCase()
        {
            try
            {
                if (!radioOff.Checked)
                {
                    if (Clipboard.ContainsText())
                    {
                        clipBoardText = Clipboard.GetText(TextDataFormat.Text);
                        if (clipBoardText.Length > 0)
                        {
                            if (radioLower.Checked)
                            {
                                clipBoardText = clipBoardText.ToLower();
                                Clipboard.SetText(clipBoardText);
                            }
                            else if (radioUpper.Checked)
                            {
                                clipBoardText = clipBoardText.ToUpper();
                                Clipboard.SetText(clipBoardText);
                            }
                            else if (radioPlain.Checked)
                            {
                                Clipboard.SetText(clipBoardText);
                            }
                        }
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
            UpdateCapsLock();
        }

        private void HandleHotkey(int id)
        {
            //hotkey pressed
            //MessageBox.Show("Hotkey pressed");

            //writeMessage("Hotkey pressed");

            if (id == ghkLower.id)
            {
                LowerCaseOnce();
            }

            if (id == ghkUpper.id)
            {
                UpperCaseOnce();
            }

            if (id == ghkCapsLock.id)
            {
                ToggleCapsLock();
            }

            if (id == ghkPlainText.id)
            {
                PlainTextOnce();
            }

            //if (id == ghkPasteUpperCase.id)
            //{
            //UpperCaseOnce();

            //SendKeys.Send("^v");
            //SendKeys.SendWait("a");
            //const int KEYEVENTF_EXTENDEDKEY = 0x1;
            //const int KEYEVENTF_KEYUP = 0x2;
            //keybd_event((byte)Keys.ControlKey, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            //keybd_event((byte)Keys.V, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
            //keybd_event((byte)Keys.V, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);
            //keybd_event((byte)Keys.ControlKey, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);
            //}
        }

        private void PlainTextOnce()
        {
            clipBoardText = Clipboard.GetText(TextDataFormat.Text);
            Clipboard.SetText(clipBoardText);
        }

        private void UpperCaseOnce()
        {
            if (Clipboard.ContainsText())
            {
                clipBoardText = Clipboard.GetText(TextDataFormat.Text);
                clipBoardText = clipBoardText.ToUpper();
                Clipboard.SetText(clipBoardText);
            }
        }

        private void LowerCaseOnce()
        {
            if (Clipboard.ContainsText())
            {
                clipBoardText = Clipboard.GetText(TextDataFormat.Text);
                clipBoardText = clipBoardText.ToLower();
                Clipboard.SetText(clipBoardText);
            }
        }

        private static void ToggleCapsLock()
        {
            const int KEYEVENTF_EXTENDEDKEY = 0x1;
            const int KEYEVENTF_KEYUP = 0x2;
            if (Control.IsKeyLocked(System.Windows.Forms.Keys.CapsLock))
            {
                keybd_event((byte)Keys.CapsLock, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
                keybd_event((byte)Keys.CapsLock, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);
            }
            else //redundant at the moment
            {
                keybd_event((byte)Keys.CapsLock, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
                keybd_event((byte)Keys.CapsLock, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);
            }
        }

        private void writeMessage(string text)
        {
            MessageBox.Show(text);
            //label1.Text = text;
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

        private void UpdateCapsLock()
        {
            bool capsLockStatus = Control.IsKeyLocked(System.Windows.Forms.Keys.CapsLock);
            if (!capLockStateSet || capsLockStatus != oldCapslockState)
            {
                checkBoxCapsLock.Checked = capsLockStatus;
                oldCapslockState = capsLockStatus;
                capLockStateSet = true;

                string CapsLockStatusText = "off";
                if (capsLockStatus)
                {
                    CapsLockStatusText = "on";
                    systrayIcon.Icon = iconUpper;
                }
                else
                {
                    systrayIcon.Icon = iconLower;
                }
                systrayIcon.Text = "Case Converter - Caps Lock is " + CapsLockStatusText;
            }          
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            UpdateCapsLock();
        }

        private void checkBoxCapsLock_Click(object sender, EventArgs e)
        {
            ToggleCapsLock();
        }

        private void actionCapsLock(object sender, EventArgs e)
        {
            ToggleCapsLock();
        }

        private void actionShowWindow(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            Show();
        }

        private void actionExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void actionCapsLock(object sender, MouseEventArgs e)
        {
            ToggleCapsLock();
        }

        public void actionUpperCaseOnce(object sender, EventArgs e)
        {
            UpperCaseOnce();
        }

        public void actionLowerCaseOnce(object sender, EventArgs e)
        {
            LowerCaseOnce();
        }

        public void actionHideFromTaskbar(object sender, EventArgs e)
        {
            Hide();
        }

        public void actionPlainTextOnce(object sender, EventArgs e)
        {
            PlainTextOnce();
        }

        private void actionShowToolbar(object sender, EventArgs e)
        {
            Toolbar toolbar = new Toolbar();
            toolbar.mainform = this;
            toolbar.Show();
            //toolbar.Parent = this;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            //options.Hide();
            options.ShowDialog();
        }
    }
}
