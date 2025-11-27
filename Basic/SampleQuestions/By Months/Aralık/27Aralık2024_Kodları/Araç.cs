using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Aralık2024_Kodları
{
    internal class Araç
    {
        public Araç(string? marka, string? model)
        {
            Marka = !string.IsNullOrEmpty(marka) ? marka : "Varsayılan Marka";
            Model = !string.IsNullOrEmpty(model) ? model : "Varsayılan Model";
            KiradaMı = false;
        }

        internal string? Marka { get; set; }
        internal string? Model { get; set; }
        internal bool KiradaMı { get; set; }

        public override string ToString()
        {
            return $"{Marka} / {Model} Araç {new string(KiradaMı ? "Kirada" : "Kiralanabilir")}.";
        }
    }

    internal class KiralamaSistemi
    {
        List<Araç> AraçlarınListesi = new List<Araç>();

        public void AracEkle(Araç arac)
        {
            if (!AracVarMı(AraçlarınListesi)) { return; }

            foreach (Araç A in AraçlarınListesi)
            {
                if (!A.Model.Contains(arac.Model) && !A.Marka.Contains(arac.Marka))
                {
                    AraçlarınListesi.Add(arac);
                    Console.WriteLine($"{arac.Marka} {arac.Model} araç başarıyla listeye eklenmiştir.");
                }
                else
                {
                    Console.WriteLine("Listede zaten böyle bir araç bulunmaktadır.");
                }
            }
        }

        public void AracKirala(string marka, string model)
        {
            if (!AracVarMı(AraçlarınListesi)) { return; }

            foreach (Araç A in AraçlarınListesi)
            {
                if(A.Marka.Contains(marka) && A.Model.Contains(model))
                {
                    A.KiradaMı = true;
                    Console.WriteLine($"{marka} {model} araç, kiralanmıştır.");
                }
            }
        }

        public void KiralanabilirAraclariListele()
        {
            if (!AracVarMı(AraçlarınListesi)) { return; }

            foreach (Araç araç in AraçlarınListesi)
            {
                if(!araç.KiradaMı)
                    Console.WriteLine(araç);
            }
        }

        private bool AracVarMı(List<Araç> A)
        {
            if (A.Count == 0)
                return false;
            else
                return true;
        }
    }
}
