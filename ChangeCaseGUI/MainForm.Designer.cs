namespace ChangeCaseGUI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radioLower = new System.Windows.Forms.RadioButton();
            this.radioUpper = new System.Windows.Forms.RadioButton();
            this.radioOff = new System.Windows.Forms.RadioButton();
            this.labelUpper = new System.Windows.Forms.Label();
            this.labelLower = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCaps = new System.Windows.Forms.Label();
            this.checkBoxCapsLock = new System.Windows.Forms.CheckBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.systrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.capsLockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPPERCassClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowerCaseClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonUpper = new System.Windows.Forms.Button();
            this.buttonLower = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelPlain = new System.Windows.Forms.Label();
            this.radioPlain = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLoad3 = new System.Windows.Forms.Button();
            this.buttonSave3 = new System.Windows.Forms.Button();
            this.buttonLoad2 = new System.Windows.Forms.Button();
            this.buttonSave2 = new System.Windows.Forms.Button();
            this.buttonLoad1 = new System.Windows.Forms.Button();
            this.buttonSave1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelProcess = new System.Windows.Forms.Label();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textCustom = new System.Windows.Forms.TextBox();
            this.buttonToolbar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTipProcess = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radioLower
            // 
            this.radioLower.AutoSize = true;
            this.radioLower.Location = new System.Drawing.Point(12, 54);
            this.radioLower.Name = "radioLower";
            this.radioLower.Size = new System.Drawing.Size(76, 17);
            this.radioLower.TabIndex = 2;
            this.radioLower.Text = "lower case";
            this.radioLower.UseVisualStyleBackColor = true;
            // 
            // radioUpper
            // 
            this.radioUpper.AutoSize = true;
            this.radioUpper.Location = new System.Drawing.Point(12, 78);
            this.radioUpper.Name = "radioUpper";
            this.radioUpper.Size = new System.Drawing.Size(93, 17);
            this.radioUpper.TabIndex = 3;
            this.radioUpper.Text = "UPPER CASE";
            this.radioUpper.UseVisualStyleBackColor = true;
            // 
            // radioOff
            // 
            this.radioOff.AutoSize = true;
            this.radioOff.Checked = true;
            this.radioOff.Location = new System.Drawing.Point(12, 31);
            this.radioOff.Name = "radioOff";
            this.radioOff.Size = new System.Drawing.Size(37, 17);
            this.radioOff.TabIndex = 1;
            this.radioOff.TabStop = true;
            this.radioOff.Text = "off";
            this.radioOff.UseVisualStyleBackColor = true;
            // 
            // labelUpper
            // 
            this.labelUpper.AutoSize = true;
            this.labelUpper.Location = new System.Drawing.Point(180, 80);
            this.labelUpper.Name = "labelUpper";
            this.labelUpper.Size = new System.Drawing.Size(54, 13);
            this.labelUpper.TabIndex = 5;
            this.labelUpper.Text = "no hotkey";
            // 
            // labelLower
            // 
            this.labelLower.AutoSize = true;
            this.labelLower.Location = new System.Drawing.Point(180, 56);
            this.labelLower.Name = "labelLower";
            this.labelLower.Size = new System.Drawing.Size(54, 13);
            this.labelLower.TabIndex = 6;
            this.labelLower.Text = "no hotkey";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "On demand:";
            // 
            // labelCaps
            // 
            this.labelCaps.AutoSize = true;
            this.labelCaps.Location = new System.Drawing.Point(180, 131);
            this.labelCaps.Name = "labelCaps";
            this.labelCaps.Size = new System.Drawing.Size(54, 13);
            this.labelCaps.TabIndex = 8;
            this.labelCaps.Text = "no hotkey";
            // 
            // checkBoxCapsLock
            // 
            this.checkBoxCapsLock.AutoSize = true;
            this.checkBoxCapsLock.Location = new System.Drawing.Point(12, 131);
            this.checkBoxCapsLock.Name = "checkBoxCapsLock";
            this.checkBoxCapsLock.Size = new System.Drawing.Size(77, 17);
            this.checkBoxCapsLock.TabIndex = 9;
            this.checkBoxCapsLock.Text = "Caps Lock";
            this.checkBoxCapsLock.UseVisualStyleBackColor = true;
            this.checkBoxCapsLock.Click += new System.EventHandler(this.checkBoxCapsLock_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // systrayIcon
            // 
            this.systrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.systrayIcon.BalloonTipText = "Test text";
            this.systrayIcon.BalloonTipTitle = "Test title";
            this.systrayIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.systrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("systrayIcon.Icon")));
            this.systrayIcon.Text = "Case Converter - Caps Lock is ?";
            this.systrayIcon.Visible = true;
            this.systrayIcon.DoubleClick += new System.EventHandler(this.actionCapsLock);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.capsLockToolStripMenuItem,
            this.uPPERCassClipboardToolStripMenuItem,
            this.lowerCaseClipboardToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 158);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItem2.Text = "Hide";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.actionHideFromTaskbar);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItem1.Text = "Show";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.actionShowWindow);
            // 
            // capsLockToolStripMenuItem
            // 
            this.capsLockToolStripMenuItem.Name = "capsLockToolStripMenuItem";
            this.capsLockToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.capsLockToolStripMenuItem.Text = "Caps Lock";
            this.capsLockToolStripMenuItem.Click += new System.EventHandler(this.actionCapsLock);
            // 
            // uPPERCassClipboardToolStripMenuItem
            // 
            this.uPPERCassClipboardToolStripMenuItem.Name = "uPPERCassClipboardToolStripMenuItem";
            this.uPPERCassClipboardToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.uPPERCassClipboardToolStripMenuItem.Text = "UPPER case Clipboard";
            this.uPPERCassClipboardToolStripMenuItem.Click += new System.EventHandler(this.actionUpperCaseOnce);
            // 
            // lowerCaseClipboardToolStripMenuItem
            // 
            this.lowerCaseClipboardToolStripMenuItem.Name = "lowerCaseClipboardToolStripMenuItem";
            this.lowerCaseClipboardToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.lowerCaseClipboardToolStripMenuItem.Text = "lower case Clipboard";
            this.lowerCaseClipboardToolStripMenuItem.Click += new System.EventHandler(this.actionLowerCaseOnce);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItem3.Text = "Plain text Clipboard";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.actionPlainTextOnce);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.actionExit);
            // 
            // buttonUpper
            // 
            this.buttonUpper.Location = new System.Drawing.Point(119, 75);
            this.buttonUpper.Name = "buttonUpper";
            this.buttonUpper.Size = new System.Drawing.Size(55, 23);
            this.buttonUpper.TabIndex = 11;
            this.buttonUpper.Text = "UPPER";
            this.buttonUpper.UseVisualStyleBackColor = true;
            this.buttonUpper.Click += new System.EventHandler(this.actionUpperCaseOnce);
            // 
            // buttonLower
            // 
            this.buttonLower.Location = new System.Drawing.Point(119, 51);
            this.buttonLower.Name = "buttonLower";
            this.buttonLower.Size = new System.Drawing.Size(55, 23);
            this.buttonLower.TabIndex = 10;
            this.buttonLower.Text = "lower";
            this.buttonLower.UseVisualStyleBackColor = true;
            this.buttonLower.Click += new System.EventHandler(this.actionLowerCaseOnce);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Auto:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            // 
            // labelPlain
            // 
            this.labelPlain.AutoSize = true;
            this.labelPlain.Location = new System.Drawing.Point(180, 106);
            this.labelPlain.Name = "labelPlain";
            this.labelPlain.Size = new System.Drawing.Size(54, 13);
            this.labelPlain.TabIndex = 14;
            this.labelPlain.Text = "no hotkey";
            // 
            // radioPlain
            // 
            this.radioPlain.AutoSize = true;
            this.radioPlain.Location = new System.Drawing.Point(12, 104);
            this.radioPlain.Name = "radioPlain";
            this.radioPlain.Size = new System.Drawing.Size(72, 17);
            this.radioPlain.TabIndex = 4;
            this.radioPlain.Text = "Plain Text";
            this.radioPlain.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Plain";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.actionPlainTextOnce);
            // 
            // buttonOptions
            // 
            this.buttonOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOptions.Location = new System.Drawing.Point(213, 4);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(23, 23);
            this.buttonOptions.TabIndex = 16;
            this.buttonOptions.Text = "⚙️";
            this.buttonOptions.UseVisualStyleBackColor = true;
            this.buttonOptions.Click += new System.EventHandler(this.actionShowOptions);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonLoad3);
            this.panel1.Controls.Add(this.buttonSave3);
            this.panel1.Controls.Add(this.buttonLoad2);
            this.panel1.Controls.Add(this.buttonSave2);
            this.panel1.Controls.Add(this.buttonLoad1);
            this.panel1.Controls.Add(this.buttonSave1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.labelProcess);
            this.panel1.Controls.Add(this.buttonProcess);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textCustom);
            this.panel1.Controls.Add(this.buttonToolbar);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 245);
            this.panel1.TabIndex = 17;
            // 
            // buttonLoad3
            // 
            this.buttonLoad3.Location = new System.Drawing.Point(209, 214);
            this.buttonLoad3.Name = "buttonLoad3";
            this.buttonLoad3.Size = new System.Drawing.Size(31, 23);
            this.buttonLoad3.TabIndex = 33;
            this.buttonLoad3.Text = "L";
            this.buttonLoad3.UseVisualStyleBackColor = true;
            this.buttonLoad3.Click += new System.EventHandler(this.actionLoad3);
            // 
            // buttonSave3
            // 
            this.buttonSave3.Location = new System.Drawing.Point(176, 214);
            this.buttonSave3.Name = "buttonSave3";
            this.buttonSave3.Size = new System.Drawing.Size(31, 23);
            this.buttonSave3.TabIndex = 32;
            this.buttonSave3.Text = "S";
            this.buttonSave3.UseVisualStyleBackColor = true;
            this.buttonSave3.Click += new System.EventHandler(this.actionSave3);
            // 
            // buttonLoad2
            // 
            this.buttonLoad2.Location = new System.Drawing.Point(209, 188);
            this.buttonLoad2.Name = "buttonLoad2";
            this.buttonLoad2.Size = new System.Drawing.Size(31, 23);
            this.buttonLoad2.TabIndex = 31;
            this.buttonLoad2.Text = "L";
            this.buttonLoad2.UseVisualStyleBackColor = true;
            this.buttonLoad2.Click += new System.EventHandler(this.actionLoad2);
            // 
            // buttonSave2
            // 
            this.buttonSave2.Location = new System.Drawing.Point(176, 188);
            this.buttonSave2.Name = "buttonSave2";
            this.buttonSave2.Size = new System.Drawing.Size(31, 23);
            this.buttonSave2.TabIndex = 30;
            this.buttonSave2.Text = "S";
            this.buttonSave2.UseVisualStyleBackColor = true;
            this.buttonSave2.Click += new System.EventHandler(this.actionSave2);
            // 
            // buttonLoad1
            // 
            this.buttonLoad1.Location = new System.Drawing.Point(209, 162);
            this.buttonLoad1.Name = "buttonLoad1";
            this.buttonLoad1.Size = new System.Drawing.Size(31, 23);
            this.buttonLoad1.TabIndex = 29;
            this.buttonLoad1.Text = "L";
            this.buttonLoad1.UseVisualStyleBackColor = true;
            this.buttonLoad1.Click += new System.EventHandler(this.actionLoad1);
            // 
            // buttonSave1
            // 
            this.buttonSave1.Location = new System.Drawing.Point(176, 162);
            this.buttonSave1.Name = "buttonSave1";
            this.buttonSave1.Size = new System.Drawing.Size(31, 23);
            this.buttonSave1.TabIndex = 28;
            this.buttonSave1.Text = "S";
            this.buttonSave1.UseVisualStyleBackColor = true;
            this.buttonSave1.Click += new System.EventHandler(this.actionSave1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 216);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(162, 20);
            this.textBox3.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 190);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(162, 20);
            this.textBox2.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 164);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 25;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(118, 44);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(37, 20);
            this.numericUpDown1.TabIndex = 24;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Location = new System.Drawing.Point(14, 47);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(54, 13);
            this.labelProcess.TabIndex = 23;
            this.labelProcess.Text = "no hotkey";
            // 
            // buttonProcess
            // 
            this.buttonProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProcess.Location = new System.Drawing.Point(161, 42);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(75, 23);
            this.buttonProcess.TabIndex = 22;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.actionProcessText);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 2);
            this.label2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 2);
            this.label1.TabIndex = 20;
            // 
            // textCustom
            // 
            this.textCustom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCustom.Location = new System.Drawing.Point(12, 69);
            this.textCustom.Multiline = true;
            this.textCustom.Name = "textCustom";
            this.textCustom.Size = new System.Drawing.Size(227, 89);
            this.textCustom.TabIndex = 18;
            this.textCustom.Text = "$n3$+ $d $t - $cp";
            // 
            // buttonToolbar
            // 
            this.buttonToolbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToolbar.Location = new System.Drawing.Point(180, 11);
            this.buttonToolbar.Name = "buttonToolbar";
            this.buttonToolbar.Size = new System.Drawing.Size(56, 23);
            this.buttonToolbar.TabIndex = 17;
            this.buttonToolbar.Text = "toolbar";
            this.buttonToolbar.UseVisualStyleBackColor = true;
            this.buttonToolbar.Click += new System.EventHandler(this.actionShowToolbar);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(118, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "hide";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.actionHideFromTaskbar);
            // 
            // toolTipProcess
            // 
            this.toolTipProcess.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipProcess.ToolTipTitle = "Variables";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 398);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonOptions);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioPlain);
            this.Controls.Add(this.labelPlain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonLower);
            this.Controls.Add(this.buttonUpper);
            this.Controls.Add(this.checkBoxCapsLock);
            this.Controls.Add(this.labelCaps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLower);
            this.Controls.Add(this.labelUpper);
            this.Controls.Add(this.radioOff);
            this.Controls.Add(this.radioUpper);
            this.Controls.Add(this.radioLower);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ChangeCase";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radioLower;
        private System.Windows.Forms.RadioButton radioUpper;
        private System.Windows.Forms.RadioButton radioOff;
        private System.Windows.Forms.Label labelUpper;
        private System.Windows.Forms.Label labelLower;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCaps;
        private System.Windows.Forms.CheckBox checkBoxCapsLock;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NotifyIcon systrayIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem capsLockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPPERCassClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowerCaseClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button buttonUpper;
        private System.Windows.Forms.Button buttonLower;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label labelPlain;
        private System.Windows.Forms.RadioButton radioPlain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCustom;
        private System.Windows.Forms.Button buttonToolbar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.ToolTip toolTipProcess;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonLoad1;
        private System.Windows.Forms.Button buttonSave1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonLoad3;
        private System.Windows.Forms.Button buttonSave3;
        private System.Windows.Forms.Button buttonLoad2;
        private System.Windows.Forms.Button buttonSave2;
    }
}

