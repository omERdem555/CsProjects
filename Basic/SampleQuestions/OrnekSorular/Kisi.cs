using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular
{
    class Kisi
    {
        public string? Ad;
        public string? Soyad;
        private Adres? Adres;

        public Kisi(string? ad, string? soyad, Adres? adres)
        {
            Ad = ad;
            Soyad = soyad;
            Adres = adres;
        }

        public void Yazdir()
        {
            Console.WriteLine($"{Ad} {Soyad} {Adres}");
        }
    }

    class Adres
    {
        public string? Sokak;
        public string? Il;

        public Adres(string? sokak, string? ıl)
        {
            Sokak = sokak;
            Il = ıl;
        }

        public override string ToString()
        {
            return $"{Sokak} {Il}";
        }
    }
}
