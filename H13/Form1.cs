using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H13
{
    public partial class H13ImageList : Form
    {
        public H13ImageList()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rollBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            rollBtn.Enabled = false;
        }
        int counter = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int noppa1;
            Random rnd = new Random();
            noppa1 = rnd.Next(0, 6);
            pictureBox1.Image = imageList1.Images[noppa1];
            counter++;
            if (counter == 30)
            {
                timer1.Stop();
                counter = 0;
                rollBtn.Enabled = true;
            }

        }
    }
}
