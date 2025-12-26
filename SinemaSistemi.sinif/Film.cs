    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaSistemi.sinif
{
    public abstract class Film
    {
        public string Ad { get; set; }
        public int Sure { get; set; }
        public string Tur { get; set; }
        public string Yonetmen { get; set; }
        public List<string> Oyuncular { get; set; } = new List<string>();
        public DateTime VizyonTarihi { get; set; }

       
        public Film(string ad, int sure, string tur, string yonetmen, DateTime vizyonTarihi, List<string> oyuncuListesi)
        {
            Ad = ad;
            Sure = sure;
            Tur = tur;
            Yonetmen = yonetmen;
            VizyonTarihi = vizyonTarihi;
            Oyuncular = oyuncuListesi;
        }

        public abstract string FilmBilgisiGoster();
    }
}

