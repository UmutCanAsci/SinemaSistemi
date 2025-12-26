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
    public partial class OturmaDuzeni : Form
    {
        public OturmaDuzeni()
        {
            InitializeComponent();
        }
        List<string> suAnkiSecilenler = new List<string>();
        private void OturmaDuzeni_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button && ctrl.Text != "Seçili Koltukları Onayla")
                {
                    string anahtar = Aktarim.SecilenFilmAdi + "-" + Aktarim.SecilenAVM + "-" + Aktarim.SecilenSeans + "-" + ctrl.Text;

                    if (Aktarim.SatilanBiletler.Contains(anahtar))
                    {
                        ctrl.BackColor = Color.Red;
                        ctrl.Enabled = false;       
                    }
                    else
                    {
                        ctrl.BackColor = Color.White; 
                        ctrl.Enabled = true;
                    }
                }
            }
        }
        string secilenKoltukNo = "";
        private void Koltuk_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.BackColor == Color.Yellow) 
            {
                btn.BackColor = Color.White;
                suAnkiSecilenler.Remove(btn.Text);
            }
            else 
            {
                btn.BackColor = Color.Yellow;
                suAnkiSecilenler.Add(btn.Text);
            }
        }
        

        
        private void TumKoltuklariTemizle()
        {
            foreach (Control ctrl in this.Controls)
            {
                
                if (ctrl is Button && ctrl.Text != "Seçili Koltukları Onayla")
                {
                    ctrl.BackColor = Color.White;
                }
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (suAnkiSecilenler.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir koltuk seçiniz!");
                return;
            }
            Aktarim.SecilenKoltukNo = string.Join(", ", suAnkiSecilenler);
            this.Close();
        }
    }
}
