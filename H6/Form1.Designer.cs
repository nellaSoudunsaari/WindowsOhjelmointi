
namespace H6
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
            this.lopetaBtn = new System.Windows.Forms.Button();
            this.siivoaBtn = new System.Windows.Forms.Button();
            this.tallennusBtn = new System.Windows.Forms.Button();
            this.latausBtn = new System.Windows.Forms.Button();
            this.nimiKentta = new System.Windows.Forms.TextBox();
            this.tiedostoKentta = new System.Windows.Forms.TextBox();
            this.richTekstikenttä = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lopetaBtn
            // 
            this.lopetaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lopetaBtn.Location = new System.Drawing.Point(616, 149);
            this.lopetaBtn.Name = "lopetaBtn";
            this.lopetaBtn.Size = new System.Drawing.Size(137, 23);
            this.lopetaBtn.TabIndex = 13;
            this.lopetaBtn.Text = "Sulje sovellus";
            this.lopetaBtn.UseVisualStyleBackColor = true;
            this.lopetaBtn.Click += new System.EventHandler(this.lopetaBtn_Click);
            // 
            // siivoaBtn
            // 
            this.siivoaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.siivoaBtn.Location = new System.Drawing.Point(616, 107);
            this.siivoaBtn.Name = "siivoaBtn";
            this.siivoaBtn.Size = new System.Drawing.Size(137, 23);
            this.siivoaBtn.TabIndex = 12;
            this.siivoaBtn.Text = "Siivoa tekstikentät";
            this.siivoaBtn.UseVisualStyleBackColor = true;
            this.siivoaBtn.Click += new System.EventHandler(this.siivoaBtn_Click);
            // 
            // tallennusBtn
            // 
            this.tallennusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tallennusBtn.Location = new System.Drawing.Point(616, 66);
            this.tallennusBtn.Name = "tallennusBtn";
            this.tallennusBtn.Size = new System.Drawing.Size(137, 23);
            this.tallennusBtn.TabIndex = 11;
            this.tallennusBtn.Text = "Tallenna tiedosto";
            this.tallennusBtn.UseVisualStyleBackColor = true;
            this.tallennusBtn.Click += new System.EventHandler(this.tallennusBtn_Click);
            // 
            // latausBtn
            // 
            this.latausBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.latausBtn.Location = new System.Drawing.Point(616, 25);
            this.latausBtn.Name = "latausBtn";
            this.latausBtn.Size = new System.Drawing.Size(137, 23);
            this.latausBtn.TabIndex = 10;
            this.latausBtn.Text = "Lataa tiedosto";
            this.latausBtn.UseVisualStyleBackColor = true;
            this.latausBtn.Click += new System.EventHandler(this.latausBtn_Click);
            // 
            // nimiKentta
            // 
            this.nimiKentta.Location = new System.Drawing.Point(12, 292);
            this.nimiKentta.Name = "nimiKentta";
            this.nimiKentta.Size = new System.Drawing.Size(190, 22);
            this.nimiKentta.TabIndex = 9;
            this.nimiKentta.Text = "C:\\temp\\arkisto\\muistio.rtf";
            // 
            // tiedostoKentta
            // 
            this.tiedostoKentta.AcceptsReturn = true;
            this.tiedostoKentta.AcceptsTab = true;
            this.tiedostoKentta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tiedostoKentta.Location = new System.Drawing.Point(12, 153);
            this.tiedostoKentta.Multiline = true;
            this.tiedostoKentta.Name = "tiedostoKentta";
            this.tiedostoKentta.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tiedostoKentta.Size = new System.Drawing.Size(561, 123);
            this.tiedostoKentta.TabIndex = 8;
            // 
            // richTekstikenttä
            // 
            this.richTekstikenttä.AcceptsTab = true;
            this.richTekstikenttä.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTekstikenttä.Location = new System.Drawing.Point(12, 27);
            this.richTekstikenttä.Name = "richTekstikenttä";
            this.richTekstikenttä.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTekstikenttä.Size = new System.Drawing.Size(561, 120);
            this.richTekstikenttä.TabIndex = 7;
            this.richTekstikenttä.Text = "";
            this.richTekstikenttä.ZoomFactor = 2F;
            this.richTekstikenttä.VScroll += new System.EventHandler(this.richTekstikenttä_VScroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lopetaBtn);
            this.Controls.Add(this.siivoaBtn);
            this.Controls.Add(this.tallennusBtn);
            this.Controls.Add(this.latausBtn);
            this.Controls.Add(this.nimiKentta);
            this.Controls.Add(this.tiedostoKentta);
            this.Controls.Add(this.richTekstikenttä);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lopetaBtn;
        private System.Windows.Forms.Button siivoaBtn;
        private System.Windows.Forms.Button tallennusBtn;
        private System.Windows.Forms.Button latausBtn;
        private System.Windows.Forms.TextBox nimiKentta;
        private System.Windows.Forms.TextBox tiedostoKentta;
        private System.Windows.Forms.RichTextBox richTekstikenttä;
    }
}

