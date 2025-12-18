using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    internal class HavaDurumu
    {
        private decimal Sicaklik;
        private decimal Nem;

        public HavaDurumu(decimal sicaklik, decimal nem)
        {
            Sicaklik = sicaklik;
            Nem = nem;
        }

        public void DurumuGoster()
        {
            Console.WriteLine($"{Sicaklik} {Nem}");
        }
    }
}
