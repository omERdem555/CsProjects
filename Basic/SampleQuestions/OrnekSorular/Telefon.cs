using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular
{
    internal class Telefon
    {
        public string? Marka;
        public string? Model;
        private int Fiyat;

        public Telefon(string? marka, string? model, int fiyat)
        {
            Marka = marka;
            Model = model;
            if (fiyat > 0)
                Fiyat = fiyat;
            else
            {
                Console.WriteLine("\aGirdiğiniz telefon fiyatı negatif olamaz!");
                Fiyat = 0;
            }
        }
    }
}
