using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ocak2025_Kodları
{
    public class Calisan
    {
        public string? Adi { get; set; }
        public decimal Maas { get; set; }
        public virtual void Calis()
        {
            Console.WriteLine($"{Adi} çalışıyor.");
        }
    }
    
    public class Muhendis : Calisan
    {
        public override void Calis()
        {
            Console.WriteLine($"{Adi} mühendislik yapıyor.");
        }
    }
}
