using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMimari
{
    class Person
    {
        public string Name { get; set; }
        public string Branch { get; set; }

        public string Add<T>(T prm)
        {
            return " Generic çalıştı";
        }
    }
}
