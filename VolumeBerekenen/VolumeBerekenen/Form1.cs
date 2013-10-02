using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VolumeBerekenen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerekenVolume_Click(object sender, EventArgs e)
        {
            double lengte, hoogte, breedte;
            double volume;
            lengte = Convert.ToDouble(textBoxLengte.Text);
            hoogte = Convert.ToDouble(textBoxHoogte.Text);
            breedte = Convert.ToDouble(textBoxBreedte.Text);
            volume = (lengte * breedte * hoogte) / 1000;

            MessageBox.Show("Het volume bedraagt " + volume + "m³");
        }
    }
}
