﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public Form1()
        {
            InitializeComponent();

            timer1.Start();
            ghkUpper = new Hotkeys.GlobalHotkey(Constants.ALT + Constants.SHIFT, Keys.U, this);
            ghkLower = new Hotkeys.GlobalHotkey(Constants.ALT + Constants.SHIFT, Keys.L, this);
            //ghkCapsLock = new Hotkeys.GlobalHotkey(Constants.CTRL + Constants.ALT, Keys.C, this);
            ghkCapsLock = new Hotkeys.GlobalHotkey(Constants.CTRL + Constants.SHIFT, Keys.Back, this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //trying to register hotkey
            if (!ghkUpper.Register())
                writeMessage("Hotkey Upper not registered");
            if (!ghkLower.Register())
                writeMessage("Hotkey Lower not registered");
            if (!ghkCapsLock.Register())
                writeMessage("Hotkey CapsLock not registered");
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
            UpdateCapsLock();
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

            if (id == ghkCapsLock.id)
            {
                ToggleCapsLock();
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

        private void UpdateCapsLock()
        {
            checkBoxCapsLock.Checked = Control.IsKeyLocked(System.Windows.Forms.Keys.CapsLock);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            UpdateCapsLock();
        }

        private void checkBoxCapsLock_Click(object sender, EventArgs e)
        {
            ToggleCapsLock();
        }
    }
}
