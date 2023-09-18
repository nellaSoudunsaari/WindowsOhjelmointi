
namespace H17
{
    partial class H17PictureBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(H17PictureBox));
            this.kuvaLaatikko = new System.Windows.Forms.PictureBox();
            this.kuvaLista = new System.Windows.Forms.ImageList(this.components);
            this.ajastin = new System.Windows.Forms.Timer(this.components);
            this.ilmoitusIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.kaynnistysBtn = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kuvaLaatikko)).BeginInit();
            this.SuspendLayout();
            // 
            // kuvaLaatikko
            // 
            this.kuvaLaatikko.Location = new System.Drawing.Point(231, 101);
            this.kuvaLaatikko.Name = "kuvaLaatikko";
            this.kuvaLaatikko.Padding = new System.Windows.Forms.Padding(20);
            this.kuvaLaatikko.Size = new System.Drawing.Size(308, 225);
            this.kuvaLaatikko.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kuvaLaatikko.TabIndex = 0;
            this.kuvaLaatikko.TabStop = false;
            // 
            // kuvaLista
            // 
            this.kuvaLista.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("kuvaLista.ImageStream")));
            this.kuvaLista.TransparentColor = System.Drawing.Color.Transparent;
            this.kuvaLista.Images.SetKeyName(0, "karhu.jpg");
            this.kuvaLista.Images.SetKeyName(1, "kirahvi.jpg");
            this.kuvaLista.Images.SetKeyName(2, "kissa.jpg");
            // 
            // ajastin
            // 
            this.ajastin.Interval = 1000;
            this.ajastin.Tick += new System.EventHandler(this.ajastin_Tick);
            // 
            // ilmoitusIcon
            // 
            this.ilmoitusIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ilmoitusIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ilmoitusIcon.Icon")));
            this.ilmoitusIcon.Text = "H8_2";
            this.ilmoitusIcon.Visible = true;
            // 
            // kaynnistysBtn
            // 
            this.kaynnistysBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kaynnistysBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kaynnistysBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.kaynnistysBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaynnistysBtn.Location = new System.Drawing.Point(320, 365);
            this.kaynnistysBtn.Name = "kaynnistysBtn";
            this.kaynnistysBtn.Size = new System.Drawing.Size(119, 50);
            this.kaynnistysBtn.TabIndex = 1;
            this.kaynnistysBtn.Text = "Käynnistä esitys";
            this.kaynnistysBtn.UseVisualStyleBackColor = true;
            this.kaynnistysBtn.Click += new System.EventHandler(this.kaynnistysBtn_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.infoLabel.Location = new System.Drawing.Point(296, 39);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(157, 17);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "Esitys on meneillään";
            // 
            // H17PictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.kaynnistysBtn);
            this.Controls.Add(this.kuvaLaatikko);
            this.Name = "H17PictureBox";
            this.Text = "H17PictureBox";
            ((System.ComponentModel.ISupportInitialize)(this.kuvaLaatikko)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox kuvaLaatikko;
        private System.Windows.Forms.ImageList kuvaLista;
        private System.Windows.Forms.Timer ajastin;
        private System.Windows.Forms.NotifyIcon ilmoitusIcon;
        private System.Windows.Forms.Button kaynnistysBtn;
        private System.Windows.Forms.Label infoLabel;
    }
}

