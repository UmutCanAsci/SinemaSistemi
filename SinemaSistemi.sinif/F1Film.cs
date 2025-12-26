using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaSistemi.sinif
{
    public class F1Film : Film
    {
        public F1Film() : base(
            "F1 (Apex)",
            135,
            "Aksiyon / Spor",
            "Joseph Kosinski",
            new DateTime(2025, 06, 27),
            new List<string> { "Brad Pitt", "Damson Idris", "Javier Bardem" }
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
