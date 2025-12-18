using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    internal class Araba2
    {
        public Araba2(string? marka, string? model)
        {
            if (!string.IsNullOrEmpty(marka))
                Marka = marka;
            else
            {
                Console.WriteLine("Marka bilgisi boş bırakılamaz!");
                Marka = "Bilinmiyor";
            }

            if (!string.IsNullOrEmpty(model))
                Model = model;
            else
            {
                Console.WriteLine("Model bilgisi boş bırakılamaz!");
                Model = "Bilinmiyor";
            }
        }

        private string? Marka { get; set; }
        private string? Model { get; set; }

        public void BilgileriGoster()
        {
            Console.WriteLine($"Marka: {Marka}, Model: {Model}");
        }
    }
}
