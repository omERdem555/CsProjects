using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    internal class Daire
    {
        private decimal YariCap;
        private const decimal pi = 3.14M;
        public Daire(decimal yariCap)
        {
            if (yariCap > 0)
                YariCap = yariCap;
            else
            {
                Console.WriteLine("Bir dairenin yarıçapı negatif olamaz");
                YariCap = 0;
            }
        }
        private decimal AlanHesapla()
        {
            return pi * YariCap * YariCap;
        }
        private decimal CevreHesapla()
        {
            return 2 * pi * YariCap;
        }

        public void AlanYazdır()
        {
            Console.WriteLine($"{YariCap} yarıçaplı dairenin alanı: {AlanHesapla()}");
        }
        public void CevreYazdır()
        {
            Console.WriteLine($"{YariCap} yarıçaplı dairenin cevresi: {CevreHesapla()}");
        }
    }
}
