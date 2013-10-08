using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eindsaldo_rekening
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double beginsaldo, aantalJaar, renteJaar;
            double eindsaldo;
            beginsaldo = Convert.ToDouble(txtBeginsaldo.Text);
            aantalJaar = Convert.ToDouble(txtAantalJaren.Text);
            renteJaar = Convert.ToDouble(txtRente.Text);
            
            eindsaldo = beginsaldo * Math.Pow(1 + (renteJaar / 100), aantalJaar);

            lblEindsaldo.Text = (String.Format("{0:0.00} €", eindsaldo));
            //Kan ook in een MessageBox worden weergegeven
            MessageBox.Show(String.Format("Het eindsaldo bedraagt: {0:0.00} €", eindsaldo));
        }
    }
}
