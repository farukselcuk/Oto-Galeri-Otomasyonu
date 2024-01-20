using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Oto_Galeri
{
    class oto_Galeri
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Database1.accdb");
        

        public void ekle_sil_güncelle(OleDbCommand komut, string sorgu)
        {
            baglanti.Open();                // Bağlantı Açma
            komut.Connection = baglanti;    // Bağlantı Bağlama
            komut.CommandText = sorgu;      // Bağlantıyı Sorgulama  
            //komut.ExecuteNonQuery();        // İşlemi Onaylama
            baglanti.Close();               // Bağlantı Kapama

        }
    }
}
