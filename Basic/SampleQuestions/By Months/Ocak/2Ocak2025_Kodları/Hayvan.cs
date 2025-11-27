using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ocak2025_Kodları
{
    public class Hayvan
    {
        public string? Ad { get; set; }
        public void SesCikar()
        {
            Console.WriteLine("Hayvan sesi çıkarılıyor.");
        }
    }

    public class Kopek : Hayvan
    {
        public void Havla()
        {
            Console.WriteLine("Köpek havlıyor.");
        }
    }
}
