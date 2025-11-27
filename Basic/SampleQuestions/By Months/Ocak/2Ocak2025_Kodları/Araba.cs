using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ocak2025_Kodları
{
    public class Araba
    {
        public Araba(string? marka, string? model, int yil)
        {
            Marka = !string.IsNullOrEmpty(marka) ? marka : "Marka";
            Model = !string.IsNullOrEmpty(model) ? model : "Model";
            Yil = (yil > 0) ? yil : 0;
        }

        public string? Marka { get; set; }
        public string? Model { get; set; }
        public int Yil { get; set; }
        public int Hiz = 0;
        public virtual void Hizlan()
        {
            Hiz = (Hiz < 100) ? Hiz + 10 : Hiz;
        }
        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Arabanın Marka: {Marka}\n" +
                $"Model: {Model}\n" +
                $"Yılı: {Yil}");
        }
    }

    public class ElektrikliAraba : Araba
    {
        public ElektrikliAraba(string? marka, string? model, int pilYuzdesi, int yil) : base(marka, model, yil)
        {
            Marka = !string.IsNullOrEmpty(marka) ? marka : "Marka";
            Model = !string.IsNullOrEmpty(model) ? model : "Model";
            PilYuzdesi = (pilYuzdesi <= 100 && pilYuzdesi >= 0) ? pilYuzdesi : 0;
            Yil = (yil > 0) ? yil : 0;
        }
        public int PilYuzdesi { get; set; }
        public override void Hizlan()
        {
            Hiz = (Hiz + 10 <= 100) ? Hiz + 10 : 100;
            PilYuzdesi = (PilYuzdesi - 5 >= 0) ? PilYuzdesi - 5: 0;
        }

        public override void BilgileriYazdir()
        {
            Console.WriteLine($"Arabanın Marka: {Marka}\n" +
                $"Model: {Model}\n" +
                $"Yılı: {Yil}\n" +
                $"Pili: {PilYuzdesi}");
        }
    }
}
