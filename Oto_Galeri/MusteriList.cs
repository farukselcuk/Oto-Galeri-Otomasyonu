using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
namespace Oto_Galeri
{
    public partial class MusteriList : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Ömer Faruk Selçuk\\OneDrive\\Masaüstü\\OtoDataBase.accdb");
        public MusteriList()
        {
            InitializeComponent();
            this.Size = new Size(1043, 631);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cumle = "Delete From Musteri where tc='" + satir.Cells["tc"].Value.ToString() + "'";
            OleDbCommand komut = new OleDbCommand();
            baglantıEkle(komut, cumle);
            CostumerList();
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
        private void CostumerList()
        {
            string cumle = "Select * From Musteri";
            OleDbDataAdapter adtr = new OleDbDataAdapter();
            dataGridView1.DataSource = List(adtr, cumle);
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
        private void btnlist_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
        }

        private void MusteriList_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Musteri", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void lbldelete_Click(object sender, EventArgs e)
        {

        }
        private void btnback_Click(object sender, EventArgs e)
        {
            AdminMusteriMenu yeni = new AdminMusteriMenu();
            yeni.Show();
            this.Hide();
        }
    }
}
