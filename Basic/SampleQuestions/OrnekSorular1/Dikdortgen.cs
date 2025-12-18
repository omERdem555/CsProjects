using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    internal class Dikdortgen
    {
        private decimal? Genislik { get; set; }
        private decimal? Yukseklik { get; set; }

        public Dikdortgen(decimal genislik, decimal yukseklik)
        {
            if (genislik > 0)
                Genislik = genislik;
            else
            {
                Console.WriteLine("Genişlik negatif bir değer olamaz!");
                Genislik = null;
            }
            if (yukseklik > 0)
                Yukseklik = yukseklik;
            else
            {
                Console.WriteLine("Yükseklik negatif bir değer olamaz!");
                Yukseklik = null;
            }
        }

        public decimal? AlanHesapla()
        {
            return Genislik * Yukseklik;
        }

        public void AlanYazdir()
        {
            Console.WriteLine($"Bu dikdörtgenin alanı: {AlanHesapla()}");
        }
    }
}
