using SinemaSistemi.sinif;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaSistemi
{
    public partial class f1 : Form
    {
        public f1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Film listesi formunu tekrar oluşturup gösteriyoruz
            FilmListesi list = new FilmListesi();
            list.Show();

            // Şu anki detay formunu kapatıyoruz
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aktarim.SecilenFilmAdi = "F1";
            SinemaBiletSistemi bilet = new SinemaBiletSistemi();
            bilet.Show();
            this.Hide();
        }

        private void f1_Load(object sender, EventArgs e)
        {
            // 1. Class Library'deki F1Film sınıfımızdan nesne üretiyoruz
            F1Film apexFilm = new F1Film();

            // 2. Verileri Formdaki Label'lara aktarıyoruz
            lblYonetmen.Text = "Yönetmen: " + apexFilm.Yonetmen;
            lblSure.Text = "Süre: " + apexFilm.Sure + " dk";
            lblTur.Text = "Tür: " + apexFilm.Tur;
            lblVizyon.Text = "Vizyon Tarihi: " + apexFilm.VizyonTarihi.ToShortDateString();

            // 3. Oyuncu listesini virgülle birleştirip yazdırıyoruz
            lblOyuncular.Text = "Oyuncular: " + string.Join(", ", apexFilm.Oyuncular);
        }
    }
}
