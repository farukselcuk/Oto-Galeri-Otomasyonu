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
   //                           "ÖMER FARUK SELÇUK"-"225541031"
    public partial class Giris : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Ömer Faruk Selçuk\\OneDrive\\Masaüstü\\OtoDataBase.accdb");

        public Giris()
        {
            InitializeComponent();
            this.Size = new Size(845, 549);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminMenu yeni = new AdminMenu();
            this.Hide();
            yeni.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnGiris.Visible = true;
            lblAdminAd.Text = "Admin Adı : ";
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            lblAdminAd.Text = "Müşteri Adı :";
            panel1.Visible = true;
            btnGiris.Visible = true;
        }

        private void lblAdminAd_Click(object sender, EventArgs e)
        {

        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("Select Ad_Soyad ,Sifre From Giris Where Ad_Soyad=@adsoyad and Sifre=@sifre  ", baglantı);
            komut.Parameters.AddWithValue("@adsoyad", textBox1.Text);
            komut.Parameters.AddWithValue("@sifre", textBox2.Text);
            OleDbDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                // Admin girişi yapıldığında
                lblAdminAd.Text = "Admin Adı :";
                AdminMenu yeni = new AdminMenu();
                yeni.Show();
                this.Hide();
            }
            else
            {
                lblAdminAd.Text = "Müşteri Adı :";
                // Müşteri girişi yapıldığında
                baglantı.Close();
                baglantı.Open();
                komut = new OleDbCommand("Select adsoyad ,sifre From Musteri Where adsoyad=@adsoyad and sifre=@sifre  ", baglantı);
                komut.Parameters.AddWithValue("@adsoyad", textBox1.Text);
                komut.Parameters.AddWithValue("@sifre", textBox2.Text);
                oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    Musterimenu yeni = new Musterimenu();
                    yeni.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş başarısız");
                }

                baglantı.Close();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pbeye_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Ömer Faruk Selçuk\\OneDrive\\Masaüstü\\OtoDataBase.accdb");
        public static string ad;
        public static string soyad;
        public static string mail_adresi;
        public static string sifre;
        public void Getir()
        {
           
            baglanti.Open();
            string komutCumlesi = "Select * From Musteri where email like '" + textBox1.Text + "' ";
            OleDbCommand komutYeni = new OleDbCommand(komutCumlesi, baglanti);  // veritabanıyla etkileşim sağlar ;select,uptade,delete,insert
            OleDbDataReader oku = komutYeni.ExecuteReader();  // sorgu sonucu dönen verileri satır satır okumaya yarar

            while (oku.Read())
            {
                ad = oku["adsoyad"].ToString(); // oledbdatareader nesnesi üzerinden firstname sütunun değerini string değişkenine atar
                mail_adresi = oku["email"].ToString();
                sifre = oku["sifre"].ToString();
            }
            baglanti.Close();
        }

        private void linklsifreunuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Getir();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Musteri", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                SifremiUnuttum sifreyeni = new SifremiUnuttum();
                sifreyeni.Show();
            }
            baglanti.Close();
        }
    }
}
