using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular
{
    internal class KrediKarti
    {
        public int KartNumarasi;
        private int Bakiye;
        public int Limit;

        public KrediKarti(int kartNumarasi, int bakiye, int limit)
        {
            if (kartNumarasi < 0)
                Console.WriteLine("\aKart Numarasi Negatif Sayilar Olamaz!");
            else
                KartNumarasi = kartNumarasi;

            if (bakiye < 0)
                Console.WriteLine("\aBakiye Negatif Olamaz!");
            else
                Bakiye = bakiye;

            if (limit < 0)
                Console.WriteLine("\aLimit Negatif Olamaz!");
            else
                Limit = limit;
        }

        public void ParaCek(int kartNumarasi, int deger)
        {
            if (kartNumarasi == KartNumarasi)
            {
                if (Bakiye - deger < 0)
                    Console.WriteLine("\aHesapta Yeterince Para Yoktur!");
                else
                {
                    Bakiye -= deger;
                    Console.WriteLine($"Yeni Bakiye: {Bakiye}");
                }
            }
            else
                Console.WriteLine("\aGeçersiz Kart Numarası Girdiniz!");
        }

        public void ParaYatir(int kartNumarasi, int deger)
        {
            if (kartNumarasi == KartNumarasi)
            {
                if (Bakiye <= Limit)
                    Bakiye += deger;
                else
                    Console.WriteLine($"Bu hesapta {Bakiye} kadar para vardır ve sadece {Limit-Bakiye} kadar para yüklenebilir.");
            }
            else
                Console.WriteLine("\aGeçersiz Kart Numarası Girdiniz!");
        }
    }
}
