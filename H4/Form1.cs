using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H4
{
    public partial class H4Label : Form
    {
        public H4Label()
        {
            InitializeComponent();
        }

        private void tunnusLabel_MouseHover(object sender, EventArgs e)
        {
            Label aktiivilabel = (Label)sender;

            aktiivilabel.BackColor = Color.AliceBlue;
        }

        private void tunnusLabel_MouseLeave(object sender, EventArgs e)
        {
            Label aktiivilabel = (Label)sender;

            aktiivilabel.BackColor = Color.Beige;
        }

        private void salasanaLabel_MouseHover(object sender, EventArgs e)
        {
            Label aktiivilabel = (Label)sender;

            aktiivilabel.BackColor = Color.AliceBlue;
        }

        private void salasanaLabel_MouseLeave(object sender, EventArgs e)
        {
            Label aktiivilabel = (Label)sender;

            aktiivilabel.BackColor = Color.Beige;
        }

        private void kirjauduBtn_Click(object sender, EventArgs e)
        {
            if (tunnusBox.Text.Equals("Muumi") && (salasanaBox.Text.Equals("Laakso")))
                palauteLabel.Text = "Tervetuloa!";
            else
                palauteLabel.Text = "Kirjautuminen ei onnistunut, yritä uudelleen";
        }

        int fonttiKoko = 10;
        private void palauteLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (fonttiKoko < 6)
                fonttiKoko = 10;
            else
                fonttiKoko--;

            palauteLabel.Font = new Font(new FontFamily("Tahoma"), fonttiKoko);
        }

        private void palauteLabel_MouseHover(object sender, EventArgs e)
        {
            palauteLabel.Font = new Font(new FontFamily("Tahoma"), fonttiKoko++);
        }
    }
}
