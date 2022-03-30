using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulama
{
    class Ronaldo : Futbolcu, ISutCekebilable
    {
        public string SutCek(float hiz, float mesafe)
        {
            return string.Format("{0} km hızla {1} m mesafeden şut Çekildi.", hiz, mesafe);
        }
    }
}
