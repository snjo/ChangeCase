namespace ChangeCaseGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radioLower = new System.Windows.Forms.RadioButton();
            this.radioUpper = new System.Windows.Forms.RadioButton();
            this.radioOff = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxCapsLock = new System.Windows.Forms.CheckBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.systrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.capsLockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPPERCassClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowerCaseClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonUpper = new System.Windows.Forms.Button();
            this.buttonLower = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
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
            this.radioOff.TabIndex = 4;
            this.radioOff.TabStop = true;
            this.radioOff.Text = "off";
            this.radioOff.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Alt+Shit+U";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Alt+Shit+L";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ctrl+Shift + Backspace";
            // 
            // checkBoxCapsLock
            // 
            this.checkBoxCapsLock.AutoSize = true;
            this.checkBoxCapsLock.Location = new System.Drawing.Point(12, 108);
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
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 136);
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
            this.buttonUpper.TabIndex = 10;
            this.buttonUpper.Text = "UPPER";
            this.buttonUpper.UseVisualStyleBackColor = true;
            this.buttonUpper.Click += new System.EventHandler(this.actionUpperCaseOnce);
            // 
            // buttonLower
            // 
            this.buttonLower.Location = new System.Drawing.Point(119, 51);
            this.buttonLower.Name = "buttonLower";
            this.buttonLower.Size = new System.Drawing.Size(55, 23);
            this.buttonLower.TabIndex = 11;
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
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItem2.Text = "Hide";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.actionHideFromTaskbar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 129);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonLower);
            this.Controls.Add(this.buttonUpper);
            this.Controls.Add(this.checkBoxCapsLock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioOff);
            this.Controls.Add(this.radioUpper);
            this.Controls.Add(this.radioLower);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Case converter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radioLower;
        private System.Windows.Forms.RadioButton radioUpper;
        private System.Windows.Forms.RadioButton radioOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
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
    }
}

