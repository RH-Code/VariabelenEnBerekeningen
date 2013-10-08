using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Frisdrankenautomaat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBetalen_Click(object sender, EventArgs e)
        {
            int ingeworpenBedrag, prijsFrisdrank;
            int bedrag100, bedrag50, bedrag20, bedrag10, bedrag5, bedrag2, bedrag1;
            int wisselgeld;

            ingeworpenBedrag = Convert.ToInt32(txtInworp.Text);
            prijsFrisdrank = Convert.ToInt32(txtPrijs.Text);
            wisselgeld = ingeworpenBedrag - prijsFrisdrank;

            bedrag100 = wisselgeld / 100;
            wisselgeld = wisselgeld % 100;

            bedrag50 = wisselgeld / 50;
            wisselgeld = wisselgeld % 50;

            bedrag20 = wisselgeld / 20;
            wisselgeld = wisselgeld % 20;

            bedrag10 = wisselgeld / 10;
            wisselgeld = wisselgeld % 10;

            bedrag5 = wisselgeld / 5;
            wisselgeld = wisselgeld % 5;

            bedrag2 = wisselgeld / 2;
            wisselgeld = wisselgeld % 2;

            bedrag1 = wisselgeld / 1;
            wisselgeld = wisselgeld % 1;

            MessageBox.Show("Aantal stukken van 1€ is " + Convert.ToString(bedrag100));
            MessageBox.Show("Aantal stukken van 50c is " + Convert.ToString(bedrag50));
            MessageBox.Show("Aantal stukken van 20c is " + Convert.ToString(bedrag20));
            MessageBox.Show("Aantal stukken van 10c is " + Convert.ToString(bedrag10));
            MessageBox.Show("Aantal stukken van 5c is " + Convert.ToString(bedrag5));
            MessageBox.Show("Aantal stukken van 2c is " + Convert.ToString(bedrag2));
            MessageBox.Show("Aantal stukken van 1c is " + Convert.ToString(bedrag1));
        }
    }
}
