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
    public partial class YanYana : Form
    {
        public YanYana()
        {
            InitializeComponent();
        }

        private void YanYana_Load(object sender, EventArgs e)
        {
            YanYanaFilm film = new YanYanaFilm();


            lblFilmAdi.Text = film.Ad;
            lblSure.Text = "Süre: " + film.Sure + " dk";
            lblTur.Text = "Tür: " + film.Tur;
            lblYonetmen.Text = "Yönetmen: " + film.Yonetmen;
            lblVizyon.Text = "Vizyon: " + film.VizyonTarihi.ToShortDateString();


            lblOyuncular.Text = "Oyuncular: " + string.Join(", ", film.Oyuncular);
        }


        private void button2_Click(object sender, EventArgs e)
        {

            FilmListesi list = new FilmListesi();
            list.Show();


            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aktarim.SecilenFilmAdi = "Yan Yana";
            SinemaBiletSistemi bilet = new SinemaBiletSistemi();
            bilet.Show();
            this.Hide();
        }

        private void lblVizyon_Click(object sender, EventArgs e)
        {

        }

        private void lblSure_Click(object sender, EventArgs e)
        {

        }

        private void lblYonetmen_Click(object sender, EventArgs e)
        {

        }
    }
}
