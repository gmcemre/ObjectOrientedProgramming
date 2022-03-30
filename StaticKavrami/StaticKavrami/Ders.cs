using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKavrami
{
    static class Ders
    {
        /*
         * Static sınıflardan instance alınamaz.
         * Static sınıf içerisinde static olmayan eleman bulunamaz.
         * Bir sınıf içerisinde bulunan elemanların tümü static olacaksa sınıfta static olarak tanımlanır..
         * Zaten instance almadan sınıf içerisindeki tüm static elemanlara ulaşılabiliyor.
         */

        public static int Id { get; set; }
    }
}
