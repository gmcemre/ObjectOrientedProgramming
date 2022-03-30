using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulama
{
    class Muslera : Futbolcu, ITopTutabilable
    {
        public string TopTut()
        {
            return "Top Tutuldu.";
        }
    }
}
