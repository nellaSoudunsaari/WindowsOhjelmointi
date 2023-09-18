
namespace H5
{
    partial class H5MaskedTextbox
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
            this.henktiedotLabel = new System.Windows.Forms.Label();
            this.nimiLabel = new System.Windows.Forms.Label();
            this.hetuLabel = new System.Windows.Forms.Label();
            this.puhnroLabel = new System.Windows.Forms.Label();
            this.spostiLabel = new System.Windows.Forms.Label();
            this.yhteenvetoLabel = new System.Windows.Forms.Label();
            this.yhteenvetoBox = new System.Windows.Forms.TextBox();
            this.rekisteroiBtn = new System.Windows.Forms.Button();
            this.nimiMbox = new System.Windows.Forms.MaskedTextBox();
            this.spostiMbox = new System.Windows.Forms.MaskedTextBox();
            this.puhnroMbox = new System.Windows.Forms.MaskedTextBox();
            this.hetuMbox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // henktiedotLabel
            // 
            this.henktiedotLabel.AutoSize = true;
            this.henktiedotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.henktiedotLabel.Location = new System.Drawing.Point(164, 9);
            this.henktiedotLabel.Name = "henktiedotLabel";
            this.henktiedotLabel.Size = new System.Drawing.Size(124, 25);
            this.henktiedotLabel.TabIndex = 0;
            this.henktiedotLabel.Text = "Henkilötiedot";
            // 
            // nimiLabel
            // 
            this.nimiLabel.AutoSize = true;
            this.nimiLabel.Location = new System.Drawing.Point(12, 64);
            this.nimiLabel.Name = "nimiLabel";
            this.nimiLabel.Size = new System.Drawing.Size(35, 17);
            this.nimiLabel.TabIndex = 1;
            this.nimiLabel.Text = "Nimi";
            // 
            // hetuLabel
            // 
            this.hetuLabel.AutoSize = true;
            this.hetuLabel.Location = new System.Drawing.Point(12, 105);
            this.hetuLabel.Name = "hetuLabel";
            this.hetuLabel.Size = new System.Drawing.Size(98, 17);
            this.hetuLabel.TabIndex = 3;
            this.hetuLabel.Text = "Henkilötunnus";
            // 
            // puhnroLabel
            // 
            this.puhnroLabel.AutoSize = true;
            this.puhnroLabel.Location = new System.Drawing.Point(12, 146);
            this.puhnroLabel.Name = "puhnroLabel";
            this.puhnroLabel.Size = new System.Drawing.Size(103, 17);
            this.puhnroLabel.TabIndex = 5;
            this.puhnroLabel.Text = "Puhelinnumero";
            // 
            // spostiLabel
            // 
            this.spostiLabel.AutoSize = true;
            this.spostiLabel.Location = new System.Drawing.Point(12, 189);
            this.spostiLabel.Name = "spostiLabel";
            this.spostiLabel.Size = new System.Drawing.Size(78, 17);
            this.spostiLabel.TabIndex = 7;
            this.spostiLabel.Text = "Sähköposti";
            // 
            // yhteenvetoLabel
            // 
            this.yhteenvetoLabel.AutoSize = true;
            this.yhteenvetoLabel.Location = new System.Drawing.Point(13, 243);
            this.yhteenvetoLabel.Name = "yhteenvetoLabel";
            this.yhteenvetoLabel.Size = new System.Drawing.Size(80, 17);
            this.yhteenvetoLabel.TabIndex = 9;
            this.yhteenvetoLabel.Text = "Yhteenveto";
            // 
            // yhteenvetoBox
            // 
            this.yhteenvetoBox.Location = new System.Drawing.Point(112, 243);
            this.yhteenvetoBox.Multiline = true;
            this.yhteenvetoBox.Name = "yhteenvetoBox";
            this.yhteenvetoBox.ReadOnly = true;
            this.yhteenvetoBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.yhteenvetoBox.Size = new System.Drawing.Size(221, 157);
            this.yhteenvetoBox.TabIndex = 10;
            // 
            // rekisteroiBtn
            // 
            this.rekisteroiBtn.Location = new System.Drawing.Point(169, 432);
            this.rekisteroiBtn.Name = "rekisteroiBtn";
            this.rekisteroiBtn.Size = new System.Drawing.Size(119, 30);
            this.rekisteroiBtn.TabIndex = 11;
            this.rekisteroiBtn.Text = "Rekisteröi";
            this.rekisteroiBtn.UseVisualStyleBackColor = true;
            this.rekisteroiBtn.Click += new System.EventHandler(this.rekisteroiBtn_Click);
            // 
            // nimiMbox
            // 
            this.nimiMbox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.nimiMbox.Location = new System.Drawing.Point(112, 64);
            this.nimiMbox.Mask = ">L|LLLLLL >L|LLLLLLLLLLL";
            this.nimiMbox.Name = "nimiMbox";
            this.nimiMbox.PromptChar = '-';
            this.nimiMbox.ResetOnPrompt = false;
            this.nimiMbox.ResetOnSpace = false;
            this.nimiMbox.Size = new System.Drawing.Size(221, 22);
            this.nimiMbox.TabIndex = 12;
            // 
            // spostiMbox
            // 
            this.spostiMbox.AsciiOnly = true;
            this.spostiMbox.HidePromptOnLeave = true;
            this.spostiMbox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.spostiMbox.Location = new System.Drawing.Point(112, 189);
            this.spostiMbox.Mask = "CCCCCCCCCC@LLLLL ";
            this.spostiMbox.Name = "spostiMbox";
            this.spostiMbox.Size = new System.Drawing.Size(221, 22);
            this.spostiMbox.TabIndex = 13;
            // 
            // puhnroMbox
            // 
            this.puhnroMbox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.puhnroMbox.Location = new System.Drawing.Point(112, 146);
            this.puhnroMbox.Mask = "+000-00-0000000";
            this.puhnroMbox.Name = "puhnroMbox";
            this.puhnroMbox.PromptChar = '*';
            this.puhnroMbox.ResetOnPrompt = false;
            this.puhnroMbox.ResetOnSpace = false;
            this.puhnroMbox.Size = new System.Drawing.Size(221, 22);
            this.puhnroMbox.TabIndex = 14;
            // 
            // hetuMbox
            // 
            this.hetuMbox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.hetuMbox.Location = new System.Drawing.Point(112, 105);
            this.hetuMbox.Mask = "000000-0000";
            this.hetuMbox.Name = "hetuMbox";
            this.hetuMbox.PromptChar = '*';
            this.hetuMbox.ResetOnPrompt = false;
            this.hetuMbox.ResetOnSpace = false;
            this.hetuMbox.Size = new System.Drawing.Size(221, 22);
            this.hetuMbox.TabIndex = 15;
            // 
            // H5MaskedTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 519);
            this.Controls.Add(this.hetuMbox);
            this.Controls.Add(this.puhnroMbox);
            this.Controls.Add(this.spostiMbox);
            this.Controls.Add(this.nimiMbox);
            this.Controls.Add(this.rekisteroiBtn);
            this.Controls.Add(this.yhteenvetoBox);
            this.Controls.Add(this.yhteenvetoLabel);
            this.Controls.Add(this.spostiLabel);
            this.Controls.Add(this.puhnroLabel);
            this.Controls.Add(this.hetuLabel);
            this.Controls.Add(this.nimiLabel);
            this.Controls.Add(this.henktiedotLabel);
            this.Name = "H5MaskedTextbox";
            this.Text = "H5MaskedTextbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label henktiedotLabel;
        private System.Windows.Forms.Label nimiLabel;
        private System.Windows.Forms.Label hetuLabel;
        private System.Windows.Forms.Label puhnroLabel;
        private System.Windows.Forms.Label spostiLabel;
        private System.Windows.Forms.Label yhteenvetoLabel;
        private System.Windows.Forms.TextBox yhteenvetoBox;
        private System.Windows.Forms.Button rekisteroiBtn;
        private System.Windows.Forms.MaskedTextBox nimiMbox;
        private System.Windows.Forms.MaskedTextBox spostiMbox;
        private System.Windows.Forms.MaskedTextBox puhnroMbox;
        private System.Windows.Forms.MaskedTextBox hetuMbox;
    }
}

