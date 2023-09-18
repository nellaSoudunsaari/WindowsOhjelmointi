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

namespace H12
{
    public partial class H12Imagelist : Form
    {
        public H12Imagelist()
        {
            InitializeComponent();
        }

        private void H12Imagelist_Load(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(@"E:\taustakuvateht\");

            kuvaLista.Images.Add(Bitmap.FromFile(@"kissoja.jpg"));
            kuvaLista.Images.Add(Bitmap.FromFile(@"lehma.jpg"));
            kuvaLista.Images.Add(Bitmap.FromFile(@"pesukarhu.jpg"));

            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        int laskuri = 0;
        private void kuvanVaihtoBtn_Click(object sender, EventArgs e)
        {
            if (laskuri == kuvaLista.Images.Count)
                laskuri = 0;

            this.BackgroundImage = kuvaLista.Images[laskuri];

            laskuri++;
        }
    }
}
