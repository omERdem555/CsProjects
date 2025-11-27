using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ocak2025_Kodları
{
    internal class AyrıkYapılarSorusu
    {
        public static void BölünebilenSayılar()
        {
            int kaçTane = 0;
            for (int i = 1; i < 1000; i++)
            {
                if(i % 2 == 0 || i % 5 == 0)
                    kaçTane++;
            }
            Console.WriteLine(kaçTane);
        }
    }
}
