using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H14
{
    public partial class H14Linkki : Form
    {
        public H14Linkki()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Links.Add(0, 5, "www.suomi.fi");
            linkLabel1.Links.Add(51, 13, "www.rovaniemi.fi");
            linkLabel2.Links.Add(17, 9, "www.redu.fi");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Link.LinkData.Equals(linkLabel1.Links[0].LinkData))
                System.Diagnostics.Process.Start("chrome", linkLabel1.Links[0].LinkData.ToString());

            if (e.Link.LinkData.Equals(linkLabel1.Links[1].LinkData))
                System.Diagnostics.Process.Start("chrome", linkLabel1.Links[1].LinkData.ToString());

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("chrome", linkLabel2.Links[0].LinkData.ToString());
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("chrome", linkLabel3.Text);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("chrome", linkLabel4.Text);
        }
    }
}
