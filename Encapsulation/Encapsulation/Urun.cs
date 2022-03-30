using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Urun
    {
        //Bir sınıf içerisinde tanımlanan değişkenlere field(alan) denir.
        //field
        private string _Adi;
        //Property
        public string Adi
        {
            get
            {
                if (_Adi == "Admin")
                {
                    return _Adi;
                }
                else
                {
                    return "Admin kullanıcısı değilsiniz";
                }
            }
            set
            {
                _Adi = value;
            }
        }

        private decimal _Fiyat;

        public decimal Fiyat
        {
            get
            {
                return _Fiyat;
            }
            set
            {
                _Fiyat = value;
            }
        }


        public decimal KdvFiyat
        {
            get
            {
                return Fiyat + (Fiyat * 0.25m);
            }
        }

        /*
         * Auto Property:
         * Arka plandaki field'ını kendi içerisinde tutar.
         * -Ayrıca field tanımlanmaz.
         * -get ve set metotları değişttirilemez.Değiştirilmek istenirse auto property bozulur.Arka plandaki field'ı elimizle tanımlamamız gerekir.
         */
        //Auto Property
        public string Soyadi { get; set; }

    }
}
