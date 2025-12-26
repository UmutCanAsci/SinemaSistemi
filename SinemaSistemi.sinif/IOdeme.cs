using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaSistemi.sinif
{
    public interface IOdeme
    {
        double OdenecekTutar { get; set; }
        string OdemeYap(); 
    }
}
