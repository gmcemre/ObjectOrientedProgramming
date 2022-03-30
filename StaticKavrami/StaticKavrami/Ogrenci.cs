using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKavrami
{
    class Ogrenci
    {
        public Ogrenci()
        {
            TanimliOgrenciSayisi++;
        }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string OkulNo { get; set; }
        public string Sinif { get; set; }
        public static int TanimliOgrenciSayisi { get; set; }
        public static int Ekle()
        {
            //Veri tabanına öğrenci ekleme yapan metot.
            //Static metotlar içerisinde static olmayan elemanlar ulaşılamaz.
            //Static metotlar içerisinde sadece static elemanlara ulaşılabilir.
            return TanimliOgrenciSayisi;
        }

        /*
         * Static:
         * Sınıftan instance almadan sınıfın sonuna nokta koyarak static elemana ulaşmamızı sağlar.
         */
    }
}
