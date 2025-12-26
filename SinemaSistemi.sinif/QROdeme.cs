using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaSistemi.sinif
{
    public class QROdeme : IOdeme
    {
        public double OdenecekTutar { get; set; }
        public string OdemeYap() => $"{OdenecekTutar} TL QR kod ile dijital olarak ödendi.";
    }
}
