using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Mart2025_Kodları
{
    public class Arac
    {
        public Arac(string? marka, string? model)
        {
            Marka = !string.IsNullOrEmpty(marka) ? marka : "marka";
            Model = !string.IsNullOrEmpty(model) ? model : "marka";
        }

        protected string? Marka { get; set; }
        protected string? Model { get; set; }

        public virtual void Hizlanma()
        {
            return;
        }
    }
    public class Araba : Arac
    {
        public Araba(string? marka, string? model) : base(marka, model)
        {
        }
        public override void Hizlanma()
        {
            Console.WriteLine("Araba hizlaniyor...");
        }
    }
    public class Motor : Arac
    {
        public Motor(string? marka, string? model) : base(marka, model)
        {
        }
        public override void Hizlanma()
        {
            Console.WriteLine("Motor hizlaniyor...");
        }
    }
}

