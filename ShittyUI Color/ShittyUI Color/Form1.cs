using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShittyUI_Color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ColorChoice_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    Color color = colorDialog1.Color;

                    int ColorNumber = color.R + color.B + color.G;

                    ColorNumber = CheckNumber(ColorNumber);

                    if (ColorNumber >= 0 && ColorNumber <= VolumeSlider.Maximum)
                    {
                        Volume.Text = ColorNumber.ToString();
                        VolumeSlider.Value = ColorNumber;
                        ColorChoice.BackColor = colorDialog1.Color;
                        break;
                    }
                }
            }
        }

        //trying something simpler
        private int CheckNumber(int ColorNumber)
        {
            if (ColorNumber > 700)
            {
                double tempnumber = ColorNumber;
                tempnumber = tempnumber / 7.65;
                ColorNumber = (int)tempnumber;
            }
            else if (ColorNumber > 100)
            {
                ColorNumber = ColorNumber / 10;
            }

            return ColorNumber;
        }

        private void VolumeSlider_Scroll(object sender, EventArgs e)
        {
            VolumeSlider.Value = Int32.Parse(Volume.Text);
        }
    }
}
