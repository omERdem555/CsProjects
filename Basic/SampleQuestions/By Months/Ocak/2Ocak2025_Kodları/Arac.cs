using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ocak2025_Kodları
{
    public class Arac
    {
        public string? Marka { get; set; }
        public void Sur()
        {
            Console.WriteLine("Araç sürülüyor");
        }
    }

    class Bisiklet : Arac
    {
        public void ZilCal()
        {
            Console.WriteLine("Bisiklet zili çalıyor.");
        }
    }
}
