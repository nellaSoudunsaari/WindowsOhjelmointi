using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H8
{
    public partial class H8Radiobtn : Form
    {
        public H8Radiobtn()
        {
            InitializeComponent();
        }

        private void bgValinta1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.lehma;
            bgGroupbox.Visible = false;
            this.Text = "Napsauta ikkunaa saadaksesi valintanappiryhmät näkyviin";
        }

        private void bgValinta2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.pesukarhu;
            bgGroupbox.Visible = false;
            this.Text = "Napsauta ikkunaa saadaksesi valintanappiryhmät näkyviin";
        }

        private void bgValinta3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.kissoja;
            bgGroupbox.Visible = false;
            this.Text = "Napsauta ikkunaa saadaksesi valintanappiryhmät näkyviin";
        }

        private void bgCenter_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Center;
            sijaintiGroupbox.Visible = false;
        }

        private void bgNone_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.None;
            sijaintiGroupbox.Visible = false;
        }

        private void bgStretch_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            sijaintiGroupbox.Visible = false;
        }

        private void bgTile_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Tile;
            sijaintiGroupbox.Visible = false;
        }

        private void bgZoom_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Zoom;
            sijaintiGroupbox.Visible = false;
        }
    }
}
