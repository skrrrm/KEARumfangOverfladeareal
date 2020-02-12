using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEARumfangOverfladeareal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Variabler
        double h, w, l, volume, area;

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                h = Convert.ToDouble(textBoxHight.Text); // Konvertere textbox til en double, så der kan regnes på det, da det jo er en string
                w = Convert.ToDouble(textBoxWidth.Text); // --------- || ---------
                l = Convert.ToDouble(textBoxLength.Text);
            }
            catch
            {
                labelError.Text = "Only use numbers.";
            }

            volume = h * w * l;
            area = 2 * (l * h + h * w + w * l);
            textBoxVolume.Text = Convert.ToString(volume);
            textBoxSurfaceArea.Text = Convert.ToString(area);

        }
    }
}
