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
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        string clipBoardText;
        private Hotkeys.GlobalHotkey ghkUpper;
        private Hotkeys.GlobalHotkey ghkLower;
        private Hotkeys.GlobalHotkey ghkCapsLock;        
        private Hotkeys.GlobalHotkey ghkPlainText;
        private Hotkeys.GlobalHotkey ghkProcessText;
        private Icon iconUpper;
        private Icon iconLower;
        private bool oldCapslockState;
        private bool capLockStateSet = false;
        public Form Current;
        public HotkeyList hotkeys = new HotkeyList();
        private bool hotkeysSet = false;

        public MainForm()
        {
            InitializeComponent();
            Current = this;
            timer1.Start();

            iconUpper = notifyIcon1.Icon;
            iconLower = systrayIcon.Icon;
        }

        public void LoadHotkeys ()
        {
            
            ghkUpper =       LoadHotkey(out hotkeys.UpperCase,   Properties.Settings.Default.hkUpper);
            ghkLower =       LoadHotkey(out hotkeys.LowerCase,   Properties.Settings.Default.hkLower);
            ghkCapsLock =    LoadHotkey(out hotkeys.CapsLock,    Properties.Settings.Default.hkCapsLock);
            ghkPlainText =   LoadHotkey(out hotkeys.PlainText,   Properties.Settings.Default.hkPlain);
            ghkProcessText = LoadHotkey(out hotkeys.ProcessText, Properties.Settings.Default.hkProcessText);
            
        }

        private GlobalHotkey LoadHotkey(out Hotkey hotkey, Hotkey settingHotkey)
        {
            GlobalHotkey result = null;
            hotkey = settingHotkey;
            if (hotkey != null)
            {
                if (hotkey.key > 0)
                {
                    result = new Hotkeys.GlobalHotkey(hotkey.Modifiers(), (Keys)hotkey.key, this);
                }
                else
                {
                    //throw new Exception("hotkey is 0");
                }
            }
            else
            {
                //throw new Exception("hotkey is null");
            }
            return result;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadHotkeys();
            RegisterHotKeys();

            if (Properties.Settings.Default.StartHidden)
            {
                WindowState = FormWindowState.Minimized;
                Hide();
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

            if (Properties.Settings.Default.StartToolbar)
            {
                actionShowToolbar(sender, e);
            }

            updateHotkeyLabels();
            string tooltipText = "$d date\n$t time\n$cp clipboard contents\n$cl / $cu clipboard in lower/upper case\n$i number\n$+ number, then increment it\n$- number, then decrement it\n$n2, $n3 digits in number (01, 001)";
            toolTipProcess.SetToolTip(textCustom, tooltipText);
            toolTipProcess.SetToolTip(panel1, tooltipText);
        }

        private void updateHotkeyLabels()
        {
            updateHotkeyLabel(hotkeys.LowerCase,    labelLower);
            updateHotkeyLabel(hotkeys.UpperCase,    labelUpper);
            updateHotkeyLabel(hotkeys.PlainText,    labelPlain);
            updateHotkeyLabel(hotkeys.CapsLock,     labelCaps);
            updateHotkeyLabel(hotkeys.ProcessText,  labelProcess);
        }

        private void updateHotkeyLabel(Hotkey hotkey, Label label)
        {
            if (hotkey != null)
                label.Text = hotkey.text();
        }

        public void RegisterHotKeys()
        {
            if (!Properties.Settings.Default.RegisterHotkeys) return;

            hotkeysSet = true;

            string errorMessages = "";
            //trying to register hotkey

            RegisterHotKey(ghkUpper);
            RegisterHotKey(ghkLower);
            RegisterHotKey(ghkCapsLock);
            RegisterHotKey(ghkPlainText);
            RegisterHotKey(ghkProcessText);

            if (errorMessages.Length > 0)
            {
                writeMessage(errorMessages);
            }
        }

        private void RegisterHotKey (GlobalHotkey ghk)
        {
            if (ghk != null)
            {
                if (!ghk.Register())
                {
                    //writeMessage("register hotkey failed");                    
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReleaseHotkeys();
        }

        public void ReleaseHotkeys()
        {
            if (!hotkeysSet) return;

            ReleaseHotkey(ghkLower);
            ReleaseHotkey(ghkUpper);
            ReleaseHotkey(ghkCapsLock);
            ReleaseHotkey(ghkPlainText);
            ReleaseHotkey(ghkProcessText);
        }

        private void ReleaseHotkey(GlobalHotkey ghk)
        {
            if (ghk != null)
            {
                ghk.Unregister();
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

            if (ghkLower != null)
            {
                if (id == ghkLower.id)
                {
                    LowerCaseOnce();
                }
            }

            if (ghkUpper != null)
            {
                if (id == ghkUpper.id)
                {
                    UpperCaseOnce();
                }
            }

            if (ghkCapsLock != null)
            {
                if (id == ghkCapsLock.id)
                {
                    ToggleCapsLock();
                }
            }

            if (ghkPlainText != null)
            {
                if (id == ghkPlainText.id)
                {
                    PlainTextOnce();
                }
            }

            if (ghkProcessText != null)
            {
                if (id == ghkProcessText.id)
                {
                    ProcessTextVariables();
                }
            }
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

        private void ProcessTextVariables()
        {
            string customText = textCustom.Text;
            if (customText != null)
            {
                int padNumber = 1;
                string clip = Clipboard.GetText();
                if (customText.Contains("$n"))
                {
                    if (customText.Contains("$n2"))
                    {
                        customText = customText.Replace("$n2", "");
                        padNumber = 2;
                    }
                    if (customText.Contains("$n3"))
                    {
                        customText = customText.Replace("$n3", "");
                        padNumber = 3;
                    }
                }
                

                customText = customText.Replace("$d", DateTime.Now.ToShortDateString());
                customText = customText.Replace("$t", DateTime.Now.ToShortTimeString());
                customText = customText.Replace("$cp", clip);
                customText = customText.Replace("$cl", clip.ToLower());
                customText = customText.Replace("$cu", clip.ToUpper());
                customText = customText.Replace("$i", numericUpDown1.Value.ToString().PadLeft(padNumber,'0'));
                if (customText.Contains("$+"))
                {
                    customText = customText.Replace("$+", numericUpDown1.Value.ToString().PadLeft(padNumber, '0'));
                    if (numericUpDown1.Value < numericUpDown1.Maximum)
                        numericUpDown1.Value++;
                }
                if (customText.Contains("$-"))
                {
                    customText = customText.Replace("$-", numericUpDown1.Value.ToString().PadLeft(padNumber, '0'));
                    if (numericUpDown1.Value > numericUpDown1.Minimum)
                        numericUpDown1.Value--;
                }

                customText = customText.Replace("$1", textBox1.Text);
                customText = customText.Replace("$2", textBox2.Text);
                customText = customText.Replace("$3", textBox3.Text);

                Clipboard.SetText(customText);
            }
            
        }

        public void actionProcessText(object sender, EventArgs e)
        {
            ProcessTextVariables();
        }

        private void actionShowOptions(object sender, EventArgs e)
        {
            Options options = new Options(this);
            options.ShowDialog();
        }

        public void actionSave1(object sender = null, EventArgs e = null)
        {
            setTextBoxFromClipboard(1);
        }

        public void actionLoad1(object sender = null, EventArgs e = null)
        {
            setClipboardFromTextBox(1);
        }

        public void actionSave2(object sender = null, EventArgs e = null)
        {
            setTextBoxFromClipboard(2);
        }

        public void actionLoad2(object sender = null, EventArgs e = null)
        {
            setClipboardFromTextBox(2);
        }

        public void actionSave3(object sender = null, EventArgs e = null)
        {
            setTextBoxFromClipboard(3);
        }

        public void actionLoad3(object sender = null, EventArgs e = null)
        {
            setClipboardFromTextBox(3);
        }

        public void setTextBoxFromClipboard(int num)
        {
            TextBox textBox;
            textBox = SetTextBoxTarget(num);
            if (Clipboard.ContainsText())
                textBox.Text = Clipboard.GetText();
        }

        public void setClipboardFromTextBox(int num)//(TextBox textBox)
        {
            TextBox textBox;
            textBox = SetTextBoxTarget(num);
            if (textBox.Text != null)
            {
                if (textBox.Text.Length > 0)
                {
                    Clipboard.SetText(textBox.Text);
                }
                else
                {
                    Clipboard.Clear();
                }
            }

        }

        private TextBox SetTextBoxTarget(int num)
        {
            TextBox textBox;
            switch (num)
            {
                case 1:
                    {
                        textBox = textBox1;
                        break;
                    }
                case 2:
                    {
                        textBox = textBox2;
                        break;
                    }
                case 3:
                    {
                        textBox = textBox3;
                        break;
                    }
                default:
                    {
                        textBox = textBox1;
                        break;
                    }
            }

            return textBox;
        }

        public string getMemorySlot(int num)
        {
            TextBox textBox;
            textBox = SetTextBoxTarget(num);
            return textBox.Text;
        }
    }
}
