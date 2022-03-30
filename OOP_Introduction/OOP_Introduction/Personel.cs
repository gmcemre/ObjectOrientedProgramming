using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Introduction
{
    class Personel
    {
        internal string Adi;
        internal protected string Soyadi;
        public DateTime DogumTarihi;
        public string TCKN;

        public void PersonelEkle(Personel personel)
        {
            //Veritabanına personel ekleme işlemleri yapılır.
            MessageBox.Show(personel.Adi);
        }

        /*
         * Access Modifiers - Erişim Belirleyici
         * Varsayılan erişim private.
         * 1-Private: Kişisel anlamındadır.Sadece bulunduğu yapı içerisinden erişilebilir.Başka yerden erişilemez.
         * 2-Internal:Bulunduğu proje içerisinde her yerden erişimi sağlar.Farklı projeden erişime izin vermez.
         * 3-Protected:Miras alınan sınıflar içerisinden erişime izin verir.
         * 4-Internal Protected:Hem miras alınan sınıflar içerisinde erişime izin verir hem de bulunduğu proje içerisinde her yerden erişilmesine izin verir.
         * 5-Public:Umumi , kamu malıdır.Her şekilde her yerden 
         */
    }
}
