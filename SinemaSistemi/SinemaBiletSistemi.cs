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
    public partial class SinemaBiletSistemi : Form
    {
        public SinemaBiletSistemi()
        {
            InitializeComponent();
        }

        private void SinemaBiletSistemi_Load(object sender, EventArgs e)
        {
            label1.Text = Aktarim.SecilenFilmAdi;
            label2.Text = "Kullanıcı Tipi: " + Aktarim.GirisYapanKullaniciTipi;

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "Zorlu Center", "İstinye Park AWM", "Forum İstanbul", "Axis Bayrampaşa", "Rüya Park AWM" });

            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new string[] { "13.00", "17.00", "21.00" });

            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(new string[] { "Küçük (40 TL)", "Orta (60 TL)", "Büyük (80 TL)" });

            comboBox4.Items.Clear();
            comboBox4.Items.AddRange(new string[] { "Su (15 TL)", "Cola (45 TL)" });
        }

        private double TutarHesapla()
        {
            double toplamTutar = 0;
            if (string.IsNullOrEmpty(Aktarim.SecilenKoltukNo)) return 0;

            int koltukSayisi = Aktarim.SecilenKoltukNo.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Length;
            toplamTutar += (Aktarim.GirisYapanKullaniciTipi == "Öğrenci" ? 80 : 120) * koltukSayisi;

            if (comboBox3.SelectedIndex != -1)
            {
                double fiyat = 0;
                string secim = comboBox3.SelectedItem.ToString();
                if (secim.Contains("Küçük")) fiyat = 40;
                else if (secim.Contains("Orta")) fiyat = 60;
                else if (secim.Contains("Büyük")) fiyat = 80;
                toplamTutar += fiyat * (double)nmrMisirAdet.Value;
            }

            if (comboBox4.SelectedIndex != -1)
            {
                double fiyat = 0;
                string secim = comboBox4.SelectedItem.ToString();
                if (secim.Contains("Su")) fiyat = 15;
                else if (secim.Contains("Cola")) fiyat = 45;
                toplamTutar += fiyat * (double)nmrIcecekAdet.Value;
            }

            return toplamTutar;
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen önce Salon ve Seans seçiniz!");
                return;
            }
            Aktarim.SecilenAVM = comboBox1.SelectedItem.ToString();
            Aktarim.SecilenSeans = comboBox2.SelectedItem.ToString();

            OturmaDuzeni frm = new OturmaDuzeni();
            frm.ShowDialog();
            label6.Text = Aktarim.SecilenKoltukNo;
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            double toplam = 0;
            listBox1.Items.Clear();
            listBox1.Items.Add("*********** SEPET DETAYI ***********");

            if (!string.IsNullOrEmpty(Aktarim.SecilenKoltukNo))
            {
                int kSayi = Aktarim.SecilenKoltukNo.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Length;
                double bFiyat = (Aktarim.GirisYapanKullaniciTipi == "Öğrenci") ? 80 : 120;
                double bToplam = bFiyat * kSayi;
                toplam += bToplam;
                listBox1.Items.Add($"{kSayi} x {Aktarim.GirisYapanKullaniciTipi} Bilet: {bToplam} TL");
            }

            if (comboBox3.SelectedIndex != -1 && nmrMisirAdet.Value > 0)
            {
                double f = 0;
                if (comboBox3.Text.Contains("Küçük")) f = 40;
                else if (comboBox3.Text.Contains("Orta")) f = 60;
                else if (comboBox3.Text.Contains("Büyük")) f = 80;
                double mToplam = f * (double)nmrMisirAdet.Value;
                toplam += mToplam;
                listBox1.Items.Add($"{nmrMisirAdet.Value} Adet Mısır: {mToplam} TL");
            }

            if (comboBox4.SelectedIndex != -1 && nmrIcecekAdet.Value > 0)
            {
                double f = 0;
                if (comboBox4.Text.Contains("Su")) f = 15;
                else if (comboBox4.Text.Contains("Cola")) f = 45;
                double iToplam = f * (double)nmrIcecekAdet.Value;
                toplam += iToplam;
                listBox1.Items.Add($"{nmrIcecekAdet.Value} Adet İçecek: {iToplam} TL");
            }

            listBox1.Items.Add("------------------------------------");
            listBox1.Items.Add("GENEL TOPLAM: " + toplam + " TL");
            listBox1.Items.Add("************************************");
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            if (string.IsNullOrEmpty(Aktarim.SecilenKoltukNo))
            {
                MessageBox.Show("Lütfen önce koltuk seçimi yapınız!");
                return;
            }
            if (cmbOdemeYontemi.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçiniz!");
                return;
            }

            double toplamTutar = TutarHesapla();
            IOdeme secilenOdeme;
            string yontem = cmbOdemeYontemi.SelectedItem.ToString();

            if (yontem == "Kredi Kartı")
            {
                if (string.IsNullOrEmpty(txtKartNo.Text)) { MessageBox.Show("Kart no giriniz!"); return; }
                secilenOdeme = new KartlaOdeme() { OdenecekTutar = toplamTutar, KartNo = txtKartNo.Text };
            }
            else if (yontem == "QR Kod")
                secilenOdeme = new QROdeme() { OdenecekTutar = toplamTutar };
            else
                secilenOdeme = new NakitOdeme() { OdenecekTutar = toplamTutar };

            MessageBox.Show(secilenOdeme.OdemeYap() + "\nİşlem Başarılı!");

            string[] koltuklar = Aktarim.SecilenKoltukNo.Split(new string[] { ", " }, StringSplitOptions.None);
            foreach (string k in koltuklar)
            {
                string anahtar = Aktarim.SecilenFilmAdi + "-" + comboBox1.Text + "-" + comboBox2.Text + "-" + k;
                Aktarim.SatilanBiletler.Add(anahtar);
            }

            Aktarim.SecilenKoltukNo = "";
            label6.Text = "Seçilen koltuk no gelmeli";
            listBox1.Items.Clear();
            nmrMisirAdet.Value = 0;
            nmrIcecekAdet.Value = 0;
            txtKartNo.Clear();
            cmbOdemeYontemi.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e) 
        {
            FilmListesi list = new FilmListesi();
            list.Show();
            this.Close();
        }

        private void cmbOdemeYontemi_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool kartSecildi = cmbOdemeYontemi.SelectedItem != null && cmbOdemeYontemi.SelectedItem.ToString() == "Kredi Kartı";
            labelKart.Visible = kartSecildi;
            txtKartNo.Visible = kartSecildi;
            if (!kartSecildi) txtKartNo.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
