using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oto_Galeri
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
            this.Size = new Size(863, 549);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris yeni = new Giris();
            yeni.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminArac yeni = new AdminArac();
            yeni.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminMusteriMenu yeni = new AdminMusteriMenu();
            yeni.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }


        private void btnMusEkran_Click(object sender, EventArgs e)
        {
            AdminMusteriMenu yeni = new AdminMusteriMenu();
            yeni.Show();
            this.Hide();
        }

        private void btnAracEkranı_Click(object sender, EventArgs e)
        {
            AdminArac yeni = new AdminArac();
            yeni.Show();
            this.Hide();
        }


        private void pctBack_Click(object sender, EventArgs e)
        {
            Giris yeni = new Giris();
            yeni.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
