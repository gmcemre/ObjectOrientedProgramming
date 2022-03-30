using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractKavrami
{
    class Keman : MuzikAletleri
    {
        public override CalmaTuru CalmaTuru
        {
            get
            {
                return CalmaTuru.TelliCalma;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override string Cal()
        {
            return "Keman Çalınıyor";
        }
    }
}
