using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular
{
    internal class Urun
    {
        public Urun(int stok)
        {
            Stok = stok;
        }

        public int Stok { get; private set; }

        public void StokEkle(int a)
        {
            if(Stok > 0)
            {
                Stok += a;
            }
            else
                Console.WriteLine($"Yeterince stok ");
        }
    }
}
