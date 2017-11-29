namespace Assessment3KeyPresses
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
            this.TypeHereLbl = new System.Windows.Forms.Label();
            this.KeystrokeAmtLbl = new System.Windows.Forms.Label();
            this.TypingTxtBox = new System.Windows.Forms.TextBox();
            this.LastPressedLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TypeHereLbl
            // 
            this.TypeHereLbl.AutoSize = true;
            this.TypeHereLbl.Location = new System.Drawing.Point(12, 27);
            this.TypeHereLbl.Name = "TypeHereLbl";
            this.TypeHereLbl.Size = new System.Drawing.Size(79, 17);
            this.TypeHereLbl.TabIndex = 0;
            this.TypeHereLbl.Text = "Type Here:";
            // 
            // KeystrokeAmtLbl
            // 
            this.KeystrokeAmtLbl.AutoSize = true;
            this.KeystrokeAmtLbl.Location = new System.Drawing.Point(9, 72);
            this.KeystrokeAmtLbl.Name = "KeystrokeAmtLbl";
            this.KeystrokeAmtLbl.Size = new System.Drawing.Size(166, 17);
            this.KeystrokeAmtLbl.TabIndex = 1;
            this.KeystrokeAmtLbl.Text = "Number of keystrokes:  0";
            // 
            // TypingTxtBox
            // 
            this.TypingTxtBox.Location = new System.Drawing.Point(12, 47);
            this.TypingTxtBox.Name = "TypingTxtBox";
            this.TypingTxtBox.Size = new System.Drawing.Size(258, 22);
            this.TypingTxtBox.TabIndex = 2;
            this.TypingTxtBox.TextChanged += new System.EventHandler(this.TypingTxtBox_TextChanged);
            this.TypingTxtBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TypingTxtBox_KeyUp);
            // 
            // LastPressedLbl
            // 
            this.LastPressedLbl.AutoSize = true;
            this.LastPressedLbl.Location = new System.Drawing.Point(141, 104);
            this.LastPressedLbl.Name = "LastPressedLbl";
            this.LastPressedLbl.Size = new System.Drawing.Size(31, 17);
            this.LastPressedLbl.TabIndex = 3;
            this.LastPressedLbl.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Last Key Pressed:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastPressedLbl);
            this.Controls.Add(this.TypingTxtBox);
            this.Controls.Add(this.KeystrokeAmtLbl);
            this.Controls.Add(this.TypeHereLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TypeHereLbl;
        private System.Windows.Forms.Label KeystrokeAmtLbl;
        private System.Windows.Forms.TextBox TypingTxtBox;
        private System.Windows.Forms.Label LastPressedLbl;
        private System.Windows.Forms.Label label1;
    }
}

