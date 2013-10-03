using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GradenOmzetten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZetOm_Click(object sender, EventArgs e)
        {
            double fahrenheit, celcius;
            fahrenheit = Convert.ToDouble(txtGradenF.Text);
            celcius = (fahrenheit - 32) * 5 / 9;

            txtGradenC.Text = Convert.ToString(celcius);
        }

        private void btnZetOm2_Click(object sender, EventArgs e)
        {
            double fahrenheit2, celcius2;
            celcius2 = Convert.ToDouble(txtGradenC2.Text);
            fahrenheit2 = celcius2 * 9 / 5 + 32;

            txtGradenF2.Text = Convert.ToString(fahrenheit2);
        }

        
    }
}
