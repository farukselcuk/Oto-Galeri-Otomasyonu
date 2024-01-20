using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oto_Galeri
{
    public partial class MusteriEkle : Form
    {

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Ömer Faruk Selçuk\\OneDrive\\Masaüstü\\OtoDataBase.accdb");

        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void ClearTextBoxes()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void textTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Musteri (tc,adsoyad,telefon,adres,email,sifre) values ('" + mtbtc.Text.ToString() + "','" + textName.Text.ToString() + "','" + textNumber.Text.ToString() + "','" + textAdress.Text.ToString() + "','" + textEmail.Text.ToString() + "','" + textSifre.Text.ToString() + "')", baglanti);                                          
            komut.ExecuteNonQuery();        // İşlemi Onaylama
            baglanti.Close();               
            ClearTextBoxes();

            MusteriProgresbar yeni = new MusteriProgresbar();      // Progres bar açılacak.
            yeni.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AdminMusteriMenu yeni = new AdminMusteriMenu();
            yeni.Show();
            this.Hide();
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
