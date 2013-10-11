using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrootsteGetal
{
    public partial class GrootsteGetalForm : Form
    {
        public GrootsteGetalForm()
        {
            InitializeComponent();
        }

        private void btnWissen_Click(object sender, EventArgs e)
        {
            txtGetal1.Text = "";
            txtGetal1.Focus();
            txtGetal2.Text = "";
            lblGrootsteGetal.Text = null;
        }

        private void btnGrootsteGetal_Click(object sender, EventArgs e)
        {
            int getal1, getal2;
            getal1 = Convert.ToInt32(txtGetal1.Text);
            getal2 = Convert.ToInt32(txtGetal2.Text);

            if (getal1 > getal2)
            {
                lblGrootsteGetal.Text = String.Format("Het grootste getal bedraagt {0}.", getal1);
            }
            else
            {
                lblGrootsteGetal.Text = String.Format("Het grootste getal bedraagt {0}.", getal2);
            }
        }

        

        
    }
}
