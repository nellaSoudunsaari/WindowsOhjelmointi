using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox
{
    public partial class H6RichTextbox : Form
    {
        public H6RichTextbox()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string message = "Viestilaatikko";
            var result = MessageBox.Show(message);
        }

        private void richTekstikenttä_VScroll(object sender, EventArgs e)
        {

        }
    }
}
