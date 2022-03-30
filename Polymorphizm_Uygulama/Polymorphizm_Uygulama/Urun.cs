using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm_Uygulama
{
    class Urun
    {
        public string UrunAdi { get; set; }
        public int UrunAdedi { get; set; }
        public decimal Fiyat { get; set; }
        public virtual decimal KdvliFiyatHesapla()
        {
            return Fiyat + (Fiyat * 0.2m);
        }
    }
}
