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
    public partial class Zootropolis2 : Form
    {
        public Zootropolis2()
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
            Aktarim.SecilenFilmAdi = "Zootropolis 2";
            SinemaBiletSistemi bilet = new SinemaBiletSistemi();
            bilet.Show();
            this.Hide();
        }

        private void Zootropolis2_Load(object sender, EventArgs e)
        {
            ZootropolisFilm zooFilm = new ZootropolisFilm();

            // 2. Sınıfın içindeki verileri formdaki etiketlere aktarıyoruz
            lblYonetmen.Text = "Yönetmen: " + zooFilm.Yonetmen;
            lblSure.Text = "Süre: " + zooFilm.Sure + " dk";
            lblTur.Text = "Tür: " + zooFilm.Tur;
            lblVizyon.Text = "Vizyon Tarihi: " + zooFilm.VizyonTarihi.ToShortDateString();

            // 3. Oyuncu listesini virgülle ayırarak gösteriyoruz
            lblOyuncular.Text = "Oyuncular: " + string.Join(", ", zooFilm.Oyuncular);
        }
    }
}
