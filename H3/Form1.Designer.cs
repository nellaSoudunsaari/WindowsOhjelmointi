
namespace H3
{
    partial class H3TxtBox
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
            this.lauseKentta = new System.Windows.Forms.TextBox();
            this.arkistoKentta = new System.Windows.Forms.TextBox();
            this.kopioBtn = new System.Windows.Forms.Button();
            this.salausBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lauseKentta
            // 
            this.lauseKentta.Location = new System.Drawing.Point(70, 94);
            this.lauseKentta.Name = "lauseKentta";
            this.lauseKentta.Size = new System.Drawing.Size(260, 22);
            this.lauseKentta.TabIndex = 0;
            this.lauseKentta.Text = "Kirjoita lause tähän ";
            this.lauseKentta.TextChanged += new System.EventHandler(this.lauseKentta_TextChanged);
            // 
            // arkistoKentta
            // 
            this.arkistoKentta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arkistoKentta.Location = new System.Drawing.Point(70, 138);
            this.arkistoKentta.Multiline = true;
            this.arkistoKentta.Name = "arkistoKentta";
            this.arkistoKentta.Size = new System.Drawing.Size(260, 171);
            this.arkistoKentta.TabIndex = 1;
            this.arkistoKentta.TextChanged += new System.EventHandler(this.arkistoKentta_TextChanged);
            // 
            // kopioBtn
            // 
            this.kopioBtn.Location = new System.Drawing.Point(359, 94);
            this.kopioBtn.Name = "kopioBtn";
            this.kopioBtn.Size = new System.Drawing.Size(102, 32);
            this.kopioBtn.TabIndex = 2;
            this.kopioBtn.Text = "Kopioi teksti";
            this.kopioBtn.UseVisualStyleBackColor = true;
            this.kopioBtn.Click += new System.EventHandler(this.kopioBtn_Click);
            // 
            // salausBtn
            // 
            this.salausBtn.Location = new System.Drawing.Point(359, 138);
            this.salausBtn.Name = "salausBtn";
            this.salausBtn.Size = new System.Drawing.Size(102, 32);
            this.salausBtn.TabIndex = 3;
            this.salausBtn.Text = "Salaa teksti";
            this.salausBtn.UseVisualStyleBackColor = true;
            this.salausBtn.Click += new System.EventHandler(this.salausBtn_Click);
            // 
            // H3TxtBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salausBtn);
            this.Controls.Add(this.kopioBtn);
            this.Controls.Add(this.arkistoKentta);
            this.Controls.Add(this.lauseKentta);
            this.Name = "H3TxtBox";
            this.Text = "H3TxtBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lauseKentta;
        private System.Windows.Forms.TextBox arkistoKentta;
        private System.Windows.Forms.Button kopioBtn;
        private System.Windows.Forms.Button salausBtn;
    }
}

