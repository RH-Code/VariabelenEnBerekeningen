using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace WeerstandBerekenen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            double weerstand1, weerstand2;
            CultureInfo cult = new CultureInfo("en-US");
            weerstand1 = Convert.ToDouble(txtWeerstand1.Text, cult.NumberFormat);
            weerstand2 = Convert.ToDouble(txtWeerstand2.Text, cult.NumberFormat);

            double serie = weerstand1 + weerstand2;
            double parallel = (weerstand1 * weerstand2) / (weerstand1 + weerstand2);

            lblSerie.Text = Convert.ToString(serie);
            lblParallel.Text = Convert.ToString(parallel);
        }
    }
}
