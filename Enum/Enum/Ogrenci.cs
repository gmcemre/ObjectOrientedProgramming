using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Ogrenci
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Alan Alani { get; set; }
        public Cinsiyet Cinsiyet { get; set; }

    }

    /*
     * String şeklinde enumların içerisine değer yazılmaz
     * Enum içerisindeki seçenek bir kelimeden fazla olsa bile kelimeler arasında boşluk bırakılmaz. 
     * Not: Enumlar kullanıcının seçeceği seçenekler için oluşturulan bir yapı değildir.
     * Programcının uygulamasını idame ettirmesi için kullandığı bir yapıdır.
     * -Enum sınıfı içerisinde getName ve getNames isminde 2 tane metot vardır.
     * GetName: Verilen enum seçeneğinin değerini dönderir.
     * Enum.GetName(typeof(Alan),ogrenci.Alani);
     * GetNames: Geriye string dizisi dönderir.Geriye belirtilen enum tipinin içerisindeki tüm seçenekleri string olarak geri  dönderir.
     * Enum.GetNames(typeof(Alan));
     */

    //1.YÖNTEM
    public enum Alan
    {
        Sayisal,
        Sozel,
        EsitAgirlik,
        Dil
    }
    //İçerdeki elemanların sayısal değerleri değiştirilebilir isteğe bağlı şekilde.(index numaraları : varsayılan 0,1,2,3,....)
}
