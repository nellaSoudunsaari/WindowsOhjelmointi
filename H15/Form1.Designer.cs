
namespace H15
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webSelain = new System.Windows.Forms.WebBrowser();
            this.osoiteLabel = new System.Windows.Forms.Label();
            this.osoiteKenttä = new System.Windows.Forms.TextBox();
            this.hakuLabel = new System.Windows.Forms.Label();
            this.hakuKenttä = new System.Windows.Forms.TextBox();
            this.suosikitLista = new System.Windows.Forms.ComboBox();
            this.seuraavaBtn = new System.Windows.Forms.Button();
            this.kotiBtn = new System.Windows.Forms.Button();
            this.takaisinBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webSelain
            // 
            this.webSelain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webSelain.Location = new System.Drawing.Point(0, 0);
            this.webSelain.MinimumSize = new System.Drawing.Size(20, 20);
            this.webSelain.Name = "webSelain";
            this.webSelain.Size = new System.Drawing.Size(988, 529);
            this.webSelain.TabIndex = 0;
            this.webSelain.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webSelain_DocumentCompleted);
            // 
            // osoiteLabel
            // 
            this.osoiteLabel.AutoSize = true;
            this.osoiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osoiteLabel.Location = new System.Drawing.Point(130, 21);
            this.osoiteLabel.Name = "osoiteLabel";
            this.osoiteLabel.Size = new System.Drawing.Size(58, 18);
            this.osoiteLabel.TabIndex = 4;
            this.osoiteLabel.Text = "Osoite";
            // 
            // osoiteKenttä
            // 
            this.osoiteKenttä.Location = new System.Drawing.Point(188, 18);
            this.osoiteKenttä.Name = "osoiteKenttä";
            this.osoiteKenttä.Size = new System.Drawing.Size(200, 22);
            this.osoiteKenttä.TabIndex = 5;
            // 
            // hakuLabel
            // 
            this.hakuLabel.AutoSize = true;
            this.hakuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hakuLabel.Location = new System.Drawing.Point(556, 19);
            this.hakuLabel.Name = "hakuLabel";
            this.hakuLabel.Size = new System.Drawing.Size(47, 18);
            this.hakuLabel.TabIndex = 6;
            this.hakuLabel.Text = "Haku";
            // 
            // hakuKenttä
            // 
            this.hakuKenttä.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.hakuKenttä.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.hakuKenttä.Location = new System.Drawing.Point(609, 18);
            this.hakuKenttä.Name = "hakuKenttä";
            this.hakuKenttä.Size = new System.Drawing.Size(200, 22);
            this.hakuKenttä.TabIndex = 7;
            this.hakuKenttä.KeyUp += new System.Windows.Forms.KeyEventHandler(this.hakuKenttä_KeyUp);
            // 
            // suosikitLista
            // 
            this.suosikitLista.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.suosikitLista.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.suosikitLista.FormattingEnabled = true;
            this.suosikitLista.Location = new System.Drawing.Point(394, 18);
            this.suosikitLista.Name = "suosikitLista";
            this.suosikitLista.Size = new System.Drawing.Size(156, 24);
            this.suosikitLista.TabIndex = 8;
            this.suosikitLista.SelectedIndexChanged += new System.EventHandler(this.suosikitLista_SelectedIndexChanged);
            this.suosikitLista.KeyUp += new System.Windows.Forms.KeyEventHandler(this.suosikitLista_KeyUp);
            // 
            // seuraavaBtn
            // 
            this.seuraavaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seuraavaBtn.Image = global::H15.Properties.Resources.nuolioik;
            this.seuraavaBtn.Location = new System.Drawing.Point(91, 13);
            this.seuraavaBtn.Name = "seuraavaBtn";
            this.seuraavaBtn.Size = new System.Drawing.Size(33, 33);
            this.seuraavaBtn.TabIndex = 3;
            this.seuraavaBtn.UseVisualStyleBackColor = true;
            this.seuraavaBtn.Click += new System.EventHandler(this.seuraavaBtn_Click);
            // 
            // kotiBtn
            // 
            this.kotiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kotiBtn.Image = global::H15.Properties.Resources.koti;
            this.kotiBtn.Location = new System.Drawing.Point(52, 13);
            this.kotiBtn.Name = "kotiBtn";
            this.kotiBtn.Size = new System.Drawing.Size(33, 33);
            this.kotiBtn.TabIndex = 2;
            this.kotiBtn.UseVisualStyleBackColor = true;
            this.kotiBtn.Click += new System.EventHandler(this.kotiBtn_Click);
            // 
            // takaisinBtn
            // 
            this.takaisinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.takaisinBtn.Image = global::H15.Properties.Resources.nuolivas;
            this.takaisinBtn.Location = new System.Drawing.Point(13, 13);
            this.takaisinBtn.Name = "takaisinBtn";
            this.takaisinBtn.Size = new System.Drawing.Size(33, 33);
            this.takaisinBtn.TabIndex = 1;
            this.takaisinBtn.UseVisualStyleBackColor = true;
            this.takaisinBtn.Click += new System.EventHandler(this.takaisinBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 529);
            this.Controls.Add(this.suosikitLista);
            this.Controls.Add(this.hakuKenttä);
            this.Controls.Add(this.hakuLabel);
            this.Controls.Add(this.osoiteKenttä);
            this.Controls.Add(this.osoiteLabel);
            this.Controls.Add(this.seuraavaBtn);
            this.Controls.Add(this.kotiBtn);
            this.Controls.Add(this.takaisinBtn);
            this.Controls.Add(this.webSelain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webSelain;
        private System.Windows.Forms.Button takaisinBtn;
        private System.Windows.Forms.Button kotiBtn;
        private System.Windows.Forms.Button seuraavaBtn;
        private System.Windows.Forms.Label osoiteLabel;
        private System.Windows.Forms.TextBox osoiteKenttä;
        private System.Windows.Forms.Label hakuLabel;
        private System.Windows.Forms.TextBox hakuKenttä;
        private System.Windows.Forms.ComboBox suosikitLista;
    }
}

