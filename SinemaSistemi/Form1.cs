using SinemaSistemi.sinif;
using System.Security.Cryptography.X509Certificates;

namespace SinemaSistemi
{
    public partial class Form1 : Form
    {
        List<SinemaSistemi.sinif.kullanici> kullanicilar = new List<SinemaSistemi.sinif.kullanici>();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        {
            string girilenAd = textBox1.Text; 
            string girilenSifre = textBox2.Text; 
            var kontrol = kullanicilar.FirstOrDefault(k => k.kullaniciAdi == girilenAd && k.sifre == girilenSifre);

            if (kontrol != null)
            {
                MessageBox.Show("Giriþ Baþarýlý! Hoþgeldiniz, " + girilenAd);
                FilmListesi f1 = new FilmListesi();
                f1.Show();
                this.Hide();
                Aktarim.GirisYapanKullaniciTipi = kontrol.tip;
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya þifre yanlýþ!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SinemaSistemi.sinif.kullanici kullanici = new SinemaSistemi.sinif.kullanici();
            kullanici.kullaniciAdi = textBox4.Text;
            kullanici.sifre = textBox3.Text;
            kullanici.telefon = textBox6.Text;
            kullanici.tip = comboBox1.SelectedItem.ToString();            
            kullanicilar.Add(kullanici);
            MessageBox.Show("Kayýt Baþarýlý! Giriþ Yapabilirsiniz.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
