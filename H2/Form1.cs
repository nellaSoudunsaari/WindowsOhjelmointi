using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H2
{
    public partial class H2Nappi : Form
    {
        public H2Nappi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Visible)
            {
                button2.Visible = false;
                ((Button)sender).Text = "Näytä nappi 2";

                this.BackColor = Color.CadetBlue;
            }
            else
            {
                button2.Visible = true;
                ((Button)sender).Text = "Piilota nappi 2";

                this.BackColor = Color.Coral;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.DeepSkyBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.DeepPink;
        }
    }
}
