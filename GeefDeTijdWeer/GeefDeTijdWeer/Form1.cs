using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeefDeTijdWeer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZetOm_Click(object sender, EventArgs e)
        {
            int totaalAantalSeconden;
            totaalAantalSeconden = Convert.ToInt32(txtTijdInSec.Text);

            int uren = totaalAantalSeconden / 3600;
            int seconden = totaalAantalSeconden % 3600;
            int minuten = seconden / 60;
            seconden = seconden % 60;

            String resultaat = String.Format("{0} uur {1} minuten {2} seconden", uren, minuten, seconden);
            MessageBox.Show(resultaat);
        }
    }
}
