using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulama
{
    class KimMinJoe : Futbolcu, ISavunabilable
    {
        public string SavunmaYap()
        {
            return "Savunma Yapıldı";
        }
    }
}
