using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulama
{
    class Alex : Futbolcu, IOyunKurabilable, ISutCekebilable
    {
        public string CalimAt(float hiz)
        {
            return string.Format("{0} süratle çalım atıldı.", hiz);
        }

        public string OyunKur()
        {
            return "Oyun Kuruldu.";
        }

        public string SutCek(float hiz, float mesafe)
        {
            return string.Format("{0} km hızla {1} m mesafeden şut Çekildi.", hiz, mesafe);
        }
    }
}
