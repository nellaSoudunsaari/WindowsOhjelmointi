using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H7
{
    public partial class Harkka7Checkbox : Form
    {
        FontFamily Ff1, Ff2;
        Font Fontti1, Fontti2;

        Random r;

        private void kokoCheck_CheckedChanged(object sender, EventArgs e)
        {
            Size koko1 = new Size(500, 500);

            if (kokoCheck.Checked)
            {
                kokoCheck.Font = Fontti2;
                kokoCheck.ForeColor = Color.Yellow;
                this.Size = new Size(koko1.Width + r.Next(50), koko1.Height + r.Next(50));
            }else
            {
                kokoCheck.Font = Fontti1;
                kokoCheck.ForeColor = Color.Black;

                this.Size = koko1;
            }
        }

        private void sijaintiCheck_CheckedChanged(object sender, EventArgs e)
        {
            Point sijainti1 = new Point(30, 132);

            if (sijaintiCheck.Checked)
            {
                sijaintiCheck.Font = Fontti2;
                sijaintiCheck.ForeColor = Color.Yellow;
                this.Location = new Point(sijainti1.X + r.Next(50), sijainti1.Y + r.Next(50));
            }else
            {
                sijaintiCheck.Font = Fontti1;
                sijaintiCheck.ForeColor = Color.Black;
                this.Location = sijainti1;
            }
        }

        public Harkka7Checkbox()
        {
            InitializeComponent();

            Ff1 = new FontFamily("Microsoft Sans Serif");
            Fontti1 = new Font(Ff1, 8, GraphicsUnit.Point);

            Ff2 = new FontFamily("Times New Roman");
            Fontti2 = new Font(Ff2, 14, GraphicsUnit.Point);

            r = new Random();
        }
        private void variCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (variCheck.Checked)
            {
                variCheck.Font = Fontti2;
                variCheck.ForeColor = Color.Yellow;
                this.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            }else
            {
                variCheck.Font = Fontti1;
                variCheck.ForeColor = Color.Black;
            }
        }



    }
}
