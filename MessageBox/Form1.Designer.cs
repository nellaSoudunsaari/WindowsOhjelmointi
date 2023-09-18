
namespace MessageBox
{
    partial class H6RichTextbox
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
            this.richTekstikenttä = new System.Windows.Forms.RichTextBox();
            this.tiedostoKentta = new System.Windows.Forms.TextBox();
            this.nimiKentta = new System.Windows.Forms.TextBox();
            this.latausBtn = new System.Windows.Forms.Button();
            this.tallennusBtn = new System.Windows.Forms.Button();
            this.siivoaBtn = new System.Windows.Forms.Button();
            this.lopetaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTekstikenttä
            // 
            this.richTekstikenttä.AcceptsTab = true;
            this.richTekstikenttä.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTekstikenttä.Location = new System.Drawing.Point(24, 35);
            this.richTekstikenttä.Name = "richTekstikenttä";
            this.richTekstikenttä.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTekstikenttä.Size = new System.Drawing.Size(190, 96);
            this.richTekstikenttä.TabIndex = 0;
            this.richTekstikenttä.Text = "";
            this.richTekstikenttä.ZoomFactor = 2F;
            this.richTekstikenttä.VScroll += new System.EventHandler(this.richTekstikenttä_VScroll);
            // 
            // tiedostoKentta
            // 
            this.tiedostoKentta.AcceptsReturn = true;
            this.tiedostoKentta.AcceptsTab = true;
            this.tiedostoKentta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tiedostoKentta.Location = new System.Drawing.Point(24, 149);
            this.tiedostoKentta.Multiline = true;
            this.tiedostoKentta.Name = "tiedostoKentta";
            this.tiedostoKentta.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tiedostoKentta.Size = new System.Drawing.Size(190, 96);
            this.tiedostoKentta.TabIndex = 1;
            // 
            // nimiKentta
            // 
            this.nimiKentta.Location = new System.Drawing.Point(24, 251);
            this.nimiKentta.Name = "nimiKentta";
            this.nimiKentta.Size = new System.Drawing.Size(190, 22);
            this.nimiKentta.TabIndex = 2;
            this.nimiKentta.Text = "C:\\temp\\arkisto\\muistio.rtf";
            // 
            // latausBtn
            // 
            this.latausBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.latausBtn.Location = new System.Drawing.Point(283, 35);
            this.latausBtn.Name = "latausBtn";
            this.latausBtn.Size = new System.Drawing.Size(137, 23);
            this.latausBtn.TabIndex = 3;
            this.latausBtn.Text = "Lataa tiedosto";
            this.latausBtn.UseVisualStyleBackColor = true;
            // 
            // tallennusBtn
            // 
            this.tallennusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tallennusBtn.Location = new System.Drawing.Point(283, 76);
            this.tallennusBtn.Name = "tallennusBtn";
            this.tallennusBtn.Size = new System.Drawing.Size(137, 23);
            this.tallennusBtn.TabIndex = 4;
            this.tallennusBtn.Text = "Tallenna tiedosto";
            this.tallennusBtn.UseVisualStyleBackColor = true;
            // 
            // siivoaBtn
            // 
            this.siivoaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.siivoaBtn.Location = new System.Drawing.Point(283, 117);
            this.siivoaBtn.Name = "siivoaBtn";
            this.siivoaBtn.Size = new System.Drawing.Size(137, 23);
            this.siivoaBtn.TabIndex = 5;
            this.siivoaBtn.Text = "Siivoa tekstikentät";
            this.siivoaBtn.UseVisualStyleBackColor = true;
            // 
            // lopetaBtn
            // 
            this.lopetaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lopetaBtn.Location = new System.Drawing.Point(283, 159);
            this.lopetaBtn.Name = "lopetaBtn";
            this.lopetaBtn.Size = new System.Drawing.Size(137, 23);
            this.lopetaBtn.TabIndex = 6;
            this.lopetaBtn.Text = "Sulje sovellus";
            this.lopetaBtn.UseVisualStyleBackColor = true;
            // 
            // H6RichTextbox
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
            this.Name = "H6RichTextbox";
            this.Text = "H6RichTextbox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTekstikenttä;
        private System.Windows.Forms.TextBox tiedostoKentta;
        private System.Windows.Forms.TextBox nimiKentta;
        private System.Windows.Forms.Button latausBtn;
        private System.Windows.Forms.Button tallennusBtn;
        private System.Windows.Forms.Button siivoaBtn;
        private System.Windows.Forms.Button lopetaBtn;
    }
}

