using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// HOX!!! tää ei toimi mun läppärillä koska internet explorer on yks fossiili eikä sitä
// tueta enää, jolloinka tää ohjelma ei tiedä millä se pyörittäis webbrowseria
// Testaisin ohjelmaa jollain muulla kontrollerilla mutta ne vaikutti kaikki maksullisilta
// ja liian paljoa työtä vaativalle

namespace H15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webSelain.Url = new Uri("https://www.redu.fi/");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Size uusiKoko = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);
            webSelain.Size = uusiKoko;
        }

        private void takaisinBtn_Click(object sender, EventArgs e)
        {
            webSelain.GoBack();
        }

        private void seuraavaBtn_Click(object sender, EventArgs e)
        {
            webSelain.GoForward();
        }

        private void kotiBtn_Click(object sender, EventArgs e)
        {
            webSelain.GoHome();
        }

        private void hakuKenttä_KeyUp(object sender, KeyEventArgs e)
        {
            if(!string.IsNullOrEmpty(hakuKenttä.Text) && e.KeyCode.Equals(Keys.Enter))
            {
                Uri UriToNavigate = new Uri(string.Format("https://www.google.com/searchq={0}", hakuKenttä.Text));
                webSelain.Navigate(UriToNavigate);
            }
        }

        private void webSelain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if(suosikitLista.Items.IndexOf(webSelain.Document.Url.ToString()) == -1)
            {
                suosikitLista.Items.Add(webSelain.Document.Url.ToString());
                suosikitLista.Text = webSelain.Document.Url.ToString();
            }
        }

        private void suosikitLista_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(suosikitLista.Text) && e.KeyCode.Equals(Keys.Enter))
            {
                if (!suosikitLista.Text.StartsWith("http://") && suosikitLista.Text.StartsWith("https://") && !suosikitLista.Text.StartsWith("file://"))
                    suosikitLista.Text = "http://" + suosikitLista.Text;

                webSelain.Navigate(suosikitLista.Text);
            }
        }

        private void suosikitLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            webSelain.Url = new Uri(suosikitLista.SelectedItem.ToString());
        }
    }
}
