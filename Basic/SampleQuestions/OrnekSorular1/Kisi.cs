using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    internal class Kisi
    {
        public Kisi(string? ad, string? soyad, int? dogumYili)
        {
            Ad = ad;
            Soyad = soyad;
            if (dogumYili > 0)
                DogumYili = dogumYili;
            else
            {
                Console.WriteLine("Hz. İsa'dan daha yaşlı olduğuna emin misin ?");
                DogumYili = null;
            }
        }


        public int? YasHesapla()
        {
            return DogumYili != null ? DateTime.Now.Year - DogumYili : 0;
        }

        public void YasYazdir()
        {
            Console.WriteLine($"{Ad} {Soyad} kişinin yaşı {YasHesapla()}");
        }
        private string? Ad { get; set; }
        private string? Soyad { get; set; }
        private int? DogumYili { get; set; }
    }
}
