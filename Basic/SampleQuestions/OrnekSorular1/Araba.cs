using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    internal class Araba
    {
        public Araba(string? marka, string? model, int? yil)
        {
            Marka = marka;
            Model = model;
            if (yil > 0)
                Yil = yil;
            else
            {
                Console.WriteLine("Lütfen geçerli bir yıl giriniz!");
                Yil = null;
            }
        }

        private string? Marka { get; set; }
        private string? Model { get; set; }
        private int? Yil { get; set; }

        public void BilgileriYazdir()
        {
            Console.WriteLine($"{Marka} marka {Model} model arabanın üretim tarihi {Yil}'dır");
        }

    }
}
