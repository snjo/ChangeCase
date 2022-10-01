using Hotkeys;
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
    public partial class Options : Form
    {
        public MainForm mainForm;
        private hotkeyInputs UpperInputs = new hotkeyInputs();
        private hotkeyInputs LowerInputs = new hotkeyInputs();
        private hotkeyInputs PlainInputs = new hotkeyInputs();
        private hotkeyInputs CapsInputs = new hotkeyInputs();

        public Options(MainForm formParent)
        {
            InitializeComponent();
            mainForm = formParent;
            setupInputs();

            optionStartHidden.Checked = Properties.Settings.Default.StartHidden;
            optionStartToolbar.Checked = Properties.Settings.Default.StartToolbar;
            optionRegisterHotkeys.Checked = Properties.Settings.Default.RegisterHotkeys;


            fillInputs(UpperInputs, mainForm.hotkeys.UpperCase);
            fillInputs(LowerInputs, mainForm.hotkeys.LowerCase);
            fillInputs(PlainInputs, mainForm.hotkeys.PlainText);
            fillInputs(CapsInputs, mainForm.hotkeys.CapsLock);


            /*
            if (mainForm.hotkeys.UpperCase != null)
            {
                textHotkeyUpper.Text = mainForm.hotkeys.UpperCase.key.ToString();
                checkUpperCtrl.Checked = mainForm.hotkeys.UpperCase.Ctrl;
                checkUpperAlt.Checked = mainForm.hotkeys.UpperCase.Alt;
                checkUpperShift.Checked = mainForm.hotkeys.UpperCase.Shift;
                checkUpperWin.Checked = mainForm.hotkeys.UpperCase.Win;
            }

            if (mainForm.hotkeys.LowerCase != null)
            {
                textHotkeyLower.Text = mainForm.hotkeys.LowerCase.key.ToString();
                checkLowerCtrl.Checked = mainForm.hotkeys.LowerCase.Ctrl;
                checkLowerAlt.Checked = mainForm.hotkeys.LowerCase.Alt;
                checkLowerShift.Checked = mainForm.hotkeys.LowerCase.Shift;
                checkLowerWin.Checked = mainForm.hotkeys.LowerCase.Win;
            }*/
        }

        private void fillInputs(hotkeyInputs input, Hotkey hotkey)
        {
            if (hotkey != null)
            {
                input.text.Text = hotkey.key.ToString();
                input.Ctrl.Checked = hotkey.Ctrl;
                input.Alt.Checked = hotkey.Alt;
                input.Shift.Checked = hotkey.Shift;
                input.Win.Checked = hotkey.Win;
            }
        }

        private void setupInputs()
        {
            UpperInputs.text = textHotkeyUpper;
            UpperInputs.Ctrl = checkUpperCtrl;
            UpperInputs.Alt = checkUpperAlt;
            UpperInputs.Shift = checkUpperShift;
            UpperInputs.Win = checkUpperWin;

            LowerInputs.text = textHotkeyLower;
            LowerInputs.Ctrl = checkLowerCtrl;
            LowerInputs.Alt = checkLowerAlt;
            LowerInputs.Shift = checkLowerShift;
            LowerInputs.Win = checkLowerWin;

            PlainInputs.text = textHotkeyPlain;
            PlainInputs.Ctrl = checkPlainCtrl;
            PlainInputs.Alt = checkPlainAlt;
            PlainInputs.Shift = checkPlainShift;
            PlainInputs.Win = checkPlainWin;

            CapsInputs.text = textHotkeyCaps;
            CapsInputs.Ctrl = checkCapsCtrl;
            CapsInputs.Alt = checkCapsAlt;
            CapsInputs.Shift = checkCapsShift;
            CapsInputs.Win = checkCapsWin;


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveSettings();
            //mainForm.ReleaseHotkeys();
            //mainForm.RegisterHotKeys();
            Close();
        }

        private Hotkey readInputs(hotkeyInputs input, Hotkey hotkey)
        {
            if (hotkey == null)
                hotkey = new Hotkeys.Hotkey();
            if (input.text.Text.Length > 0)
                hotkey.key = input.text.Text.ToCharArray()[0];
            else
                hotkey.key = new char();
            hotkey.Ctrl = input.Ctrl.Checked;
            hotkey.Alt = input.Alt.Checked;
            hotkey.Shift = input.Shift.Checked;
            hotkey.Win = input.Win.Checked;
            return hotkey;
        }

        private void saveSettings()
        {
            Properties.Settings.Default.StartHidden = optionStartHidden.Checked;
            Properties.Settings.Default.StartToolbar = optionStartToolbar.Checked;
            Properties.Settings.Default.RegisterHotkeys = optionRegisterHotkeys.Checked;

            mainForm.hotkeys.UpperCase = readInputs(UpperInputs, mainForm.hotkeys.UpperCase);
            mainForm.hotkeys.LowerCase = readInputs(LowerInputs, mainForm.hotkeys.LowerCase);
            mainForm.hotkeys.PlainText = readInputs(PlainInputs, mainForm.hotkeys.PlainText);
            mainForm.hotkeys.CapsLock = readInputs(CapsInputs, mainForm.hotkeys.CapsLock);

            /*
            if (mainForm.hotkeys.UpperCase == null)
                mainForm.hotkeys.UpperCase = new Hotkeys.Hotkey();
            if (textHotkeyUpper.Text.Length > 0)
                mainForm.hotkeys.UpperCase.key = textHotkeyUpper.Text.ToCharArray()[0];
            mainForm.hotkeys.UpperCase.Ctrl = checkUpperCtrl.Checked;
            mainForm.hotkeys.UpperCase.Alt = checkUpperAlt.Checked;
            mainForm.hotkeys.UpperCase.Shift = checkUpperShift.Checked;
            mainForm.hotkeys.UpperCase.Win = checkUpperWin.Checked;

            if (mainForm.hotkeys.LowerCase == null)
                mainForm.hotkeys.LowerCase = new Hotkeys.Hotkey();
            if (textHotkeyLower.Text.Length > 0)
                mainForm.hotkeys.LowerCase.key = textHotkeyLower.Text.ToCharArray()[0];
            mainForm.hotkeys.LowerCase.Ctrl = checkLowerCtrl.Checked;
            mainForm.hotkeys.LowerCase.Alt = checkLowerAlt.Checked;
            mainForm.hotkeys.LowerCase.Shift = checkLowerShift.Checked;
            mainForm.hotkeys.LowerCase.Win = checkLowerWin.Checked;
            */

            //Properties.Settings.Default.HotkeyLower = Properties.Settings.Default.HotkeyLower;

            Properties.Settings.Default.hkUpper = mainForm.hotkeys.UpperCase;
            Properties.Settings.Default.hkLower = mainForm.hotkeys.LowerCase;
            Properties.Settings.Default.hkPlain = mainForm.hotkeys.PlainText;
            Properties.Settings.Default.hkCapsLock = mainForm.hotkeys.CapsLock;

            //Properties.Settings.Default.HotkeyPlain = Properties.Settings.Default.HotkeyPlain;
            //Properties.Settings.Default.HotkeyCapsLock = Properties.Settings.Default.HotkeyCapsLock;

            Properties.Settings.Default.Save();
        }

        private class hotkeyInputs
        {
            public TextBox text;
            public CheckBox Ctrl;
            public CheckBox Alt;
            public CheckBox Shift;
            public CheckBox Win;
        }
    }
}
