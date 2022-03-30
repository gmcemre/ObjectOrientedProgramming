using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceKavrami
{
    public interface IYakınlastirilabilir
    {
        /*
         * Interface:
         * -Interface içerisinde property,metot,indexleyici ve event haricinde birşey bulunmaz.
         * -Interface içerisindeki elemanların abstract sınıflarda olduğu gibi gövdesi bulunmaz.
         * -Abstract sınıftan 1.Farkı; gövdesi olan bir metot veya property yazamayız.
         * Abstract sınıftan 2.Farkı; interface içerisindeki elemanların access modifiers ları bulunmaz.Ve varsayılan access modifiers'ları public'tir.
         * Interface sınıflardan instance üretilemez.
         */
        string Yakinlastir();
    }
}
