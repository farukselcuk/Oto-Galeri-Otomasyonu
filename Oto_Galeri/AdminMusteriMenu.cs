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
    public partial class AdminMusteriMenu : Form
    {
        public AdminMusteriMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriEkle yeni = new MusteriEkle();
            yeni.Show();
            this.Hide();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }


        private void btnCostAdd_Click(object sender, EventArgs e)
        {
            MusteriEkle yeni = new MusteriEkle();
            yeni.Show();
            this.Hide();
        }

        private void btnCostDelete_Click(object sender, EventArgs e)
        {
            MusteriList yeni = new MusteriList();
            yeni.Show();
            this.Hide();
        }

        private void btnCostList_Click(object sender, EventArgs e)
        {
            MusteriList yeni = new MusteriList();
            yeni.Show();
            this.Hide();
        }

        private void btnSozlesme_Click(object sender, EventArgs e)
        {

        }

        private void btnKalanBorc_Click(object sender, EventArgs e)
        {
            TaksitveBorc yeni = new TaksitveBorc();
            yeni.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            AdminMenu yeni = new AdminMenu();
            yeni.Show();
            this.Hide();
        }
    }
}
