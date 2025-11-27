using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26Aralık2024_Kodlari
{
    using System;
    using System.Collections.Generic;

    internal class Kargo
    {
        private static List<Kargo> kargoListesi = new List<Kargo>();

        private int KargoNumarası { get; set; }
        private string? Göndericisi { get; set; }
        private string? Alıcı { get; set; }
        private string? Durum { get; set; }

        public Kargo(string? göndericisi, string? alıcı)
        {
            Göndericisi = !string.IsNullOrEmpty(göndericisi) ? göndericisi : "Gönderen";
            Alıcı = !string.IsNullOrEmpty(alıcı) ? alıcı : "Alıcı";
            KargoNumarası = new Random().Next(1, 1000000);
            Durum = "Teslimat Hazır!";

            kargoListesi.Add(this);
            Console.WriteLine("Kargo başarıyla oluşturuldu ve listeye eklendi.");
        }

        public void DurumGüncelle(int kargoNo, string? yeniDurum)
        {
            foreach (var kargo in kargoListesi)
            {
                if (kargo.KargoNumarası == kargoNo)
                {
                    kargo.Durum = yeniDurum;
                    Console.WriteLine($"Kargo {kargoNo} için durum '{yeniDurum}' olarak güncellendi.");
                    return;
                }
            }
            Console.WriteLine($"Kargo numarası {kargoNo} ile eşleşen kargo bulunamadı.");
        }

        public static void TeslimEdilenleriListele()
        {
            bool teslimEdilenVarMi = false;

            foreach (var kargo in kargoListesi)
            {
                if (kargo.Durum == "Teslim Edildi!")
                {
                    Console.WriteLine(kargo);
                    teslimEdilenVarMi = true;
                }
            }

            if (!teslimEdilenVarMi)
            {
                Console.WriteLine("Teslim edilen herhangi bir kargo bulunmamaktadır.");
            }
        }

        public static void TumKargolariListele()
        {
            if (kargoListesi.Count == 0)
            {
                Console.WriteLine("Henüz kargo bulunmamaktadır.");
                return;
            }

            foreach (var kargo in kargoListesi)
            {
                Console.WriteLine(kargo);
            }
        }
        public override string ToString()
        {
            return $"Kargo Bilgisi:\n" +
                   $"Gönderici: {Göndericisi}\n" +
                   $"Alıcı: {Alıcı}\n" +
                   $"Kargo Numarası: {KargoNumarası}\n" +
                   $"Durum: {Durum}";
        }
    }
}
