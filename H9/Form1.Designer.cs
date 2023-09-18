
namespace H9
{
    partial class H9Listbox
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
            this.Listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Listbox
            // 
            this.Listbox.BackColor = System.Drawing.Color.MediumPurple;
            this.Listbox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Listbox.FormattingEnabled = true;
            this.Listbox.ItemHeight = 16;
            this.Listbox.Location = new System.Drawing.Point(12, 12);
            this.Listbox.Name = "Listbox";
            this.Listbox.Size = new System.Drawing.Size(199, 228);
            this.Listbox.TabIndex = 0;
            // 
            // H9Listbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Listbox);
            this.Name = "H9Listbox";
            this.Text = "H9Listbox";
            this.Load += new System.EventHandler(this.H9Listbox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Listbox;
    }
}

