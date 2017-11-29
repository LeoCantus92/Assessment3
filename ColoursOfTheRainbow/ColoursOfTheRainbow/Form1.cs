using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace ColoursOfTheRainbow
{
    public partial class MainForm : Form
    {
        static Colour[] ColourArray;

        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Read json file to array
            var colourJson = File.ReadAllText(@"colours.json");
            ColourArray = JObject.Parse(colourJson)["Colour"].ToObject<Colour[]>();

            //Fill drop down menu
            foreach(Colour colour in ColourArray)
            {
                ColoursDropDwn.Items.Add(colour.name);
            }
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            //Find the selected colour
            Colour selectedColour = ColourArray[ColoursDropDwn.SelectedIndex];

            //Set labels
            ColourNameLbl.Text = selectedColour.name;
            ColourHexLbl.Text = selectedColour.hex;
            ColourRgbaLbl.Text = selectedColour.rgba;

            //Set the boxes colour to the chosen one
            Color usedColour = System.Drawing.ColorTranslator.FromHtml(selectedColour.hex);
            ColourBox.BackColor = usedColour;
        }
    }
}
