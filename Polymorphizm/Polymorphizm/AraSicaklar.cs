using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm
{
    class AraSicaklar : Yemek
    {
        /*
         * Override : metodu ezmek anlamına geliyor.Çalışma yapısını değiştirmemizi sağlıyor.
         */
        public override string SunumSekli()
        {
            return "Yanında patates kızartması ve içecek ile sunum";
        }
    }
}
