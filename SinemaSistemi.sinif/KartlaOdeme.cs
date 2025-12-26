using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaSistemi.sinif
{
    public class KartlaOdeme : IOdeme
    {
        public double OdenecekTutar { get; set; }
        public string KartNo { get; set; }
        public string OdemeYap() => $"{OdenecekTutar} TL kredi kartıyla ({KartNo}) ödendi.";
    }
}
