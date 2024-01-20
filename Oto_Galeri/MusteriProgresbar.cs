using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oto_Galeri
{
    public partial class MusteriProgresbar : Form
    {
        public MusteriProgresbar()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        int saniye = 0;
        private int countdownValue = 4;

        private void Form7_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblsayı.Text = "0";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            // Geri sayımı güncelle
            countdownValue--;

            // Label'ı güncelle
            lblsayı.Text = countdownValue.ToString();

            // ProgressBar'ı ilerlet
            progressBar1.PerformStep();

            // Geri sayım bittiğinde Timer'ı durdur
            if (countdownValue == 0)
            {
                timer1.Stop();

                MusteriEkle yeni = new MusteriEkle();
                this.Hide();
                yeni.Show();
            }
        } 
    }
}




