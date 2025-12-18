using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular
{
    internal class Bilgisayar
    {
        private string? Marka;
        private string? Model;
        private byte IslemciHizi;

        public Bilgisayar(string? marka, string? model)
        {
            Marka = marka;
            Model = model;
            IslemciHizi = 0;
        }

        public Bilgisayar(string? marka, string model, byte islemciHizi) 
        {
            Marka = marka;
            Model = model;
            IslemciHizi = islemciHizi;
        }

        public void BilgileriYazdir()
        {
            Console.WriteLine($"{Marka} {Model} {IslemciHizi}");
        }
    }
}
