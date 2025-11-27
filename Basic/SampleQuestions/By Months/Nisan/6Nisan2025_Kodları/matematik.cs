using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Nisan2025_Kodları
{
    static class matematik
    {
        public static void carp()
        {
            double a = 1;
            for (double i = 1; i < 100; i++)
            {
                Console.WriteLine(a + "\a");

                a *= i;
            }
        }
    }
}
