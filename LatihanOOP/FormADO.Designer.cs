namespace LatihanOOP
{
    partial class FormADO
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
            this.btnKonek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKonek
            // 
            this.btnKonek.Location = new System.Drawing.Point(12, 12);
            this.btnKonek.Name = "btnKonek";
            this.btnKonek.Size = new System.Drawing.Size(75, 23);
            this.btnKonek.TabIndex = 0;
            this.btnKonek.Text = "Koneksi";
            this.btnKonek.UseVisualStyleBackColor = true;
            this.btnKonek.Click += new System.EventHandler(this.btnKonek_Click);
            // 
            // FormADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnKonek);
            this.Name = "FormADO";
            this.Text = "FormADO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKonek;
    }
}