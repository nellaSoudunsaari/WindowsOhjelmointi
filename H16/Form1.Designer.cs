
namespace H16
{
    partial class H16Ikalaskin
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
            this.pvmLabel = new System.Windows.Forms.Label();
            this.pvmValitsin = new System.Windows.Forms.DateTimePicker();
            this.ikaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pvmLabel
            // 
            this.pvmLabel.AutoSize = true;
            this.pvmLabel.Location = new System.Drawing.Point(13, 13);
            this.pvmLabel.Name = "pvmLabel";
            this.pvmLabel.Size = new System.Drawing.Size(95, 17);
            this.pvmLabel.TabIndex = 0;
            this.pvmLabel.Text = "Päivämäärä:  ";
            // 
            // pvmValitsin
            // 
            this.pvmValitsin.Location = new System.Drawing.Point(16, 76);
            this.pvmValitsin.Name = "pvmValitsin";
            this.pvmValitsin.Size = new System.Drawing.Size(200, 22);
            this.pvmValitsin.TabIndex = 1;
            this.pvmValitsin.ValueChanged += new System.EventHandler(this.pvmValitsin_ValueChanged);
            // 
            // ikaLabel
            // 
            this.ikaLabel.AutoSize = true;
            this.ikaLabel.Location = new System.Drawing.Point(13, 151);
            this.ikaLabel.Name = "ikaLabel";
            this.ikaLabel.Size = new System.Drawing.Size(67, 17);
            this.ikaLabel.TabIndex = 2;
            this.ikaLabel.Text = "Ikäsi nyt: ";
            // 
            // H16Ikalaskin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 211);
            this.Controls.Add(this.ikaLabel);
            this.Controls.Add(this.pvmValitsin);
            this.Controls.Add(this.pvmLabel);
            this.Name = "H16Ikalaskin";
            this.Text = "H16Ikälaskin";
            this.Load += new System.EventHandler(this.H16Ikalaskin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pvmLabel;
        private System.Windows.Forms.DateTimePicker pvmValitsin;
        private System.Windows.Forms.Label ikaLabel;
    }
}

