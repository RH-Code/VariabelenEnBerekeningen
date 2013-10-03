using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gemiddelde_berekenen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void berekenGemiddeldebutton_Click(object sender, EventArgs e)
        {
            int cijfer1, cijfer2;
            double klasgemiddelde;

            cijfer1 = Convert.ToInt32(leerlingAtextBox.Text);
            cijfer2 = Convert.ToInt32(leerlingBtextBox.Text);
            klasgemiddelde = (Convert.ToDouble(cijfer1) + Convert.ToDouble(cijfer2)) / 2;

            txtGemiddelde.Text = String.Format("Het klasgemiddelde bedraagt " + klasgemiddelde + "%");
        }
    }
}
