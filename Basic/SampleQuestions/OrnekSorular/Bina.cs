using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular
{
    internal class Bina
    {
        private static int BinaSayaci = 0;

        public Bina()
        {
            BinaSayaci++;
        }
         public void SayaciYazdir()
        {
            Console.WriteLine(BinaSayaci);
        }
    }
}
