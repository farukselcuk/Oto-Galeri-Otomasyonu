using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Oto_Galeri
{
    class otoGaleri
    {
        OleDbConnection baglanti = new OleDbConnection(""); // Dosyanın konumunu Yaz!
        DataTable tablo;

        public void ekle_sil_güncelle(OleDbCommand komut,string sorgu)
        {
            baglanti.Open();  // baglanıyı kullanabilmek için açtık
            komut.Connection = baglanti; // bağladık
            komut.CommandText = sorgu;   // sorguladık
            komut.ExecuteNonQuery(); // Onay aldık
            baglanti.Close(); // Bağlantıyı kapattık

        }
    }
}
