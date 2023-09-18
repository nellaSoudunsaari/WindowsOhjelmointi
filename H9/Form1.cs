using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H9
{
    public partial class H9Listbox : Form
    {
        public H9Listbox()
        {
            InitializeComponent();
        }

        private void H9Listbox_Load(object sender, EventArgs e)
        {
            ListBox mylist = new ListBox();
            mylist.Location = new Point(290, 110);
            mylist.Size = new Size(120, 100);
            mylist.ForeColor = Color.Black;
            mylist.Items.Add(123);
            mylist.Items.Add(235);
            mylist.Items.Add(532);

            this.Controls.Add(mylist);
        }
    }
}
