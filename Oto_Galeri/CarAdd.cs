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
    public partial class CarAdd : Form
    {
        public CarAdd()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            AdminArac yeni = new AdminArac();
            yeni.Show();
            this.Hide();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Ömer Faruk Selçuk\\OneDrive\\Masaüstü\\OtoDataBase.accdb");

        private void btnadd_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("insert into Arac (marka,model,yıl,yakıt,fiyat,vites,aracDurumu,km,kasaTipi,motorGucu,cekis,renk,agırHasar,hasarDurumu) values ('" + tbmarka.Text.ToString() + "','" + tbmodel.Text.ToString() + "','" + tbyıl.Text.ToString() + "','" + tbyakıt.Text.ToString() + "','" + tbfiyat.Text.ToString() + "','" + tbvites.Text.ToString() + "','" + tbaracdur.Text.ToString() + "','" + tbkm.Text.ToString() + "','" + tbkasatip.Text.ToString() + "','" + tbmotorguc.Text.ToString() + "','" + tbcekis.Text.ToString() + "','" + tbrenk.Text.ToString() + "','" + tbagırhasar.Text.ToString() + "','" + tbhasardurumu.Text.ToString() + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            // Buraya diğer sayfadan kalıtımla metot yazıcam.
            AracProgresbar yeni = new AracProgresbar();
            yeni.Show();
            this.Hide();
            ClearTextBoxes();

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
        private void CarAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
