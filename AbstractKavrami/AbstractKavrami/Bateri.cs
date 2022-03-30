using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractKavrami
{
    class Bateri : MuzikAletleri
    {
        public override CalmaTuru CalmaTuru 
        { 
            get 
            {
                return CalmaTuru.VurmaliCalma; 
            }
            set 
            { 
                throw new NotImplementedException(); 
            }
        }

        public override string Cal()
        {
            return "Bateri Çalınıyor";
        }
    }
}
