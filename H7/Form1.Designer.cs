
namespace H7
{
    partial class Harkka7Checkbox
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
            this.variCheck = new System.Windows.Forms.CheckBox();
            this.kokoCheck = new System.Windows.Forms.CheckBox();
            this.sijaintiCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // variCheck
            // 
            this.variCheck.AutoSize = true;
            this.variCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.variCheck.Location = new System.Drawing.Point(106, 56);
            this.variCheck.Name = "variCheck";
            this.variCheck.Size = new System.Drawing.Size(193, 21);
            this.variCheck.TabIndex = 0;
            this.variCheck.Text = "Muuta ikkunan taustaväriä";
            this.variCheck.UseVisualStyleBackColor = true;
            this.variCheck.CheckedChanged += new System.EventHandler(this.variCheck_CheckedChanged);
            // 
            // kokoCheck
            // 
            this.kokoCheck.AutoSize = true;
            this.kokoCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kokoCheck.Location = new System.Drawing.Point(106, 147);
            this.kokoCheck.Name = "kokoCheck";
            this.kokoCheck.Size = new System.Drawing.Size(161, 21);
            this.kokoCheck.TabIndex = 1;
            this.kokoCheck.Text = "Muuta ikkunan kokoa";
            this.kokoCheck.UseVisualStyleBackColor = true;
            this.kokoCheck.CheckedChanged += new System.EventHandler(this.kokoCheck_CheckedChanged);
            // 
            // sijaintiCheck
            // 
            this.sijaintiCheck.AutoSize = true;
            this.sijaintiCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sijaintiCheck.Location = new System.Drawing.Point(106, 232);
            this.sijaintiCheck.Name = "sijaintiCheck";
            this.sijaintiCheck.Size = new System.Drawing.Size(170, 21);
            this.sijaintiCheck.TabIndex = 2;
            this.sijaintiCheck.Text = "Muuta ikkunan sijaintia";
            this.sijaintiCheck.UseVisualStyleBackColor = true;
            this.sijaintiCheck.CheckedChanged += new System.EventHandler(this.sijaintiCheck_CheckedChanged);
            // 
            // Harkka7Checkbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sijaintiCheck);
            this.Controls.Add(this.kokoCheck);
            this.Controls.Add(this.variCheck);
            this.Name = "Harkka7Checkbox";
            this.Text = "Harkka7Checkbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox variCheck;
        private System.Windows.Forms.CheckBox kokoCheck;
        private System.Windows.Forms.CheckBox sijaintiCheck;
    }
}

