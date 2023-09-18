using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Tervetuloa ohjelmaan!" + DateTime.Now;
        }

        int laskuri = 0;

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Form uusiIkkuna = new Form();

            uusiIkkuna.Text = "Ihka uusi ikkuna" + ++laskuri;

            uusiIkkuna.BackColor = Color.Lavender;

            uusiIkkuna.Size = new Size(250, 250);

            uusiIkkuna.Location = new Point(50, 50);

            uusiIkkuna.Show();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            Random r = new Random();

            Color taustaVari = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));

            this.BackColor = taustaVari;
        }
    }
}
