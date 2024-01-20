using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Oto_Galeri
{
    public partial class Musterimenu : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Ömer Faruk Selçuk\\OneDrive\\Masaüstü\\OtoDataBase.accdb");
        public Musterimenu()
        {
            InitializeComponent();
            this.Size = new Size(863, 549);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMenu yeni = new AdminMenu();
            yeni.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Giris yeni = new Giris();
            yeni.Show();
            this.Hide();
        }
        void list()
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Arac", baglantı);
            da.Fill(dt);
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void btnlist_Click(object sender, EventArgs e)
        {
            dgwBorc.Visible = false;
            dataGridView1.Visible = true;
            baglantı.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Arac", baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglantı.Close();
        }

        private void btnborc_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dgwBorc.Visible = true;
            baglantı.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Borc", baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwBorc.DataSource = ds.Tables[0];
            baglantı.Close();
        }
    }
}
