using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    internal class Islem
    {
        private int Vize;
        private int Final;

        private decimal OrtHesapla()
        {
            return (Vize * 2 / 5) + (Final * 3 / 5);
        }
        public Islem(int vize, int final)
        {
            if (vize > 0)
                Vize = vize;
            else
            {
                Console.WriteLine("Öğrenci negatif vize notu alamaz!");
                Vize = 0;
            }

            if (final > 0) 
                Final = final;
            else
            {
                Console.WriteLine("Öğrenci final negatif olamaz");
                Final = 0;
            }
        }


        public decimal Donustur()
        {
            return OrtHesapla() / 20;
        }
    }

}
