using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractKavrami
{
    abstract class MuzikAletleri
    {
        /*
         * Abstract(soyut) :
         * -Abstract sınıflar sadece miras verilmek için tasarlanan sınıflardır.
         * -Abstractlar sınıfa özel değil , bir property bir metot veya herhangi bir eleman abstract olabilir.
         * Bir metodun abstract olması o metot miras verilen sınıflarda ezilmek zorundadır.
         * -Abstract metotların gövdesi olmaz.
         * -Abstract metotlar abstract olmayan sınıfta bulunamaz
         * -Abstract sınıflar içerisindeki abstract olan property veya metotların gövdesi olmadığı için bu metotlara erişilmesi diye abstract sınıflardan instance üretilemez.
         * -Sınıf abstract olsa da içerisinde abstract olmayan metot veya property bulunabilir.
         * -Ancak abstract bir metot veya bir property abstract olmayan sınıfta bulunamaz.
         */

        public abstract string Cal();
        public string Mensei { get; set; }
        public DateTime UretimTarihi { get; set; }
        public abstract CalmaTuru CalmaTuru { get; set; }
    }
}
