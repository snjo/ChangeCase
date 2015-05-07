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
            this.radioLower.Checked = true;
            this.radioLower.Location = new System.Drawing.Point(12, 35);
            this.radioLower.Name = "radioLower";
            this.radioLower.Size = new System.Drawing.Size(76, 17);
            this.radioLower.TabIndex = 2;
            this.radioLower.TabStop = true;
            this.radioLower.Text = "lower case";
            this.radioLower.UseVisualStyleBackColor = true;
            // 
            // radioUpper
            // 
            this.radioUpper.AutoSize = true;
            this.radioUpper.Location = new System.Drawing.Point(12, 59);
            this.radioUpper.Name = "radioUpper";
            this.radioUpper.Size = new System.Drawing.Size(93, 17);
            this.radioUpper.TabIndex = 3;
            this.radioUpper.Text = "UPPER CASE";
            this.radioUpper.UseVisualStyleBackColor = true;
            // 
            // radioOff
            // 
            this.radioOff.AutoSize = true;
            this.radioOff.Location = new System.Drawing.Point(12, 12);
            this.radioOff.Name = "radioOff";
            this.radioOff.Size = new System.Drawing.Size(37, 17);
            this.radioOff.TabIndex = 4;
            this.radioOff.TabStop = true;
            this.radioOff.Text = "off";
            this.radioOff.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 90);
            this.Controls.Add(this.radioOff);
            this.Controls.Add(this.radioUpper);
            this.Controls.Add(this.radioLower);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Case converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radioLower;
        private System.Windows.Forms.RadioButton radioUpper;
        private System.Windows.Forms.RadioButton radioOff;
    }
}

