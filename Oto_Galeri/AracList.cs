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
    public partial class AracList : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Ömer Faruk Selçuk\\OneDrive\\Masaüstü\\OtoDataBase.accdb");
        public AracList()
        {
            InitializeComponent();
            this.Size = new Size(1500, 631);
        }
        void list()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Arac", baglanti);
            da.Fill(dt);
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            AdminArac yeni = new AdminArac();
            yeni.Show();
            this.Hide();
        }

        private void AracList_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Arac", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        public void baglantıEkle(OleDbCommand komut, string sorgu)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public DataTable List(OleDbDataAdapter adtr, string sorgu)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            adtr = new OleDbDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
        private void CarList()
        {
            string cumle = "Select * From Arac";
            OleDbDataAdapter adtr = new OleDbDataAdapter();
            dataGridView1.DataSource = List(adtr, cumle);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cumle = "Delete From Arac where marka='" + satir.Cells["marka"].Value.ToString() + "'";
            OleDbCommand komut = new OleDbCommand();
            baglantıEkle(komut, cumle);
            CarList(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnlist_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
        }
    }
}
