namespace ChangeCaseGUI
{
    partial class Toolbar
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLower = new System.Windows.Forms.Button();
            this.buttonUpper = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonBorder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Plain";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonLower
            // 
            this.buttonLower.Location = new System.Drawing.Point(-1, 1);
            this.buttonLower.Name = "buttonLower";
            this.buttonLower.Size = new System.Drawing.Size(55, 23);
            this.buttonLower.TabIndex = 17;
            this.buttonLower.Text = "lower";
            this.buttonLower.UseVisualStyleBackColor = true;
            // 
            // buttonUpper
            // 
            this.buttonUpper.Location = new System.Drawing.Point(51, 1);
            this.buttonUpper.Name = "buttonUpper";
            this.buttonUpper.Size = new System.Drawing.Size(55, 23);
            this.buttonUpper.TabIndex = 16;
            this.buttonUpper.Text = "UPPER";
            this.buttonUpper.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.actionToolbarClose);
            // 
            // buttonBorder
            // 
            this.buttonBorder.Location = new System.Drawing.Point(157, 1);
            this.buttonBorder.Name = "buttonBorder";
            this.buttonBorder.Size = new System.Drawing.Size(20, 23);
            this.buttonBorder.TabIndex = 20;
            this.buttonBorder.Text = "—";
            this.buttonBorder.UseVisualStyleBackColor = true;
            this.buttonBorder.Click += new System.EventHandler(this.actionBorderToggle);
            // 
            // Toolbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 27);
            this.Controls.Add(this.buttonBorder);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLower);
            this.Controls.Add(this.buttonUpper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Toolbar";
            this.Text = "Toolbar";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLower;
        private System.Windows.Forms.Button buttonUpper;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonBorder;
    }
}