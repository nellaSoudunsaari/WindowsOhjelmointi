using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H17
{
    public partial class H17PictureBox : Form
    {
        public H17PictureBox()
        {
            InitializeComponent();
        }

        char[] infoLabelTeksti;
        int infoLabelTekstiLaskuri = 0;
        bool ajastinPaalla = false;

        private void kaynnistysBtn_Click(object sender, EventArgs e)
        {
            if (kaynnistysBtn.Text.IndexOf("Käynnistä") != -1)
            {
                kaynnistysBtn.Text = "Lopeta esitys";
                infoLabel.Text = "Esitys on meneillään";
                infoLabelTeksti = infoLabel.Text.ToCharArray();
                infoLabel.Text = "";
            }
            else
            {
                kaynnistysBtn.Text = "Käynnistä esitys";
                infoLabel.Text = "Esitys on loppu";
                infoLabelTekstiLaskuri = 0;
            }

            kuvaLaatikko.Size = kuvaLista.ImageSize;

            int kuvaLaatikkoLeveys = kuvaLaatikko.Size.Width;
            int kuvaLaatikkoKorkeus = kuvaLaatikko.Size.Height;

            int x = (int)(0.5 * (this.Width - kuvaLaatikko.Width));
            int y = (int)(0.5 * (this.Height - kuvaLaatikko.Height));

            kuvaLaatikko.Location = new Point(x, y);

            if (ajastinPaalla)
            {
                ajastinPaalla = false;

                ajastin.Stop();
            }
            else
            {
                ajastinPaalla = true;
                ajastin.Start();
            }
        }
        int laskuri = 0;
        private void ajastin_Tick(object sender, EventArgs e)
        {
            if (infoLabelTekstiLaskuri >= infoLabelTeksti.Length)
            {
                infoLabelTekstiLaskuri = 0;
                infoLabel.Text = "";
            }

            infoLabel.Text += infoLabelTeksti[infoLabelTekstiLaskuri++];
            if (laskuri >= kuvaLista.Images.Count)
                laskuri = 0;

            kuvaLaatikko.Image = kuvaLista.Images[laskuri++];
        }
    }
}
