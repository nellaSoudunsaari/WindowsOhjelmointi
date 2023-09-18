
namespace H10
{
    partial class H10CheckedListbox
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
            this.paalistaLabel = new System.Windows.Forms.Label();
            this.varalistaLabel = new System.Windows.Forms.Label();
            this.ikkunatCLB = new System.Windows.Forms.CheckedListBox();
            this.varalistaCLB = new System.Windows.Forms.CheckedListBox();
            this.copyBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paalistaLabel
            // 
            this.paalistaLabel.AutoSize = true;
            this.paalistaLabel.Location = new System.Drawing.Point(48, 49);
            this.paalistaLabel.Name = "paalistaLabel";
            this.paalistaLabel.Size = new System.Drawing.Size(58, 17);
            this.paalistaLabel.TabIndex = 0;
            this.paalistaLabel.Text = "Päälista";
            // 
            // varalistaLabel
            // 
            this.varalistaLabel.AutoSize = true;
            this.varalistaLabel.Location = new System.Drawing.Point(439, 49);
            this.varalistaLabel.Name = "varalistaLabel";
            this.varalistaLabel.Size = new System.Drawing.Size(63, 17);
            this.varalistaLabel.TabIndex = 1;
            this.varalistaLabel.Text = "Varalista";
            // 
            // ikkunatCLB
            // 
            this.ikkunatCLB.BackColor = System.Drawing.Color.Snow;
            this.ikkunatCLB.CheckOnClick = true;
            this.ikkunatCLB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ikkunatCLB.FormattingEnabled = true;
            this.ikkunatCLB.Items.AddRange(new object[] {
            "Punainen ikkuna",
            "Sininen ikkuna",
            "Keltainen ikkuna"});
            this.ikkunatCLB.Location = new System.Drawing.Point(51, 69);
            this.ikkunatCLB.Name = "ikkunatCLB";
            this.ikkunatCLB.Size = new System.Drawing.Size(230, 140);
            this.ikkunatCLB.TabIndex = 2;
            this.ikkunatCLB.SelectedIndexChanged += new System.EventHandler(this.ikkunatCLB_SelectedIndexChanged);
            // 
            // varalistaCLB
            // 
            this.varalistaCLB.BackColor = System.Drawing.Color.Snow;
            this.varalistaCLB.CheckOnClick = true;
            this.varalistaCLB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.varalistaCLB.FormattingEnabled = true;
            this.varalistaCLB.Location = new System.Drawing.Point(442, 69);
            this.varalistaCLB.Name = "varalistaCLB";
            this.varalistaCLB.Size = new System.Drawing.Size(230, 140);
            this.varalistaCLB.TabIndex = 3;
            this.varalistaCLB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.varalistaCLB_MouseDoubleClick);
            // 
            // copyBtn
            // 
            this.copyBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.copyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.copyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.copyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyBtn.Location = new System.Drawing.Point(51, 260);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(105, 36);
            this.copyBtn.TabIndex = 4;
            this.copyBtn.Text = "Kopioi";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(206, 260);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(105, 36);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Poista";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // H10CheckedListbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.varalistaCLB);
            this.Controls.Add(this.ikkunatCLB);
            this.Controls.Add(this.varalistaLabel);
            this.Controls.Add(this.paalistaLabel);
            this.Name = "H10CheckedListbox";
            this.Text = "H10CheckedListbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label paalistaLabel;
        private System.Windows.Forms.Label varalistaLabel;
        private System.Windows.Forms.CheckedListBox ikkunatCLB;
        private System.Windows.Forms.CheckedListBox varalistaCLB;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}

