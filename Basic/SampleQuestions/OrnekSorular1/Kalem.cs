using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    internal class Kalem
    {
        public Kalem(string? marka, string? renk, decimal? fiyat)
        {
            Marka = marka;
            Renk = renk;
            if (fiyat > 0)
                Fiyat = fiyat;
            else
            {
                Console.WriteLine("Bir kalemin fiyatı asla negatif olamaz!");
                Fiyat = null;
            }
        }

        public void KalemBilgisi()
        {
            string fiyatBilgisi = Fiyat.HasValue ? Fiyat.Value.ToString() : "belirlenmemiştir";
            Console.WriteLine($"{Marka} markalı {Renk} kalemin fiyatı {Fiyat}.");
        }
        private string? Marka { get; set; }
        private string? Renk { get; set; }
        private decimal? Fiyat { get; set; }
    }
}
