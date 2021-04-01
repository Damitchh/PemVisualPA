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
using System.IO;

namespace Project_Akhir
{
    public partial class CariKenangan : Form
    {
        public CariKenangan()
        {
            InitializeComponent();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\DATABASE PROJECT AKHIR PEMVIS\dbPA.mdf;Integrated Security=True;Connect Timeout=30");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select Image from Table2 where IdImage=" +int.Parse(textBox1.Text), sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            SqlCommand command = new SqlCommand("SELECT Deskripsi FROM Table2 WHERE IdImage=" + int.Parse(textBox1.Text), sqlcon);
            SqlDataReader dr = command.ExecuteReader();
            dr.Read();
            if (ds.Tables[0].Rows.Count > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Image"]);
                pictureBox1.Image = new Bitmap(ms);
                textBox2.Text = (dr["Deskripsi"].ToString());

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Kenangan objMenu = new Kenangan();
            this.Hide();
            objMenu.Show();
        }
    }
}
