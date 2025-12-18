using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    class Ogrenci
    {
        private string? Ad { get; set; }
        private string? Soyad { get; set; }
        private int No { get; set; }

        public Ogrenci(string? ad, string? soyad, int no)
        {
            Ad = ad;
            Soyad = soyad;
            if (no > 0)
                No = no;
            else
                No = 0;
        }

        void BilgileriYazdir()
        {
            Console.WriteLine($"{Ad} {Soyad} adlı öğrencinin numarası: {No}");
        }
    }
}
