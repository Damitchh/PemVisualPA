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
    public partial class ShowAllData : Form
    {
        public ShowAllData()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LihatDataMahasiswa objMenu = new LihatDataMahasiswa();
            this.Hide();
            objMenu.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\DATABASE PROJECT AKHIR PEMVIS\dbPA.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                MessageBox.Show("conncet");
                conn.Open();
                String sql = "SELECT Nim, Nama, Prodi, Angkatan, Jalur FROM Table_data";
                SqlCommand cmd = new SqlCommand(sql, conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                this.dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
