namespace Project_Akhir
{
    partial class TambahDataMahasiswa
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Nama = new System.Windows.Forms.TextBox();
            this.textBox_Nim = new System.Windows.Forms.TextBox();
            this.textBox_Prodi = new System.Windows.Forms.TextBox();
            this.textBox_Angkatan = new System.Windows.Forms.TextBox();
            this.textBox_JalurMasuk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PRODI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ANGKATAN";
            // 
            // textBox_Nama
            // 
            this.textBox_Nama.Location = new System.Drawing.Point(98, 66);
            this.textBox_Nama.Name = "textBox_Nama";
            this.textBox_Nama.Size = new System.Drawing.Size(204, 20);
            this.textBox_Nama.TabIndex = 4;
            // 
            // textBox_Nim
            // 
            this.textBox_Nim.Location = new System.Drawing.Point(98, 123);
            this.textBox_Nim.Name = "textBox_Nim";
            this.textBox_Nim.Size = new System.Drawing.Size(204, 20);
            this.textBox_Nim.TabIndex = 5;
            // 
            // textBox_Prodi
            // 
            this.textBox_Prodi.Location = new System.Drawing.Point(98, 180);
            this.textBox_Prodi.Name = "textBox_Prodi";
            this.textBox_Prodi.Size = new System.Drawing.Size(204, 20);
            this.textBox_Prodi.TabIndex = 6;
            // 
            // textBox_Angkatan
            // 
            this.textBox_Angkatan.Location = new System.Drawing.Point(98, 237);
            this.textBox_Angkatan.Name = "textBox_Angkatan";
            this.textBox_Angkatan.Size = new System.Drawing.Size(57, 20);
            this.textBox_Angkatan.TabIndex = 7;
            // 
            // textBox_JalurMasuk
            // 
            this.textBox_JalurMasuk.Location = new System.Drawing.Point(98, 294);
            this.textBox_JalurMasuk.Name = "textBox_JalurMasuk";
            this.textBox_JalurMasuk.Size = new System.Drawing.Size(100, 20);
            this.textBox_JalurMasuk.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "JALUR MASUK";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(79, 348);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(184, 50);
            this.btnTambah.TabIndex = 10;
            this.btnTambah.Text = "TAMBAH DATA MAHASISWA";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(10, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TambahDataMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(329, 410);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_JalurMasuk);
            this.Controls.Add(this.textBox_Angkatan);
            this.Controls.Add(this.textBox_Prodi);
            this.Controls.Add(this.textBox_Nim);
            this.Controls.Add(this.textBox_Nama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TambahDataMahasiswa";
            this.Text = "TambahDataMahasiswa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Nama;
        private System.Windows.Forms.TextBox textBox_Nim;
        private System.Windows.Forms.TextBox textBox_Prodi;
        private System.Windows.Forms.TextBox textBox_Angkatan;
        private System.Windows.Forms.TextBox textBox_JalurMasuk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnBack;
    }
}