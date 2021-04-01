namespace Project_Akhir
{
    partial class Menu
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
            this.btnMahasiswa = new System.Windows.Forms.Button();
            this.btnKenangan = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMahasiswa
            // 
            this.btnMahasiswa.Location = new System.Drawing.Point(119, 125);
            this.btnMahasiswa.Name = "btnMahasiswa";
            this.btnMahasiswa.Size = new System.Drawing.Size(186, 63);
            this.btnMahasiswa.TabIndex = 0;
            this.btnMahasiswa.Text = "Mahasiswa";
            this.btnMahasiswa.UseVisualStyleBackColor = true;
            this.btnMahasiswa.Click += new System.EventHandler(this.btnMahasiswa_Click);
            // 
            // btnKenangan
            // 
            this.btnKenangan.Location = new System.Drawing.Point(119, 250);
            this.btnKenangan.Name = "btnKenangan";
            this.btnKenangan.Size = new System.Drawing.Size(186, 63);
            this.btnKenangan.TabIndex = 1;
            this.btnKenangan.Text = "Kenangan Foto Kegiatan";
            this.btnKenangan.UseVisualStyleBackColor = true;
            this.btnKenangan.Click += new System.EventHandler(this.btnKenangan_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(2, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnKenangan);
            this.Controls.Add(this.btnMahasiswa);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMahasiswa;
        private System.Windows.Forms.Button btnKenangan;
        private System.Windows.Forms.Button btnBack;
    }
}