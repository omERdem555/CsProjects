using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ocak2025_Kodları
{
    public class Cihaz
    {
        public string? Model { get; set; }
        public void Ac()
        {
            Console.WriteLine("Cihaz Açılıyor.");
        }
    }

    public class Telefon : Cihaz
    {
        public void Ara()
        {
            Console.WriteLine("Telefon arama yapıyor.");
        }
    }
}
