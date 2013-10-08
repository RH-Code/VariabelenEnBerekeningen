using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Omzetten_naar_Binair
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOmzetten_Click(object sender, EventArgs e)
        {
            int decimaalGetal = Convert.ToInt32(txtGeheelGetal.Text);
            int deling;
            string resultaat = String.Empty;

            if (decimaalGetal <= 255)
            {
                deling = decimaalGetal / 256;
                decimaalGetal = decimaalGetal % 256;
                resultaat = resultaat + deling;

                deling = decimaalGetal / 128;
                decimaalGetal = decimaalGetal % 128;
                resultaat = resultaat + deling;

                deling = decimaalGetal / 64;
                decimaalGetal = decimaalGetal % 64;
                resultaat = resultaat + deling;

                deling = decimaalGetal / 32;
                decimaalGetal = decimaalGetal % 32;
                resultaat = resultaat + deling;

                deling = decimaalGetal / 16;
                decimaalGetal = decimaalGetal % 16;
                resultaat = resultaat + deling;

                deling = decimaalGetal / 8;
                decimaalGetal = decimaalGetal % 8;
                resultaat = resultaat + deling;

                deling = decimaalGetal / 4;
                decimaalGetal = decimaalGetal % 4;
                resultaat = resultaat + deling;

                deling = decimaalGetal / 2;
                decimaalGetal = decimaalGetal % 2;
                resultaat = resultaat + deling;

                deling = decimaalGetal / 1;
                decimaalGetal = decimaalGetal % 1;
                resultaat = resultaat + deling + decimaalGetal;

                lblBinair.Text = Convert.ToString(resultaat);
            }
            else
            {
                lblBinair.Text = ("Max. 255");
            }
        }
    }
}
