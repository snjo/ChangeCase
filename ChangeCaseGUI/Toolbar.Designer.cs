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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Toolbar));
            this.buttonPlain = new System.Windows.Forms.Button();
            this.buttonLower = new System.Windows.Forms.Button();
            this.buttonUpper = new System.Windows.Forms.Button();
            this.buttonPinToolbar = new System.Windows.Forms.Button();
            this.buttonBorder = new System.Windows.Forms.Button();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.buttonMemory1 = new System.Windows.Forms.Button();
            this.buttonMemory2 = new System.Windows.Forms.Button();
            this.buttonMemory3 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonPlain
            // 
            this.buttonPlain.Location = new System.Drawing.Point(44, 1);
            this.buttonPlain.Name = "buttonPlain";
            this.buttonPlain.Size = new System.Drawing.Size(23, 23);
            this.buttonPlain.TabIndex = 3;
            this.buttonPlain.Text = "t";
            this.buttonPlain.UseVisualStyleBackColor = true;
            this.buttonPlain.Click += new System.EventHandler(this.actionPlain);
            // 
            // buttonLower
            // 
            this.buttonLower.Location = new System.Drawing.Point(0, 1);
            this.buttonLower.Name = "buttonLower";
            this.buttonLower.Size = new System.Drawing.Size(23, 23);
            this.buttonLower.TabIndex = 1;
            this.buttonLower.Text = "a";
            this.buttonLower.UseVisualStyleBackColor = true;
            this.buttonLower.Click += new System.EventHandler(this.actionLower);
            // 
            // buttonUpper
            // 
            this.buttonUpper.Location = new System.Drawing.Point(22, 1);
            this.buttonUpper.Name = "buttonUpper";
            this.buttonUpper.Size = new System.Drawing.Size(23, 23);
            this.buttonUpper.TabIndex = 2;
            this.buttonUpper.Text = "A";
            this.buttonUpper.UseVisualStyleBackColor = true;
            this.buttonUpper.Click += new System.EventHandler(this.actionUpper);
            // 
            // buttonPinToolbar
            // 
            this.buttonPinToolbar.Location = new System.Drawing.Point(182, 1);
            this.buttonPinToolbar.Name = "buttonPinToolbar";
            this.buttonPinToolbar.Size = new System.Drawing.Size(20, 23);
            this.buttonPinToolbar.TabIndex = 9;
            this.buttonPinToolbar.Text = "📌";
            this.buttonPinToolbar.UseVisualStyleBackColor = true;
            this.buttonPinToolbar.Click += new System.EventHandler(this.actionAlwaysOnTop);
            // 
            // buttonBorder
            // 
            this.buttonBorder.Location = new System.Drawing.Point(163, 1);
            this.buttonBorder.Name = "buttonBorder";
            this.buttonBorder.Size = new System.Drawing.Size(20, 23);
            this.buttonBorder.TabIndex = 8;
            this.buttonBorder.Text = "—";
            this.buttonBorder.UseVisualStyleBackColor = true;
            this.buttonBorder.Click += new System.EventHandler(this.actionBorderToggle);
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(71, 1);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(23, 23);
            this.buttonProcess.TabIndex = 4;
            this.buttonProcess.Text = "$";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.actionProcess);
            // 
            // buttonMemory1
            // 
            this.buttonMemory1.Location = new System.Drawing.Point(93, 1);
            this.buttonMemory1.Name = "buttonMemory1";
            this.buttonMemory1.Size = new System.Drawing.Size(23, 23);
            this.buttonMemory1.TabIndex = 5;
            this.buttonMemory1.Text = "1";
            this.buttonMemory1.UseVisualStyleBackColor = true;
            this.buttonMemory1.MouseHover += new System.EventHandler(this.updateTooltip1);
            this.buttonMemory1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.saveload1);
            // 
            // buttonMemory2
            // 
            this.buttonMemory2.Location = new System.Drawing.Point(115, 1);
            this.buttonMemory2.Name = "buttonMemory2";
            this.buttonMemory2.Size = new System.Drawing.Size(23, 23);
            this.buttonMemory2.TabIndex = 6;
            this.buttonMemory2.Text = "2";
            this.buttonMemory2.UseVisualStyleBackColor = true;
            this.buttonMemory2.MouseHover += new System.EventHandler(this.updateTooltip2);
            this.buttonMemory2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.saveload2);
            // 
            // buttonMemory3
            // 
            this.buttonMemory3.Location = new System.Drawing.Point(137, 1);
            this.buttonMemory3.Name = "buttonMemory3";
            this.buttonMemory3.Size = new System.Drawing.Size(23, 23);
            this.buttonMemory3.TabIndex = 7;
            this.buttonMemory3.Text = "3";
            this.buttonMemory3.UseVisualStyleBackColor = true;
            this.buttonMemory3.MouseHover += new System.EventHandler(this.updateTooltip3);
            this.buttonMemory3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.saveload3);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Memory Slot";
            // 
            // Toolbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 25);
            this.Controls.Add(this.buttonMemory3);
            this.Controls.Add(this.buttonMemory2);
            this.Controls.Add(this.buttonMemory1);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.buttonBorder);
            this.Controls.Add(this.buttonPinToolbar);
            this.Controls.Add(this.buttonPlain);
            this.Controls.Add(this.buttonLower);
            this.Controls.Add(this.buttonUpper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Toolbar";
            this.Text = "Toolbar";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlain;
        private System.Windows.Forms.Button buttonLower;
        private System.Windows.Forms.Button buttonUpper;
        private System.Windows.Forms.Button buttonPinToolbar;
        private System.Windows.Forms.Button buttonBorder;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.Button buttonMemory1;
        private System.Windows.Forms.Button buttonMemory2;
        private System.Windows.Forms.Button buttonMemory3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}