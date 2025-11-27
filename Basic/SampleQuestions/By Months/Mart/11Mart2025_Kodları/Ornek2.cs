using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Mart2025_Kodları
{
    public class Ornek2
    {
        public int Aprop { get; set; }
        public int Bprop { get; set; }

        public Ornek2()
        {
            Console.WriteLine("Ornek2 Class " + Aprop + Bprop);
        }

        public Ornek2(int aprop, int bprop)
        {
            Aprop = aprop;
            Bprop = bprop;
            Console.WriteLine("Ornek2 Class " + Aprop + Bprop);
        }
    }

    public class A : Ornek2
    {
        public A()
        {
            Console.WriteLine("A Class " + Aprop + Bprop);
        }
    }
}
