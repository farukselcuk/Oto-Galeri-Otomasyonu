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
using System.Net.Mail;
using System.Net;

namespace Oto_Galeri
{
    public partial class SifremiUnuttum : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Ömer Faruk Selçuk\\OneDrive\\Masaüstü\\OtoDataBase.accdb");

        public static string sifre;
        public static string mailadres;
        string pass;

        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        public void Up()
        {
            baglanti.Open();
            string komutcumlesiUp = "update Musteri Set email='" + textBox1.Text + "'";
            OleDbCommand komutUp = new OleDbCommand(komutcumlesiUp, baglanti);

            komutUp.Parameters.AddWithValue("@sifre", pass.ToString());
            komutUp.Parameters.AddWithValue("@email", textBox1.Text);
            komutUp.ExecuteNonQuery();          // delete uptade gibi vei tabanı sorgularını yürütür

            baglanti.Close();

        }
        public void Microsoft(string gondericiMail, string gondericiPass, string aliciMail)
        {
    
            baglanti.Open();
            OleDbCommand komutUp = new OleDbCommand("SELECT * FROM Musteri", baglanti);
            OleDbDataReader oku = komutUp.ExecuteReader();

            while (oku.Read())
            {
                if (textBox1.Text == oku["email"].ToString())
                {
                    Random rnd = new Random();
                    int a = rnd.Next(1000, 9999);
                    pass = a.ToString();            // random sayıyı stringr çevirerek pass değişkenine atadı
                    SmtpClient sc = new SmtpClient();   // e posta gödermek için kullanılan bir sınıftır
                    sc.Port = 587;                  // mail port numarası girilir
                    sc.Host = "smtp.outlook.com";
                    sc.EnableSsl = true;            // ssl bağlantısını etkinleştirmek için kullanılır
                    sc.Credentials = new NetworkCredential(gondericiMail, gondericiPass);   // smtp sunucusuna bağlanırken kullanıcı adı ve şifre bilgilerini girmek için kullanılan bir komuttur

                    MailMessage mail = new MailMessage();            // e posta mesajları oluşturmak için kullanılır
                    mail.From = new MailAddress(gondericiMail, "Sifremi unuttum");
                    mail.To.Add(aliciMail);
                    mail.Subject = "Şifre sıfırlama  talebi";
                    mail.IsBodyHtml = true;
                    mail.Body = $@"{DateTime.Now.ToString()} Tarihinde şifre hatırlatma talebinde bulundunuz. Yeni şifreniz:{a}";
                    sc.Send(mail);

                }
                else
                {
                    MessageBox.Show("Bilgilerinizde yanlışlık var tekrar deneyiniz", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            } 
            baglanti.Close();

        }
        private void BtnGonder_Click(object sender, EventArgs e)
        {
            // sifre gönder butonu OleDbConnection baglant = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mahmu\Desktop\projeler\Personel.mdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT* FROM Musteri", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                if (textBox1.Text == oku["email"].ToString())
                {
                    Microsoft("omerfarukcem42@hotmail.com", "omer123faruk", textBox1.Text);
                    Up();
                    MessageBox.Show("Girilen bilgiler eşleştirildi ve şifreniz yenilendi. Mailinizi kontrol ediniz.", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BtnGonder.Click -= BtnGonder_Click;
                }
                else if (textBox1.Text == "")
                {
                    MessageBox.Show("Mail adresi boş bırakılamaz", " Durum", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Mail adresi ile veri tabanındaki adresler uyuşmuyor", " Durum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            oku.Close();// datareader kapandı
            baglanti.Close();// veritabanı baglantısı kapanadı
        }

        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {

        }
    }
}
