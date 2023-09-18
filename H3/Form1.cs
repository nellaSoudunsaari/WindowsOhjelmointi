using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H3
{
    public partial class H3TxtBox : Form
    {
        public H3TxtBox()
        {
            InitializeComponent();
        }

        private void lauseKentta_TextChanged(object sender, EventArgs e)
        {
            lauseKentta.BackColor = Color.SkyBlue;
            arkistoKentta.BackColor = Color.Wheat;
        }

        private void arkistoKentta_TextChanged(object sender, EventArgs e)
        {
            arkistoKentta.BackColor = Color.Cyan;
        }

        private void kopioBtn_Click(object sender, EventArgs e)
        {
            arkistoKentta.Text = lauseKentta.Text + " " + arkistoKentta.Text;

            arkistoKentta_TextChanged(sender, e);
        }

        private void salausBtn_Click(object sender, EventArgs e)
        {
            if (arkistoKentta.PasswordChar == '*')
                arkistoKentta.PasswordChar = '\0';
            else
                arkistoKentta.PasswordChar = '*';

            ((Button)sender).Text = "Kumoa tekstin salaus";
        }
    }
}
