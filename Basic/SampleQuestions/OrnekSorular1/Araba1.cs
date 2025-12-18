using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    internal class Araba1
    {
        public Araba1(decimal hiz, string? renk, string? model, string? marka)
        {
            Renk = renk;
            Model = model;
            Hiz = hiz;
            if (model == "Model1")
            {
                Model = model;
                Hiz += 1;
            }

            if (model == "Model2")
            {
                Model = model;
                Hiz += 2;
            }

            if (marka == "Marka1")
            {
                Marka = marka;
                Hiz += 2;
            }

            if (marka == "Marka2")
            {
                Marka = marka;
                Hiz += 3;
            }

        }

        private decimal Hiz { get; set; }
        private string? Renk { get; set; }
        private string? Model { get; set; }
        private string? Marka { get; set; }



        public void KazananYazdir(Araba1 digerAraba)
        {
            if (digerAraba.Hiz > Hiz)
                Console.WriteLine($"{digerAraba} {Renk} renkli {Marka} {Model} arabayı geçmiştir.");
            else if (digerAraba.Hiz < Hiz)
                Console.WriteLine($"{Renk} renkli {Marka} {Model} araba {digerAraba}");
            else if(digerAraba.Hiz ==  Hiz)
                Console.WriteLine("Arabaların hızı eşit olduğundan yarış berabere");
        }

        public override string ToString()
        {
            return $"{Renk} renkli {Marka} {Model} araba.";
        }

    }
}
