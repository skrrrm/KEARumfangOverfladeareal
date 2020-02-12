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
            try // Error text if wrong input - i.e. digits#
            {
                h = Convert.ToDouble(textBoxHight.Text); // Converts input in textbox to number
                w = Convert.ToDouble(textBoxWidth.Text); // --------- || ---------
                l = Convert.ToDouble(textBoxLength.Text);
            }
            catch
            {
                labelError.Text = "Only use numbers."; // error
            }

            volume = h * w * l; // Volume formula
            area = 2 * (l * h + h * w + w * l); // surface area formula
            
            textBoxVolume.Text = Convert.ToString(volume); // converts results from above formulas to text and prints in corresponding boxes
            textBoxSurfaceArea.Text = Convert.ToString(area);

        }
    }
}
