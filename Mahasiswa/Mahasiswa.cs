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
    public partial class Mahasiswa : Form
    {
        public Mahasiswa()
        {
            InitializeComponent();
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            LihatDataMahasiswa objMenu = new LihatDataMahasiswa();
            this.Hide();
            objMenu.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu objMenu = new Menu();
            this.Hide();
            objMenu.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TambahDataMahasiswa objMenu = new TambahDataMahasiswa();
            this.Hide();
            objMenu.Show();
        }
    }
}
