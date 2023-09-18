using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTekstikenttä_VScroll(object sender, EventArgs e)
        {
            Random random = new Random();

            richTekstikenttä.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        private void latausBtn_Click(object sender, EventArgs e)
        {
            richTekstikenttä.LoadFile(nimiKentta.Text, RichTextBoxStreamType.RichText);

            StreamReader sr = File.OpenText(nimiKentta.Text);

            tiedostoKentta.Text = sr.ReadToEnd();

            sr.Close();
        }

        private void tallennusBtn_Click(object sender, EventArgs e)
        {
            richTekstikenttä.SaveFile(nimiKentta.Text);
        }

        private void siivoaBtn_Click(object sender, EventArgs e)
        {
            richTekstikenttä.Text = "";
            tiedostoKentta.Text = "";
        }

        private void lopetaBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
