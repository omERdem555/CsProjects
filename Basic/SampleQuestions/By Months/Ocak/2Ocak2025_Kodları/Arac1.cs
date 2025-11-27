using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ocak2025_Kodları
{
    public class Arac1
    {
        public string? Plaka { get; set; }
        public void ParkEt()
        {
            Console.WriteLine("Araç park ediliyor");
        }
    }

    public class Otobus : Arac1
    {
        public int YolcuSayisi { get; set; }
        public void YolcuIndir()
        {
            Console.WriteLine($"Otobüs {YolcuSayisi} yolcu indiriyor.");
        }
    }
}
