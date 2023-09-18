using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H10
{
    public partial class H10CheckedListbox : Form
    {
        public H10CheckedListbox()
        {
            InitializeComponent();
        }
            Form punainenIkkuna = null;
            Form sininenIkkuna = null;
            Form keltainenIkkuna = null;

        private void ikkunatCLB_SelectedIndexChanged(object sender, EventArgs e)
        {

            CheckedListBox aktiiviLista = (CheckedListBox)sender;

            string valittu = "";

            if (aktiiviLista.SelectedItem != null)
                valittu = aktiiviLista.SelectedItem.ToString();

            switch (valittu)
            {
                case "Punainen ikkuna":
                    if (ikkunatCLB.GetItemCheckState(0).Equals(CheckState.Checked))
                    {
                        punainenIkkuna = new Form();

                        punainenIkkuna.Text = "Punainen ikkuna";

                        punainenIkkuna.BackColor = Color.Red;

                        punainenIkkuna.Show();

                        punainenIkkuna.Location = new Point(this.Location.X + 50, this.Location.Y + 70);
                    } else if (ikkunatCLB.GetItemCheckState(0).Equals(CheckState.Indeterminate) || ikkunatCLB.GetItemCheckState(0).Equals(CheckState.Unchecked))
                    {
                        if (punainenIkkuna != null)
                        {
                            punainenIkkuna.Close();
                            punainenIkkuna.Dispose();
                        }
                    }
                    break;

                case "Sininen ikkuna":
                    if (ikkunatCLB.GetItemCheckState(1).Equals(CheckState.Checked))
                    {
                        sininenIkkuna = new Form();

                        sininenIkkuna.Text = "Sininen ikkuna";

                        sininenIkkuna.BackColor = Color.Blue;

                        sininenIkkuna.Show();

                        sininenIkkuna.Location = new Point(this.Location.X + 50, this.Location.Y + 70);
                    }
                    else if (ikkunatCLB.GetItemCheckState(1).Equals(CheckState.Indeterminate) || ikkunatCLB.GetItemCheckState(1).Equals(CheckState.Unchecked))
                    {
                        if (sininenIkkuna != null)
                        {
                            sininenIkkuna.Close();
                            sininenIkkuna.Dispose();
                        }
                    }
                    break;

                case "Keltainen ikkuna":
                    if (ikkunatCLB.GetItemCheckState(2).Equals(CheckState.Checked))
                    {
                        keltainenIkkuna = new Form();

                        keltainenIkkuna.Text = "Keltainen ikkuna";

                        keltainenIkkuna.BackColor = Color.Yellow;

                        keltainenIkkuna.Show();

                        keltainenIkkuna.Location = new Point(this.Location.X + 50, this.Location.Y + 70);
                    }
                    else if (ikkunatCLB.GetItemCheckState(2).Equals(CheckState.Indeterminate) || ikkunatCLB.GetItemCheckState(2).Equals(CheckState.Unchecked))
                    {
                        if (keltainenIkkuna != null)
                        {
                            keltainenIkkuna.Close();
                            keltainenIkkuna.Dispose();
                        }
                    }
                    break;
            }      

        }

        private void varalistaCLB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (varalistaCLB.Items.Count != 0)
                varalistaCLB.Items.RemoveAt(varalistaCLB.SelectedIndex);
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            if (varalistaCLB.Items.Count == 0)
            {
                varalistaCLB.ForeColor = Color.DarkCyan;
                varalistaCLB.Items.AddRange(ikkunatCLB.Items);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (varalistaCLB.Items.Count != 0)
                varalistaCLB.Items.Clear();
        }
    }
}
