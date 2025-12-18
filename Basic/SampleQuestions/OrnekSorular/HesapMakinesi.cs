using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular
{
    internal class HesapMakinesi
    {
        public double Toplama(double a, double b)
        { return a + b; }
        public double Cıkarma(double a, double b)
        { return a - b; }
        public double Carpma(double a, double b)
        { return a * b; }
        public double Bolme(double a, double b)
        {
            if (b < 0)
            {
                Console.WriteLine("\aBolme isleminde payda 0 olamaz");
                return 0;
            }
            else
                return a / b;
        }
    }
}
