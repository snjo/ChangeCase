namespace ChangeCaseGUI
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.optionStartHidden = new System.Windows.Forms.CheckBox();
            this.optionStartToolbar = new System.Windows.Forms.CheckBox();
            this.optionRegisterHotkeys = new System.Windows.Forms.CheckBox();
            this.textHotkeyUpper = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textHotkeyLower = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textHotkeyPlain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textHotkeyCaps = new System.Windows.Forms.TextBox();
            this.checkUpperCtrl = new System.Windows.Forms.CheckBox();
            this.checkUpperAlt = new System.Windows.Forms.CheckBox();
            this.checkUpperShift = new System.Windows.Forms.CheckBox();
            this.checkUpperWin = new System.Windows.Forms.CheckBox();
            this.checkLowerWin = new System.Windows.Forms.CheckBox();
            this.checkLowerShift = new System.Windows.Forms.CheckBox();
            this.checkLowerAlt = new System.Windows.Forms.CheckBox();
            this.checkLowerCtrl = new System.Windows.Forms.CheckBox();
            this.checkPlainWin = new System.Windows.Forms.CheckBox();
            this.checkPlainShift = new System.Windows.Forms.CheckBox();
            this.checkPlainAlt = new System.Windows.Forms.CheckBox();
            this.checkPlainCtrl = new System.Windows.Forms.CheckBox();
            this.checkCapsWin = new System.Windows.Forms.CheckBox();
            this.checkCapsShift = new System.Windows.Forms.CheckBox();
            this.checkCapsAlt = new System.Windows.Forms.CheckBox();
            this.checkCapsCtrl = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(285, 223);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(204, 223);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // optionStartHidden
            // 
            this.optionStartHidden.AutoSize = true;
            this.optionStartHidden.Location = new System.Drawing.Point(12, 12);
            this.optionStartHidden.Name = "optionStartHidden";
            this.optionStartHidden.Size = new System.Drawing.Size(85, 17);
            this.optionStartHidden.TabIndex = 2;
            this.optionStartHidden.Text = "Start Hidden";
            this.optionStartHidden.UseVisualStyleBackColor = true;
            // 
            // optionStartToolbar
            // 
            this.optionStartToolbar.AutoSize = true;
            this.optionStartToolbar.Location = new System.Drawing.Point(12, 35);
            this.optionStartToolbar.Name = "optionStartToolbar";
            this.optionStartToolbar.Size = new System.Drawing.Size(109, 17);
            this.optionStartToolbar.TabIndex = 3;
            this.optionStartToolbar.Text = "Start with Toolbar";
            this.optionStartToolbar.UseVisualStyleBackColor = true;
            // 
            // optionRegisterHotkeys
            // 
            this.optionRegisterHotkeys.AutoSize = true;
            this.optionRegisterHotkeys.Location = new System.Drawing.Point(12, 58);
            this.optionRegisterHotkeys.Name = "optionRegisterHotkeys";
            this.optionRegisterHotkeys.Size = new System.Drawing.Size(107, 17);
            this.optionRegisterHotkeys.TabIndex = 4;
            this.optionRegisterHotkeys.Text = "Register Hotkeys";
            this.optionRegisterHotkeys.UseVisualStyleBackColor = true;
            // 
            // textHotkeyUpper
            // 
            this.textHotkeyUpper.Location = new System.Drawing.Point(114, 81);
            this.textHotkeyUpper.MaxLength = 1;
            this.textHotkeyUpper.Name = "textHotkeyUpper";
            this.textHotkeyUpper.Size = new System.Drawing.Size(50, 20);
            this.textHotkeyUpper.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hotkey Upper Case";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hotkey Lower Case";
            // 
            // textHotkeyLower
            // 
            this.textHotkeyLower.Location = new System.Drawing.Point(114, 107);
            this.textHotkeyLower.Name = "textHotkeyLower";
            this.textHotkeyLower.Size = new System.Drawing.Size(50, 20);
            this.textHotkeyLower.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hotkey Plain Text";
            // 
            // textHotkeyPlain
            // 
            this.textHotkeyPlain.Location = new System.Drawing.Point(114, 133);
            this.textHotkeyPlain.Name = "textHotkeyPlain";
            this.textHotkeyPlain.Size = new System.Drawing.Size(50, 20);
            this.textHotkeyPlain.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hotkey Caps Lock";
            // 
            // textHotkeyCaps
            // 
            this.textHotkeyCaps.Location = new System.Drawing.Point(114, 159);
            this.textHotkeyCaps.Name = "textHotkeyCaps";
            this.textHotkeyCaps.Size = new System.Drawing.Size(50, 20);
            this.textHotkeyCaps.TabIndex = 11;
            // 
            // checkUpperCtrl
            // 
            this.checkUpperCtrl.AutoSize = true;
            this.checkUpperCtrl.Location = new System.Drawing.Point(173, 85);
            this.checkUpperCtrl.Name = "checkUpperCtrl";
            this.checkUpperCtrl.Size = new System.Drawing.Size(41, 17);
            this.checkUpperCtrl.TabIndex = 13;
            this.checkUpperCtrl.Text = "Ctrl";
            this.checkUpperCtrl.UseVisualStyleBackColor = true;
            // 
            // checkUpperAlt
            // 
            this.checkUpperAlt.AutoSize = true;
            this.checkUpperAlt.Location = new System.Drawing.Point(217, 85);
            this.checkUpperAlt.Name = "checkUpperAlt";
            this.checkUpperAlt.Size = new System.Drawing.Size(38, 17);
            this.checkUpperAlt.TabIndex = 14;
            this.checkUpperAlt.Text = "Alt";
            this.checkUpperAlt.UseVisualStyleBackColor = true;
            // 
            // checkUpperShift
            // 
            this.checkUpperShift.AutoSize = true;
            this.checkUpperShift.Location = new System.Drawing.Point(261, 85);
            this.checkUpperShift.Name = "checkUpperShift";
            this.checkUpperShift.Size = new System.Drawing.Size(47, 17);
            this.checkUpperShift.TabIndex = 15;
            this.checkUpperShift.Text = "Shift";
            this.checkUpperShift.UseVisualStyleBackColor = true;
            // 
            // checkUpperWin
            // 
            this.checkUpperWin.AutoSize = true;
            this.checkUpperWin.Location = new System.Drawing.Point(309, 85);
            this.checkUpperWin.Name = "checkUpperWin";
            this.checkUpperWin.Size = new System.Drawing.Size(45, 17);
            this.checkUpperWin.TabIndex = 16;
            this.checkUpperWin.Text = "Win";
            this.checkUpperWin.UseVisualStyleBackColor = true;
            // 
            // checkLowerWin
            // 
            this.checkLowerWin.AutoSize = true;
            this.checkLowerWin.Location = new System.Drawing.Point(309, 109);
            this.checkLowerWin.Name = "checkLowerWin";
            this.checkLowerWin.Size = new System.Drawing.Size(45, 17);
            this.checkLowerWin.TabIndex = 20;
            this.checkLowerWin.Text = "Win";
            this.checkLowerWin.UseVisualStyleBackColor = true;
            // 
            // checkLowerShift
            // 
            this.checkLowerShift.AutoSize = true;
            this.checkLowerShift.Location = new System.Drawing.Point(261, 109);
            this.checkLowerShift.Name = "checkLowerShift";
            this.checkLowerShift.Size = new System.Drawing.Size(47, 17);
            this.checkLowerShift.TabIndex = 19;
            this.checkLowerShift.Text = "Shift";
            this.checkLowerShift.UseVisualStyleBackColor = true;
            // 
            // checkLowerAlt
            // 
            this.checkLowerAlt.AutoSize = true;
            this.checkLowerAlt.Location = new System.Drawing.Point(217, 109);
            this.checkLowerAlt.Name = "checkLowerAlt";
            this.checkLowerAlt.Size = new System.Drawing.Size(38, 17);
            this.checkLowerAlt.TabIndex = 18;
            this.checkLowerAlt.Text = "Alt";
            this.checkLowerAlt.UseVisualStyleBackColor = true;
            // 
            // checkLowerCtrl
            // 
            this.checkLowerCtrl.AutoSize = true;
            this.checkLowerCtrl.Location = new System.Drawing.Point(173, 109);
            this.checkLowerCtrl.Name = "checkLowerCtrl";
            this.checkLowerCtrl.Size = new System.Drawing.Size(41, 17);
            this.checkLowerCtrl.TabIndex = 17;
            this.checkLowerCtrl.Text = "Ctrl";
            this.checkLowerCtrl.UseVisualStyleBackColor = true;
            // 
            // checkPlainWin
            // 
            this.checkPlainWin.AutoSize = true;
            this.checkPlainWin.Location = new System.Drawing.Point(309, 136);
            this.checkPlainWin.Name = "checkPlainWin";
            this.checkPlainWin.Size = new System.Drawing.Size(45, 17);
            this.checkPlainWin.TabIndex = 24;
            this.checkPlainWin.Text = "Win";
            this.checkPlainWin.UseVisualStyleBackColor = true;
            // 
            // checkPlainShift
            // 
            this.checkPlainShift.AutoSize = true;
            this.checkPlainShift.Location = new System.Drawing.Point(261, 136);
            this.checkPlainShift.Name = "checkPlainShift";
            this.checkPlainShift.Size = new System.Drawing.Size(47, 17);
            this.checkPlainShift.TabIndex = 23;
            this.checkPlainShift.Text = "Shift";
            this.checkPlainShift.UseVisualStyleBackColor = true;
            // 
            // checkPlainAlt
            // 
            this.checkPlainAlt.AutoSize = true;
            this.checkPlainAlt.Location = new System.Drawing.Point(217, 136);
            this.checkPlainAlt.Name = "checkPlainAlt";
            this.checkPlainAlt.Size = new System.Drawing.Size(38, 17);
            this.checkPlainAlt.TabIndex = 22;
            this.checkPlainAlt.Text = "Alt";
            this.checkPlainAlt.UseVisualStyleBackColor = true;
            // 
            // checkPlainCtrl
            // 
            this.checkPlainCtrl.AutoSize = true;
            this.checkPlainCtrl.Location = new System.Drawing.Point(173, 136);
            this.checkPlainCtrl.Name = "checkPlainCtrl";
            this.checkPlainCtrl.Size = new System.Drawing.Size(41, 17);
            this.checkPlainCtrl.TabIndex = 21;
            this.checkPlainCtrl.Text = "Ctrl";
            this.checkPlainCtrl.UseVisualStyleBackColor = true;
            // 
            // checkCapsWin
            // 
            this.checkCapsWin.AutoSize = true;
            this.checkCapsWin.Location = new System.Drawing.Point(309, 161);
            this.checkCapsWin.Name = "checkCapsWin";
            this.checkCapsWin.Size = new System.Drawing.Size(45, 17);
            this.checkCapsWin.TabIndex = 28;
            this.checkCapsWin.Text = "Win";
            this.checkCapsWin.UseVisualStyleBackColor = true;
            // 
            // checkCapsShift
            // 
            this.checkCapsShift.AutoSize = true;
            this.checkCapsShift.Location = new System.Drawing.Point(261, 161);
            this.checkCapsShift.Name = "checkCapsShift";
            this.checkCapsShift.Size = new System.Drawing.Size(47, 17);
            this.checkCapsShift.TabIndex = 27;
            this.checkCapsShift.Text = "Shift";
            this.checkCapsShift.UseVisualStyleBackColor = true;
            // 
            // checkCapsAlt
            // 
            this.checkCapsAlt.AutoSize = true;
            this.checkCapsAlt.Location = new System.Drawing.Point(217, 161);
            this.checkCapsAlt.Name = "checkCapsAlt";
            this.checkCapsAlt.Size = new System.Drawing.Size(38, 17);
            this.checkCapsAlt.TabIndex = 26;
            this.checkCapsAlt.Text = "Alt";
            this.checkCapsAlt.UseVisualStyleBackColor = true;
            // 
            // checkCapsCtrl
            // 
            this.checkCapsCtrl.AutoSize = true;
            this.checkCapsCtrl.Location = new System.Drawing.Point(173, 161);
            this.checkCapsCtrl.Name = "checkCapsCtrl";
            this.checkCapsCtrl.Size = new System.Drawing.Size(41, 17);
            this.checkCapsCtrl.TabIndex = 25;
            this.checkCapsCtrl.Text = "Ctrl";
            this.checkCapsCtrl.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Restart the Program to register new hotkeys";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 258);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkCapsWin);
            this.Controls.Add(this.checkCapsShift);
            this.Controls.Add(this.checkCapsAlt);
            this.Controls.Add(this.checkCapsCtrl);
            this.Controls.Add(this.checkPlainWin);
            this.Controls.Add(this.checkPlainShift);
            this.Controls.Add(this.checkPlainAlt);
            this.Controls.Add(this.checkPlainCtrl);
            this.Controls.Add(this.checkLowerWin);
            this.Controls.Add(this.checkLowerShift);
            this.Controls.Add(this.checkLowerAlt);
            this.Controls.Add(this.checkLowerCtrl);
            this.Controls.Add(this.checkUpperWin);
            this.Controls.Add(this.checkUpperShift);
            this.Controls.Add(this.checkUpperAlt);
            this.Controls.Add(this.checkUpperCtrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textHotkeyCaps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textHotkeyPlain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textHotkeyLower);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textHotkeyUpper);
            this.Controls.Add(this.optionRegisterHotkeys);
            this.Controls.Add(this.optionStartToolbar);
            this.Controls.Add(this.optionStartHidden);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox optionStartHidden;
        private System.Windows.Forms.CheckBox optionStartToolbar;
        private System.Windows.Forms.CheckBox optionRegisterHotkeys;
        private System.Windows.Forms.TextBox textHotkeyUpper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textHotkeyLower;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textHotkeyPlain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textHotkeyCaps;
        private System.Windows.Forms.CheckBox checkUpperCtrl;
        private System.Windows.Forms.CheckBox checkUpperAlt;
        private System.Windows.Forms.CheckBox checkUpperShift;
        private System.Windows.Forms.CheckBox checkUpperWin;
        private System.Windows.Forms.CheckBox checkLowerWin;
        private System.Windows.Forms.CheckBox checkLowerShift;
        private System.Windows.Forms.CheckBox checkLowerAlt;
        private System.Windows.Forms.CheckBox checkLowerCtrl;
        private System.Windows.Forms.CheckBox checkPlainWin;
        private System.Windows.Forms.CheckBox checkPlainShift;
        private System.Windows.Forms.CheckBox checkPlainAlt;
        private System.Windows.Forms.CheckBox checkPlainCtrl;
        private System.Windows.Forms.CheckBox checkCapsWin;
        private System.Windows.Forms.CheckBox checkCapsShift;
        private System.Windows.Forms.CheckBox checkCapsAlt;
        private System.Windows.Forms.CheckBox checkCapsCtrl;
        private System.Windows.Forms.Label label5;
    }
}