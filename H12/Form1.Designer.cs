
namespace H12
{
    partial class H12Imagelist
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
            this.components = new System.ComponentModel.Container();
            this.kuvaLista = new System.Windows.Forms.ImageList(this.components);
            this.kuvanVaihtoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kuvaLista
            // 
            this.kuvaLista.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.kuvaLista.ImageSize = new System.Drawing.Size(256, 256);
            this.kuvaLista.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // kuvanVaihtoBtn
            // 
            this.kuvanVaihtoBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.kuvanVaihtoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kuvanVaihtoBtn.Location = new System.Drawing.Point(307, 397);
            this.kuvanVaihtoBtn.Name = "kuvanVaihtoBtn";
            this.kuvanVaihtoBtn.Size = new System.Drawing.Size(162, 23);
            this.kuvanVaihtoBtn.TabIndex = 0;
            this.kuvanVaihtoBtn.Text = "Vaihda taustakuvaa";
            this.kuvanVaihtoBtn.UseVisualStyleBackColor = false;
            this.kuvanVaihtoBtn.Click += new System.EventHandler(this.kuvanVaihtoBtn_Click);
            // 
            // H12Imagelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kuvanVaihtoBtn);
            this.Name = "H12Imagelist";
            this.Text = "H12Imagelist";
            this.Load += new System.EventHandler(this.H12Imagelist_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList kuvaLista;
        private System.Windows.Forms.Button kuvanVaihtoBtn;
    }
}

