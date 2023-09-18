
namespace H8
{
    partial class H8Radiobtn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bgGroupbox = new System.Windows.Forms.GroupBox();
            this.sijaintiGroupbox = new System.Windows.Forms.GroupBox();
            this.bgValinta1 = new System.Windows.Forms.RadioButton();
            this.bgValinta2 = new System.Windows.Forms.RadioButton();
            this.bgValinta3 = new System.Windows.Forms.RadioButton();
            this.bgCenter = new System.Windows.Forms.RadioButton();
            this.bgNone = new System.Windows.Forms.RadioButton();
            this.bgStretch = new System.Windows.Forms.RadioButton();
            this.bgTile = new System.Windows.Forms.RadioButton();
            this.bgZoom = new System.Windows.Forms.RadioButton();
            this.bgGroupbox.SuspendLayout();
            this.sijaintiGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // bgGroupbox
            // 
            this.bgGroupbox.Controls.Add(this.bgValinta3);
            this.bgGroupbox.Controls.Add(this.bgValinta2);
            this.bgGroupbox.Controls.Add(this.bgValinta1);
            this.bgGroupbox.Location = new System.Drawing.Point(39, 169);
            this.bgGroupbox.Name = "bgGroupbox";
            this.bgGroupbox.Size = new System.Drawing.Size(389, 100);
            this.bgGroupbox.TabIndex = 2;
            this.bgGroupbox.TabStop = false;
            this.bgGroupbox.Text = "Taustakuva";
            // 
            // sijaintiGroupbox
            // 
            this.sijaintiGroupbox.Controls.Add(this.bgZoom);
            this.sijaintiGroupbox.Controls.Add(this.bgTile);
            this.sijaintiGroupbox.Controls.Add(this.bgStretch);
            this.sijaintiGroupbox.Controls.Add(this.bgNone);
            this.sijaintiGroupbox.Controls.Add(this.bgCenter);
            this.sijaintiGroupbox.Location = new System.Drawing.Point(42, 312);
            this.sijaintiGroupbox.Name = "sijaintiGroupbox";
            this.sijaintiGroupbox.Size = new System.Drawing.Size(386, 100);
            this.sijaintiGroupbox.TabIndex = 3;
            this.sijaintiGroupbox.TabStop = false;
            this.sijaintiGroupbox.Text = "Taustakuvan sommittelu";
            // 
            // bgValinta1
            // 
            this.bgValinta1.AutoSize = true;
            this.bgValinta1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bgValinta1.Location = new System.Drawing.Point(6, 34);
            this.bgValinta1.Name = "bgValinta1";
            this.bgValinta1.Size = new System.Drawing.Size(115, 21);
            this.bgValinta1.TabIndex = 0;
            this.bgValinta1.Text = "Taustakuva 1";
            this.bgValinta1.UseVisualStyleBackColor = true;
            this.bgValinta1.CheckedChanged += new System.EventHandler(this.bgValinta1_CheckedChanged);
            // 
            // bgValinta2
            // 
            this.bgValinta2.AutoSize = true;
            this.bgValinta2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bgValinta2.Location = new System.Drawing.Point(123, 34);
            this.bgValinta2.Name = "bgValinta2";
            this.bgValinta2.Size = new System.Drawing.Size(115, 21);
            this.bgValinta2.TabIndex = 1;
            this.bgValinta2.Text = "Taustakuva 2";
            this.bgValinta2.UseVisualStyleBackColor = true;
            this.bgValinta2.CheckedChanged += new System.EventHandler(this.bgValinta2_CheckedChanged);
            // 
            // bgValinta3
            // 
            this.bgValinta3.AutoSize = true;
            this.bgValinta3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bgValinta3.Location = new System.Drawing.Point(240, 34);
            this.bgValinta3.Name = "bgValinta3";
            this.bgValinta3.Size = new System.Drawing.Size(115, 21);
            this.bgValinta3.TabIndex = 2;
            this.bgValinta3.Text = "Taustakuva 3";
            this.bgValinta3.UseVisualStyleBackColor = true;
            this.bgValinta3.CheckedChanged += new System.EventHandler(this.bgValinta3_CheckedChanged);
            // 
            // bgCenter
            // 
            this.bgCenter.AutoSize = true;
            this.bgCenter.Location = new System.Drawing.Point(7, 32);
            this.bgCenter.Name = "bgCenter";
            this.bgCenter.Size = new System.Drawing.Size(71, 21);
            this.bgCenter.TabIndex = 0;
            this.bgCenter.Text = "Center";
            this.bgCenter.UseVisualStyleBackColor = true;
            this.bgCenter.CheckedChanged += new System.EventHandler(this.bgCenter_CheckedChanged);
            // 
            // bgNone
            // 
            this.bgNone.AutoSize = true;
            this.bgNone.Location = new System.Drawing.Point(124, 32);
            this.bgNone.Name = "bgNone";
            this.bgNone.Size = new System.Drawing.Size(63, 21);
            this.bgNone.TabIndex = 1;
            this.bgNone.Text = "None";
            this.bgNone.UseVisualStyleBackColor = true;
            this.bgNone.CheckedChanged += new System.EventHandler(this.bgNone_CheckedChanged);
            // 
            // bgStretch
            // 
            this.bgStretch.AutoSize = true;
            this.bgStretch.Location = new System.Drawing.Point(241, 32);
            this.bgStretch.Name = "bgStretch";
            this.bgStretch.Size = new System.Drawing.Size(74, 21);
            this.bgStretch.TabIndex = 2;
            this.bgStretch.Text = "Stretch";
            this.bgStretch.UseVisualStyleBackColor = true;
            this.bgStretch.CheckedChanged += new System.EventHandler(this.bgStretch_CheckedChanged);
            // 
            // bgTile
            // 
            this.bgTile.AutoSize = true;
            this.bgTile.Location = new System.Drawing.Point(7, 60);
            this.bgTile.Name = "bgTile";
            this.bgTile.Size = new System.Drawing.Size(52, 21);
            this.bgTile.TabIndex = 3;
            this.bgTile.Text = "Tile";
            this.bgTile.UseVisualStyleBackColor = true;
            this.bgTile.CheckedChanged += new System.EventHandler(this.bgTile_CheckedChanged);
            // 
            // bgZoom
            // 
            this.bgZoom.AutoSize = true;
            this.bgZoom.Location = new System.Drawing.Point(124, 60);
            this.bgZoom.Name = "bgZoom";
            this.bgZoom.Size = new System.Drawing.Size(65, 21);
            this.bgZoom.TabIndex = 4;
            this.bgZoom.Text = "Zoom";
            this.bgZoom.UseVisualStyleBackColor = true;
            this.bgZoom.CheckedChanged += new System.EventHandler(this.bgZoom_CheckedChanged);
            // 
            // H8Radiobtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sijaintiGroupbox);
            this.Controls.Add(this.bgGroupbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "H8Radiobtn";
            this.Text = "H8Radiobtn";
            this.bgGroupbox.ResumeLayout(false);
            this.bgGroupbox.PerformLayout();
            this.sijaintiGroupbox.ResumeLayout(false);
            this.sijaintiGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox bgGroupbox;
        private System.Windows.Forms.RadioButton bgValinta3;
        private System.Windows.Forms.RadioButton bgValinta2;
        private System.Windows.Forms.RadioButton bgValinta1;
        private System.Windows.Forms.GroupBox sijaintiGroupbox;
        private System.Windows.Forms.RadioButton bgZoom;
        private System.Windows.Forms.RadioButton bgTile;
        private System.Windows.Forms.RadioButton bgStretch;
        private System.Windows.Forms.RadioButton bgNone;
        private System.Windows.Forms.RadioButton bgCenter;
    }
}

