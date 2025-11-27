using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ocak2025_Kodları
{
    public class Kitap
    {
        public string? Ad { get; set; }
        public void Oku()
        {
            Console.WriteLine("Kitap okunuyor.");
        }
    }

    public class Roman : Kitap
    {
        public string? Yazar { get; set; }
        public void YazariGoster()
        {
            Console.WriteLine($"Bu romanın yazarı: {Yazar}");
        }
    }
}
