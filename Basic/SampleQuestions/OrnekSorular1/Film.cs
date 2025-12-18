using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    class Film
    {
        private string? Ad;
        private string? Tur;
        private decimal? Sure;

        public Film(string? ad, string? tur, decimal? sure)
        {
            Ad = ad;
            Tur = tur;
            if (sure > 0)
                Sure = sure;
            else
            {
                Console.WriteLine("Geçerli bir süre giriniz!");
                Sure = null;
            }


        }
        public void FilmBilgisi()
        {
            string sureBilgisi = Sure.HasValue ? $"{Sure} dakika" : "belirtilmemiş";
            Console.WriteLine($"{Ad}'lı filmin türü: {Tur} ve süresi: {sureBilgisi}");
        }
    }
}
