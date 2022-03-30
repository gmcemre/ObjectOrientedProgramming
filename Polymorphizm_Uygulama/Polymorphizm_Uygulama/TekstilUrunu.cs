using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm_Uygulama
{
    class TekstilUrunu : Urun
    {
        public string KumasTipi { get; set; }
        public string Renk { get; set; }
        public string KumasKalitesi { get; set; }
        public override decimal KdvliFiyatHesapla()
        {
            return Fiyat + (Fiyat * 0.5m);
        }
    }
}
