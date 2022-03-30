using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm
{
    class SebzeYemekleri : Yemek
    {
        public string SebzeTuru { get; set; }
        public string SuluSusuz { get; set; }

        public override string SunumSekli()
        {
            return "Yanında salata ve yoğurt ile sunum";
        }
    }
}
