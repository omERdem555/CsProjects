using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular2
{
    class Sinif
    {
        public Sinif(int yas)
        {
            Yas = yas;
            Console.WriteLine("Base Class");
        }

        public int Yas { get; set; }
        public void Metod()
        {
            Console.WriteLine("Metod1");
        }

    }

    class Sinif2 : Sinif
    {
        public Sinif2(int yas) : base(yas)
        {
            Console.WriteLine("Class");
        }

        public void Metod()
        {
            Console.WriteLine("Metod2");
        }

        public void farklı() { }
    }
}
