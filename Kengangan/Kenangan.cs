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
using System.IO;

namespace Project_Akhir
{
    public partial class Kenangan : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\DATABASE PROJECT AKHIR PEMVIS\dbPA.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand command;
        
        public Kenangan()
        {
            InitializeComponent();
        }

        private void btnBrowseKenangan_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnAddKenangan_Click(object sender, EventArgs e)
        {
            
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            String insertQuery = "INSERT INTO Table2(IdImage, Deskripsi, Image) VALUES(@IdImage, @Deskripsi, @Image)";

            sqlcon.Open();

            command = new SqlCommand(insertQuery,sqlcon);

            command.Parameters.Add("@IdImage", SqlDbType.VarChar, 20);
            command.Parameters.Add("@Deskripsi", SqlDbType.Text);
            command.Parameters.Add("@Image", SqlDbType.Image);

            command.Parameters["@IdImage"].Value = textBox2.Text;
            command.Parameters["@Deskripsi"].Value = textBox1.Text;
            command.Parameters["@Image"].Value = img;

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data Inserted");
            }

            sqlcon.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            pictureBox1.BackColor = Color.Aqua;
        }

        private void btnLihatKenangan_Click(object sender, EventArgs e)
        {
            CariKenangan objMenu = new CariKenangan();
            this.Hide();
            objMenu.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu objMenu = new Menu();
            this.Hide();
            objMenu.Show();
        }
    }
}
