using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaSistemi.sinif
{
    public class YanYanaFilm : Film
    {
        public YanYanaFilm() : base(
        "Yan Yana",
        110,
        "Dram/Komedi",
        "Mesut Baykul",
        new DateTime(2025, 11, 14),
        new List<string> { "Haluk Bilginer", "Feyyaz Yiğit", "Kader Köse" } 
    )
        { }
        public override string FilmBilgisiGoster()
        {
            return $"Film Adı: {Ad}\n" +
                   $"Süre: {Sure} dakika\n" +
                   $"Tür: {Tur}\n" +
                   $"Yönetmen: {Yonetmen}\n" +
                   $"Vizyon Tarihi: {VizyonTarihi.ToShortDateString()}\n" +
                   $"Oyuncular: {string.Join(", ", Oyuncular)}";
        }


    }
}

