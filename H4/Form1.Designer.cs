
namespace H4
{
    partial class H4Label
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
            this.kirjautumisLabel = new System.Windows.Forms.Label();
            this.tunnusLabel = new System.Windows.Forms.Label();
            this.salasanaLabel = new System.Windows.Forms.Label();
            this.tunnusBox = new System.Windows.Forms.TextBox();
            this.salasanaBox = new System.Windows.Forms.TextBox();
            this.kirjauduBtn = new System.Windows.Forms.Button();
            this.palauteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kirjautumisLabel
            // 
            this.kirjautumisLabel.AutoSize = true;
            this.kirjautumisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kirjautumisLabel.Location = new System.Drawing.Point(228, 58);
            this.kirjautumisLabel.Name = "kirjautumisLabel";
            this.kirjautumisLabel.Size = new System.Drawing.Size(211, 29);
            this.kirjautumisLabel.TabIndex = 0;
            this.kirjautumisLabel.Text = "Kirjautumislomake";
            // 
            // tunnusLabel
            // 
            this.tunnusLabel.AutoSize = true;
            this.tunnusLabel.Location = new System.Drawing.Point(82, 119);
            this.tunnusLabel.Name = "tunnusLabel";
            this.tunnusLabel.Size = new System.Drawing.Size(102, 17);
            this.tunnusLabel.TabIndex = 1;
            this.tunnusLabel.Text = "Käyttäjätunnus";
            this.tunnusLabel.MouseLeave += new System.EventHandler(this.tunnusLabel_MouseLeave);
            this.tunnusLabel.MouseHover += new System.EventHandler(this.tunnusLabel_MouseHover);
            // 
            // salasanaLabel
            // 
            this.salasanaLabel.AutoSize = true;
            this.salasanaLabel.Location = new System.Drawing.Point(85, 156);
            this.salasanaLabel.Name = "salasanaLabel";
            this.salasanaLabel.Size = new System.Drawing.Size(67, 17);
            this.salasanaLabel.TabIndex = 2;
            this.salasanaLabel.Text = "Salasana";
            this.salasanaLabel.MouseLeave += new System.EventHandler(this.salasanaLabel_MouseLeave);
            this.salasanaLabel.MouseHover += new System.EventHandler(this.salasanaLabel_MouseHover);
            // 
            // tunnusBox
            // 
            this.tunnusBox.Location = new System.Drawing.Point(233, 119);
            this.tunnusBox.Name = "tunnusBox";
            this.tunnusBox.Size = new System.Drawing.Size(250, 22);
            this.tunnusBox.TabIndex = 3;
            // 
            // salasanaBox
            // 
            this.salasanaBox.Location = new System.Drawing.Point(233, 156);
            this.salasanaBox.Name = "salasanaBox";
            this.salasanaBox.PasswordChar = '*';
            this.salasanaBox.Size = new System.Drawing.Size(250, 22);
            this.salasanaBox.TabIndex = 4;
            // 
            // kirjauduBtn
            // 
            this.kirjauduBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.kirjauduBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kirjauduBtn.Location = new System.Drawing.Point(291, 215);
            this.kirjauduBtn.Name = "kirjauduBtn";
            this.kirjauduBtn.Size = new System.Drawing.Size(117, 29);
            this.kirjauduBtn.TabIndex = 5;
            this.kirjauduBtn.Text = "Kirjaudu sisään";
            this.kirjauduBtn.UseVisualStyleBackColor = true;
            this.kirjauduBtn.Click += new System.EventHandler(this.kirjauduBtn_Click);
            // 
            // palauteLabel
            // 
            this.palauteLabel.AutoSize = true;
            this.palauteLabel.BackColor = System.Drawing.Color.Fuchsia;
            this.palauteLabel.Location = new System.Drawing.Point(556, 141);
            this.palauteLabel.Name = "palauteLabel";
            this.palauteLabel.Size = new System.Drawing.Size(0, 17);
            this.palauteLabel.TabIndex = 6;
            this.palauteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.palauteLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.palauteLabel_MouseDown);
            this.palauteLabel.MouseHover += new System.EventHandler(this.palauteLabel_MouseHover);
            // 
            // H4Label
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.palauteLabel);
            this.Controls.Add(this.kirjauduBtn);
            this.Controls.Add(this.salasanaBox);
            this.Controls.Add(this.tunnusBox);
            this.Controls.Add(this.salasanaLabel);
            this.Controls.Add(this.tunnusLabel);
            this.Controls.Add(this.kirjautumisLabel);
            this.Name = "H4Label";
            this.Text = "H4Label";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kirjautumisLabel;
        private System.Windows.Forms.Label tunnusLabel;
        private System.Windows.Forms.Label salasanaLabel;
        private System.Windows.Forms.TextBox tunnusBox;
        private System.Windows.Forms.TextBox salasanaBox;
        private System.Windows.Forms.Button kirjauduBtn;
        private System.Windows.Forms.Label palauteLabel;
    }
}

