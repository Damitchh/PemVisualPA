using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_Akhir
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\DATABASE PROJECT AKHIR PEMVIS\dbPA.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from [Table] where username = '" + textUsername.Text.Trim() + "' and password = '" + textPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query,sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if(dtbl.Rows.Count == 1)
            {
                Menu objMenu = new Menu();
                this.Hide();
                objMenu.Show();
            }
            else
            {
                MessageBox.Show("check your usernma and password");
            }
        }
    }
}
