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
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(130, 100);
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
            this.buttonCancel.Location = new System.Drawing.Point(49, 100);
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
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 135);
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
    }
}