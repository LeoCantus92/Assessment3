namespace ColoursOfTheRainbow
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
            this.DisplayBtn = new System.Windows.Forms.Button();
            this.ColoursDropDwn = new System.Windows.Forms.ComboBox();
            this.SelectColourLbl = new System.Windows.Forms.Label();
            this.ColourLbl1 = new System.Windows.Forms.Label();
            this.ColourNameLbl = new System.Windows.Forms.Label();
            this.ColourLbl2 = new System.Windows.Forms.Label();
            this.ColourHexLbl = new System.Windows.Forms.Label();
            this.ColourLbl3 = new System.Windows.Forms.Label();
            this.ColourRgbaLbl = new System.Windows.Forms.Label();
            this.ColourBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DisplayBtn
            // 
            this.DisplayBtn.Location = new System.Drawing.Point(234, 34);
            this.DisplayBtn.Name = "DisplayBtn";
            this.DisplayBtn.Size = new System.Drawing.Size(75, 33);
            this.DisplayBtn.TabIndex = 0;
            this.DisplayBtn.Text = "Display";
            this.DisplayBtn.UseVisualStyleBackColor = true;
            this.DisplayBtn.Click += new System.EventHandler(this.DisplayBtn_Click);
            // 
            // ColoursDropDwn
            // 
            this.ColoursDropDwn.FormattingEnabled = true;
            this.ColoursDropDwn.Location = new System.Drawing.Point(34, 43);
            this.ColoursDropDwn.Name = "ColoursDropDwn";
            this.ColoursDropDwn.Size = new System.Drawing.Size(121, 24);
            this.ColoursDropDwn.TabIndex = 1;
            // 
            // SelectColourLbl
            // 
            this.SelectColourLbl.AutoSize = true;
            this.SelectColourLbl.Location = new System.Drawing.Point(31, 23);
            this.SelectColourLbl.Name = "SelectColourLbl";
            this.SelectColourLbl.Size = new System.Drawing.Size(96, 17);
            this.SelectColourLbl.TabIndex = 2;
            this.SelectColourLbl.Text = "Select Colour:";
            this.SelectColourLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // ColourLbl1
            // 
            this.ColourLbl1.AutoSize = true;
            this.ColourLbl1.Location = new System.Drawing.Point(31, 70);
            this.ColourLbl1.Name = "ColourLbl1";
            this.ColourLbl1.Size = new System.Drawing.Size(49, 17);
            this.ColourLbl1.TabIndex = 3;
            this.ColourLbl1.Text = "Name:";
            // 
            // ColourNameLbl
            // 
            this.ColourNameLbl.AutoSize = true;
            this.ColourNameLbl.Location = new System.Drawing.Point(81, 70);
            this.ColourNameLbl.Name = "ColourNameLbl";
            this.ColourNameLbl.Size = new System.Drawing.Size(31, 17);
            this.ColourNameLbl.TabIndex = 4;
            this.ColourNameLbl.Text = "N/A";
            // 
            // ColourLbl2
            // 
            this.ColourLbl2.AutoSize = true;
            this.ColourLbl2.Location = new System.Drawing.Point(31, 102);
            this.ColourLbl2.Name = "ColourLbl2";
            this.ColourLbl2.Size = new System.Drawing.Size(36, 17);
            this.ColourLbl2.TabIndex = 5;
            this.ColourLbl2.Text = "Hex:";
            // 
            // ColourHexLbl
            // 
            this.ColourHexLbl.AutoSize = true;
            this.ColourHexLbl.Location = new System.Drawing.Point(81, 102);
            this.ColourHexLbl.Name = "ColourHexLbl";
            this.ColourHexLbl.Size = new System.Drawing.Size(31, 17);
            this.ColourHexLbl.TabIndex = 6;
            this.ColourHexLbl.Text = "N/A";
            // 
            // ColourLbl3
            // 
            this.ColourLbl3.AutoSize = true;
            this.ColourLbl3.Location = new System.Drawing.Point(31, 132);
            this.ColourLbl3.Name = "ColourLbl3";
            this.ColourLbl3.Size = new System.Drawing.Size(51, 17);
            this.ColourLbl3.TabIndex = 7;
            this.ColourLbl3.Text = "RGBA:";
            // 
            // ColourRgbaLbl
            // 
            this.ColourRgbaLbl.AutoSize = true;
            this.ColourRgbaLbl.Location = new System.Drawing.Point(83, 132);
            this.ColourRgbaLbl.Name = "ColourRgbaLbl";
            this.ColourRgbaLbl.Size = new System.Drawing.Size(31, 17);
            this.ColourRgbaLbl.TabIndex = 8;
            this.ColourRgbaLbl.Text = "N/A";
            // 
            // ColourBox
            // 
            this.ColourBox.Location = new System.Drawing.Point(195, 119);
            this.ColourBox.Multiline = true;
            this.ColourBox.Name = "ColourBox";
            this.ColourBox.Size = new System.Drawing.Size(141, 147);
            this.ColourBox.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 301);
            this.Controls.Add(this.ColourBox);
            this.Controls.Add(this.ColourRgbaLbl);
            this.Controls.Add(this.ColourLbl3);
            this.Controls.Add(this.ColourHexLbl);
            this.Controls.Add(this.ColourLbl2);
            this.Controls.Add(this.ColourNameLbl);
            this.Controls.Add(this.ColourLbl1);
            this.Controls.Add(this.SelectColourLbl);
            this.Controls.Add(this.ColoursDropDwn);
            this.Controls.Add(this.DisplayBtn);
            this.Name = "MainForm";
            this.Text = "Colurs of the Rainbow";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DisplayBtn;
        private System.Windows.Forms.ComboBox ColoursDropDwn;
        private System.Windows.Forms.Label SelectColourLbl;
        private System.Windows.Forms.Label ColourLbl1;
        private System.Windows.Forms.Label ColourNameLbl;
        private System.Windows.Forms.Label ColourLbl2;
        private System.Windows.Forms.Label ColourHexLbl;
        private System.Windows.Forms.Label ColourLbl3;
        private System.Windows.Forms.Label ColourRgbaLbl;
        private System.Windows.Forms.TextBox ColourBox;
    }
}

