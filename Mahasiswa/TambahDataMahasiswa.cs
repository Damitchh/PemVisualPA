using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Akhir
{
    public partial class TambahDataMahasiswa : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\DATABASE PROJECT AKHIR PEMVIS\dbPA.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand command;
        public TambahDataMahasiswa()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Mahasiswa objMenu = new Mahasiswa();
            this.Hide();
            objMenu.Show();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            String insertQuery = "INSERT INTO Table_data(Nama, Nim, Prodi, Angkatan, Jalur) VALUES(@Nama, @Nim, @Prodi, @Angkatan, @Jalur)";

            sqlcon.Open();
            command = new SqlCommand(insertQuery, sqlcon);

            command.Parameters.Add("@Nama", SqlDbType.VarChar, 50);
            command.Parameters.Add("@Nim", SqlDbType.VarChar,50);
            command.Parameters.Add("@Prodi", SqlDbType.VarChar,50);
            command.Parameters.Add("@Angkatan", SqlDbType.Int);
            command.Parameters.Add("@Jalur", SqlDbType.VarChar, 50);

            command.Parameters["@Nama"].Value = textBox_Nama.Text;
            command.Parameters["@Nim"].Value = textBox_Nim.Text;
            command.Parameters["@Prodi"].Value = textBox_Prodi.Text;
            command.Parameters["@Angkatan"].Value = int.Parse(textBox_Angkatan.Text);
            command.Parameters["@Jalur"].Value = textBox_JalurMasuk.Text;

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data Inserted");
            }

            sqlcon.Close();
        }
    }
}
