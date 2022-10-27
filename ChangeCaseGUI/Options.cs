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
        private HotkeyControls UpperInputs = new HotkeyControls();
        private HotkeyControls LowerInputs = new HotkeyControls();
        private HotkeyControls PlainInputs = new HotkeyControls();
        private HotkeyControls CapsInputs = new HotkeyControls();
        private HotkeyControls ProcessInputs = new HotkeyControls();
        //public List<HotkeyControls> hotkeyContols

        public Options(MainForm formParent)
        {
            InitializeComponent();
            mainForm = formParent;
            setupInputs();

            optionStartHidden.Checked = Properties.Settings.Default.StartHidden;
            optionStartToolbar.Checked = Properties.Settings.Default.StartToolbar;
            optionRegisterHotkeys.Checked = Properties.Settings.Default.RegisterHotkeys;
            optionSaveMemorySlots.Checked = Properties.Settings.Default.SaveMemorySlots;
            textMemorySlotFolder.Text = Properties.Settings.Default.MemorySlotFolder;


            fillInputs(UpperInputs, mainForm.hotkeys.UpperCase);
            fillInputs(LowerInputs, mainForm.hotkeys.LowerCase);
            fillInputs(PlainInputs, mainForm.hotkeys.PlainText);
            fillInputs(CapsInputs, mainForm.hotkeys.CapsLock);
            fillInputs(ProcessInputs, mainForm.hotkeys.ProcessText);


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

        private void fillInputs(HotkeyControls input, Hotkey hotkey)
        {
            if (hotkey != null)
            {
                input.hotkey = hotkey;
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

            ProcessInputs.text = textHotkeyProcess;
            ProcessInputs.Ctrl = checkProcessCtrl;
            ProcessInputs.Alt = checkProcessAlt;
            ProcessInputs.Shift = checkProcessShift;
            ProcessInputs.Win = checkProcessWin;

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

        private Hotkey readInputs(HotkeyControls input, Hotkey hotkey)
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
            Properties.Settings.Default.SaveMemorySlots = optionSaveMemorySlots.Checked;
            Properties.Settings.Default.MemorySlotFolder = textMemorySlotFolder.Text;

            mainForm.hotkeys.UpperCase = readInputs(UpperInputs, mainForm.hotkeys.UpperCase);
            mainForm.hotkeys.LowerCase = readInputs(LowerInputs, mainForm.hotkeys.LowerCase);
            mainForm.hotkeys.PlainText = readInputs(PlainInputs, mainForm.hotkeys.PlainText);
            mainForm.hotkeys.CapsLock = readInputs(CapsInputs, mainForm.hotkeys.CapsLock);
            mainForm.hotkeys.ProcessText = readInputs(ProcessInputs, mainForm.hotkeys.ProcessText);


            Properties.Settings.Default.hkUpper = mainForm.hotkeys.UpperCase;
            Properties.Settings.Default.hkLower = mainForm.hotkeys.LowerCase;
            Properties.Settings.Default.hkPlain = mainForm.hotkeys.PlainText;
            Properties.Settings.Default.hkCapsLock = mainForm.hotkeys.CapsLock;
            Properties.Settings.Default.hkProcessText = mainForm.hotkeys.ProcessText;


            Properties.Settings.Default.Save();
        }


    }
    public class HotkeyControls
    {
        public TextBox text;
        public CheckBox Ctrl;
        public CheckBox Alt;
        public CheckBox Shift;
        public CheckBox Win;
        public Hotkey hotkey;
    }
}
