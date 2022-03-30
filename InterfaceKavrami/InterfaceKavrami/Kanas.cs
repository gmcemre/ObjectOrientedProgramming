using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceKavrami
{
    class Kanas : AtesliSilahlar, IYakınlastirilabilir
    {
        public string Yakinlastir()
        {
            return "Yakınlaştırıldı..";
        }
    }
}
