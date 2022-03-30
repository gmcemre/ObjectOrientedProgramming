using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm
{
    class Yemek
    {
        public string Adi { get; set; }
        public string PismeSuresi { get; set; }
        public string Malzemeler { get; set; }
        public string AciTipi { get; set; }
        public string Asci { get; set; }
        public string PismeSekli { get; set; }
        public string PismeYeri { get; set; }

        /*
         * Virtual: Virtual komutu ile işaretlenmiş metot isteğe bağlı olarak türetilen sınıflarda değiştirilebilir anlmaına gelmektedir.Yani bu metot ezilebilir denilmiş olur.
         * 
         */
        public virtual string SunumSekli()
        {
            return "Yanında pilav ve cacık ile sunum";
        }
    }
}
