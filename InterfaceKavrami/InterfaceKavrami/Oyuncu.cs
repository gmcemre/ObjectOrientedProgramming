using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceKavrami
{
    class Oyuncu
    {
        public string Adi { get; set; }
        public int Yasi { get; set; }
        public int YasamDegeri { get; set; }
        public Silah Silahi { get; set; }
        public string NisanAl()
        {
            //nişan alma işlemleri yapılacak.
            //Silahi property si IYakinlastirilabilir interface'sini iplemente almış ise yani o yeteneği kazanmış ise
            if (Silahi is IYakınlastirilabilir)
            {
                IYakınlastirilabilir iy = (IYakınlastirilabilir)Silahi;
                return iy.Yakinlastir();
            }
            else
                return "";
        }
        public void Saldir()
        {
            //saldırma işlemleri yapılacak
        }
    }
}
