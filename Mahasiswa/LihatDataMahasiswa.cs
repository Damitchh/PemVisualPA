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
    public partial class LihatDataMahasiswa : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\DATABASE PROJECT AKHIR PEMVIS\dbPA.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand command;
        public LihatDataMahasiswa()
        {
            InitializeComponent();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            MessageBox.Show("Database Connect");
            SqlCommand cmd = new SqlCommand("select * from Table_data where Nim=" + textBox_Nim.Text, sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox_Angkatan.Text = (dr["Angkatan"].ToString());
                textBox_Nama.Text = (dr["Nama"].ToString());
                textBox_JalurMasuk.Text = (dr["Jalur"].ToString());
                textBox_Prodi.Text = (dr["Prodi"].ToString());

            }
            sqlcon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("delete from Table_data where Nim=" + textBox_Nim.Text, sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            MessageBox.Show("DATA DELETED");
            dr.Read();
            sqlcon.Close();
            textBox_Angkatan.Text = "";
            textBox_JalurMasuk.Text = "";
            textBox_Nama.Text = "";
            textBox_Nim.Text = "";
            textBox_Prodi.Text = "";

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Mahasiswa objMenu = new Mahasiswa();
            this.Hide();
            objMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAllData objMenu = new ShowAllData();
            this.Hide();
            objMenu.Show();
        }
    }
}

