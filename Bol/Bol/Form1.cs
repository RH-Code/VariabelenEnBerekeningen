using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;


namespace Bol
{
    
    public partial class Form1 : Form
    {
        CultureInfo cult = new CultureInfo("en-US");

        public Form1()
        {
            InitializeComponent();            
        }

        private void btnOmtrek_Click(object sender, EventArgs e)
        {
            double straal, omtrek;
            
            straal = Convert.ToDouble(txtStraal.Text, cult.NumberFormat);
            omtrek = 2 * Math.PI * straal;

            MessageBox.Show("De omtrek van de cirkel bedraagt " + omtrek  + " cm");
        }

        private void btnOppervlakte_Click(object sender, EventArgs e)
        {
            double straal, oppervlakte;
            
            straal = Convert.ToDouble(txtStraal.Text, cult.NumberFormat);
            oppervlakte = Math.PI * Math.Pow(straal, 2);

            MessageBox.Show("De oppervlakte van de cirkel bedraagt " + oppervlakte + " cm²");
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            double straal, volume;
            
            straal = Convert.ToDouble(txtStraal.Text, cult.NumberFormat);
            volume = (4 * Math.PI / 3) * Math.Pow(straal, 3);

            MessageBox.Show("Het volume van de bol bedraagt " + volume + " cm³");
        }
    }
}
