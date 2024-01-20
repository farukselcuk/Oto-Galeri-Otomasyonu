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
    public partial class AdminArac : Form
    {
        public AdminArac()
        {
            InitializeComponent();
            this.Size = new Size(863, 549);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminMenu yeni = new AdminMenu();
            yeni.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AracList yeni = new AracList();
            yeni.Show();
            this.Hide();
        }

        private void btnCarAdd_Click(object sender, EventArgs e)
        {
            CarAdd yeni = new CarAdd();
            yeni.Show();
            this.Hide();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            AracList yeni = new AracList();
            yeni.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminMenu yeni = new AdminMenu();
            yeni.Show();
            this.Hide();
        }

        private void btnCarDelete_Click(object sender, EventArgs e)
        {
            AracList yeni = new AracList();
            yeni.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
