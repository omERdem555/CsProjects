using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Nisan2025_Kodları
{
    public class Insan
    {
        public Insan(int yas, string ısim, string soyisim, int kilo, double boy)
        {
            Yas = yas;
            Isim = ısim;
            Soyisim = soyisim;
            Kilo = (kilo == null) ? 50 : kilo;
            Boy = (boy == null) ? 1.50: boy;
        }

        
        public Insan(int yas, string ısim, string soyisim)
        {
            Yas =yas;
            Isim = ısim;
            Soyisim = soyisim;
        }

        public int Yas { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public int Kilo { get; set; }
        public double Boy { get; set; }


        public void Konus()
        {
            Console.WriteLine($"Benim adım {Isim} soyadım {Soyisim}. Kilom {Kilo} ve boyum {Boy}");
        }


    }
}
