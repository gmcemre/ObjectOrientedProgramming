using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Personel
    {
        //Constructor metottur.
        public Personel()
        {
            KayitTarihi = DateTime.Now;
        }
        //Parametre alan constructor dır.
        public Personel(string ad)
        {
            Adi = ad;
        }
        public Personel(string ad, string soyad)
        {
            Adi = ad;
            Soyadi = soyad;
        }

        internal string Adi;
        internal string Soyadi;
        internal string TCKN;
        internal DateTime DogumTarihi;
        internal DateTime KayitTarihi;

        /*
         * Constructor Metot - Yapıcı Metot
         * -Nesnenin Ram'de üretilmesini sağlayan metottur.
         * Constructor metodu tanımlanmazsa varsayılan (default) constructor geçerlidir.
         * Constructor metotlarının overloadı vardır.
         * Kendimiz sınıf içerisinde constructor metodu yazabiliriz.
         * Geriye dönüş tipi olmayan tek metottur.
         * -Sınıfa kendimiz constructor tanımlarsak varsayılan constructor iptal olur.
         * -Sınıf içerisinde imzaları farklı olmak suretiyle birden fazla constructor tanımlayabiliriz.
         * -Ve bu sınıftan örnek üretirken hangi constructora uyan değerler gönderildiyse o constructor çalışır.
         * -Constructor metotlarının ismi sınıf ismi ile aynı olmalıdır.
         */
    }
}
