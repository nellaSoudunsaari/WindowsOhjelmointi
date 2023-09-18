using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H5
{
    public partial class H5MaskedTextbox : Form
    {
        public H5MaskedTextbox()
        {
            InitializeComponent();
        }

        private void rekisteroiBtn_Click(object sender, EventArgs e)
        {
            if (yhteenvetoBox.Text != "")
                yhteenvetoBox.Text = "";

            yhteenvetoBox.Text += "\tHenkilötiedot" + Environment.NewLine + "Nimi:\t\t" + nimiMbox.Text + Environment.NewLine + "Henkilötunnus: \t\t" + hetuMbox.Text + Environment.NewLine + "Puhelinnumero: \t\t" + puhnroMbox.Text + Environment.NewLine + "Sähköposti: \t" + spostiMbox.Text;
        }
    }
}
