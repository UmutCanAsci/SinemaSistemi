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
    public partial class FilmListesi : Form
    {
        public FilmListesi()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void FilmListesi_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            YanYana yy = new YanYana();
            yy.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            f1 f1_film = new f1();
            f1_film.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zootropolis2 zt = new Zootropolis2();
            zt.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Aktarim.SecilenFilmAdi = "Yan Yana"; 
            SinemaBiletSistemi bilet = new SinemaBiletSistemi();
            bilet.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            Form1 girisFormu = new Form1();           
            girisFormu.Show();           
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {            
            Aktarim.SecilenFilmAdi = "Zootropolis 2";          
            SinemaBiletSistemi biletFormu = new SinemaBiletSistemi();
            biletFormu.Show();            
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Aktarim.SecilenFilmAdi = "F1";
            SinemaBiletSistemi bilet = new SinemaBiletSistemi();
            bilet.Show();
            this.Hide();
        }
    }
}
