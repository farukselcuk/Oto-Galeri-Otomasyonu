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
    public partial class TaksitveBorc : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Ömer Faruk Selçuk\\OneDrive\\Masaüstü\\OtoDataBase.accdb");
        public TaksitveBorc()
        {
            InitializeComponent();
        }
        public double aylikTutar;
        private void btnTaksitle_Click(object sender, EventArgs e)
        {
            string tc = tbTC.Text;
            string sorgu = "SELECT COUNT(*) FROM Musteri WHERE tc = @tc";
            OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@tc", tc);
            baglanti.Open();
            int check=(int)komut.ExecuteScalar();
            baglanti.Close();
            if (check == 1 && tbAracTutari.Text!=" " && tbtaksit.Text!=" ")
            {
                double taksit = Taksitle();
                double total = Convert.ToDouble(tbAracTutari.Text);
                OleDbCommand cmd = new OleDbCommand("INSERT INTO Borc (TC, AylikMiktar,TotalBorc, TaksitSayisi) values(@Tc, @aylik,@total, @ay)",baglanti);
                cmd.Parameters.AddWithValue("@Tc", tc);
                cmd.Parameters.AddWithValue("@aylik", taksit);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@ay", tbtaksit.Text);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
            } 
            else
                MessageBox.Show("Kullanıcı mevcut değil");
            

        }
        public double Taksitle()
        {
            int arac_tutar = Convert.ToInt32(tbAracTutari.Text);
            int taksit = Convert.ToInt32(tbtaksit.Text);
            aylikTutar = arac_tutar / taksit;
            lblAylıktutar.Text = aylikTutar.ToString();
            return aylikTutar;

        }

        private void btnOde_Click(object sender, EventArgs e)
        {

            string tc = tbBorcTc.Text;
            double odeme = Convert.ToDouble(tbOdenecek.Text);

            string sorgu = "SELECT TotalBorc from Borc where tc=@tc";
            OleDbCommand cmd = new OleDbCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@tc", tc);
            double borc;
            baglanti.Open();
            borc = Convert.ToDouble(cmd.ExecuteScalar());
            baglanti.Close();

            borc = borc - odeme;
            string sorgu2 = "SELECT TaksitSayisi from Borc where tc=@tc";
            OleDbCommand komut = new OleDbCommand(sorgu2, baglanti);
            komut.Parameters.AddWithValue("@tc", tc);

            baglanti.Open();
            int taksit = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();

            taksit = taksit - 1;
            string sorgu3 = "Update Borc SET TotalBorc=?, TaksitSayisi=? where tc=@tc";
            OleDbCommand komut2 = new OleDbCommand(sorgu3, baglanti);
            komut2.Parameters.AddWithValue("TotalBorc", borc);
            komut2.Parameters.AddWithValue("TaksitSayisi", taksit);
            komut2.Parameters.AddWithValue("@tc", tc);
            baglanti.Open();
            komut2.ExecuteNonQuery();
            baglanti.Close();
            lblkalanSayi.Text = borc.ToString();
          
        }

        private void lblAylıktutar_Click(object sender, EventArgs e)
        {

        }

        private void TaksitveBorc_Load(object sender, EventArgs e)
        {

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            AdminMusteriMenu yeni = new AdminMusteriMenu();
            yeni.Show();
            this.Hide();
        }
    }
}
