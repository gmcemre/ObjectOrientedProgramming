using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphizm_Uygulama
{
    class Sepet
    {
        public decimal ToplamFiyat { get; set; }
        public void UrunEkle(Urun urun)
        {
            ToplamFiyat += urun.KdvliFiyatHesapla();
            MessageBox.Show(ToplamFiyat.ToString());
        }
    }
}
