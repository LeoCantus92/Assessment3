using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment3KeyPresses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Keep track of the amount of keystrokes
        int keystrokeCounter = 0;

        private void TypingTxtBox_TextChanged(object sender, EventArgs e)
        {
            //Count the amount of keystrokes
            keystrokeCounter++;
            //Display total amount of keystrokes
            KeystrokeAmtLbl.Text = "Number of keystrokes: " + keystrokeCounter.ToString();
        }

        private void TypingTxtBox_KeyUp(object sender, KeyEventArgs e)
        {
            //Set label to be the last key that was pressed
            LastPressedLbl.Text = e.KeyCode.ToString();


        }
    }
}
