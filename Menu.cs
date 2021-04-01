using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Akhir
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnMahasiswa_Click(object sender, EventArgs e)
        {
            Mahasiswa objMenu = new Mahasiswa();
            this.Hide();
            objMenu.Show();
        }

        private void btnKenangan_Click(object sender, EventArgs e)
        {
            Kenangan objMenu = new Kenangan();
            this.Hide();
            objMenu.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login objMenu = new Login();
            this.Hide();
            objMenu.Show();
        }
    }
}
