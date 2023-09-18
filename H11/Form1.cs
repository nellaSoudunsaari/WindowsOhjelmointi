using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H11
{
    public partial class H11Combobox : Form
    {
        public H11Combobox()
        {
            InitializeComponent();
        }

        private void H11Combobox_Load(object sender, EventArgs e)
        {
            ComboBox mybox = new ComboBox();
            mybox.Location = new Point(327, 77);
            mybox.Size = new Size(216, 26);
            mybox.Items.Add("C#");
            mybox.Items.Add("Java");
            mybox.Items.Add("Scala");
            mybox.Items.Add("C");
            mybox.Items.Add("C++");

            // Adding this ComboBox to the form
            this.Controls.Add(mybox);
        }
    }
}
