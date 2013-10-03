using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inkomstenbelasting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            double inkomen, belasting, inkomenNaAftrek;
            double belastingspercentage;
            inkomen = Convert.ToDouble(txtInkomen.Text);
            belastingspercentage = Convert.ToDouble(txtBelastingspercentage.Text);
            belasting = inkomen * (belastingspercentage / 100);
            inkomenNaAftrek = inkomen - belasting;

            lblBelasting.Text = Convert.ToString(belasting);
            lblInkomen.Text = Convert.ToString(inkomenNaAftrek);


        }
    }
}
