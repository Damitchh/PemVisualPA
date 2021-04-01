namespace Project_Akhir
{
    partial class Kenangan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kenangan));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddKenangan = new System.Windows.Forms.Button();
            this.btnLihatKenangan = new System.Windows.Forms.Button();
            this.btnBrowseKenangan = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(769, 342);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddKenangan
            // 
            this.btnAddKenangan.Location = new System.Drawing.Point(480, 482);
            this.btnAddKenangan.Name = "btnAddKenangan";
            this.btnAddKenangan.Size = new System.Drawing.Size(108, 23);
            this.btnAddKenangan.TabIndex = 1;
            this.btnAddKenangan.Text = "Add";
            this.btnAddKenangan.UseVisualStyleBackColor = true;
            this.btnAddKenangan.Click += new System.EventHandler(this.btnAddKenangan_Click);
            // 
            // btnLihatKenangan
            // 
            this.btnLihatKenangan.Location = new System.Drawing.Point(301, 511);
            this.btnLihatKenangan.Name = "btnLihatKenangan";
            this.btnLihatKenangan.Size = new System.Drawing.Size(296, 23);
            this.btnLihatKenangan.TabIndex = 2;
            this.btnLihatKenangan.Text = "Lihat Kenangan";
            this.btnLihatKenangan.UseVisualStyleBackColor = true;
            this.btnLihatKenangan.Click += new System.EventHandler(this.btnLihatKenangan_Click);
            // 
            // btnBrowseKenangan
            // 
            this.btnBrowseKenangan.Location = new System.Drawing.Point(489, 376);
            this.btnBrowseKenangan.Name = "btnBrowseKenangan";
            this.btnBrowseKenangan.Size = new System.Drawing.Size(108, 23);
            this.btnBrowseKenangan.TabIndex = 3;
            this.btnBrowseKenangan.Text = "Browse";
            this.btnBrowseKenangan.UseVisualStyleBackColor = true;
            this.btnBrowseKenangan.Click += new System.EventHandler(this.btnBrowseKenangan_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(406, 431);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 45);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "DESKRIPSI";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(406, 405);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(27, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(5, -1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Kenangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(793, 567);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBrowseKenangan);
            this.Controls.Add(this.btnLihatKenangan);
            this.Controls.Add(this.btnAddKenangan);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Kenangan";
            this.Text = "Kenangan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddKenangan;
        private System.Windows.Forms.Button btnLihatKenangan;
        private System.Windows.Forms.Button btnBrowseKenangan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
    }
}