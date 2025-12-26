using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaSistemi.sinif
{
    public class ZootropolisFilm : Film
    {
        public ZootropolisFilm() : base(
        "Zootropolis 2",
        105,
        "Animasyon / Macera",
        "Byron Howard",
        new DateTime(2025, 11, 24),
        new List<string> { "Ginnifer Goodwin", "Jason Bateman", "Idris Elba" }
    )
        { }

        public override string FilmBilgisiGoster()
        {
            return $"Film Adı: {Ad}\n" +
                   $"Süre: {Sure} dk\n" +
                   $"Tür: {Tur}\n" +
                   $"Yönetmen: {Yonetmen}\n" +
                   $"Vizyon Tarihi: {VizyonTarihi.ToShortDateString()}\n" +
                   $"Oyuncular: {string.Join(", ", Oyuncular)}";
        }
    }
       
}
