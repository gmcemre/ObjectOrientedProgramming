using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMimari
{
    class Ogrenci<T, H, Y> where T : class where H : struct
    {
        /*
         * Generic:
         * Dışarıdan bir tip alarak çalışmayı sağlayan bir yapıdır.
         */
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Y OkulNo { get; set; }
        public H Okulu { get; set; }
        public T Temsili { get; set; }
        public void Ekle(T prm)
        {

        }
    }
}
