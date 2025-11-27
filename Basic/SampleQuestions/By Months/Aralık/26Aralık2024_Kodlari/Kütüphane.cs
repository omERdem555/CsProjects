using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26Aralık2024_Kodlari
{

    public class Kitap
    {
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public int SayfaSayisi { get; set; }

        public Kitap(string kitapAdi, string yazarAdi, int sayfaSayisi)
        {
            KitapAdi = kitapAdi;
            YazarAdi = yazarAdi;
            SayfaSayisi = sayfaSayisi;
        }

        public override string ToString()
        {
            return $"Kitap Adı: {KitapAdi}, Yazar Adı: {YazarAdi}, Sayfa Sayısı: {SayfaSayisi}";
        }
    }

    public class Kutuphane
    {
        private List<Kitap> kitaplar;

        public Kutuphane()
        {
            kitaplar = new List<Kitap>();
        }

        public void KitapEkle(Kitap kitap)
        {
            kitaplar.Add(kitap);
            Console.WriteLine($"'{kitap.KitapAdi}' adlı kitap kütüphaneye eklendi.");
        }

        public void KitaplariListele()
        {
            if (kitaplar.Count == 0)
            {
                Console.WriteLine("Kütüphanede henüz kitap bulunmamaktadır.");
                return;
            }

            Console.WriteLine("Kütüphanedeki Kitaplar:");
            foreach (var kitap in kitaplar)
            {
                Console.WriteLine(kitap);
            }
        }

        public List<Kitap> YazaraGoreAra(string yazarAdi)
        {
            List<Kitap> bulunanKitaplar = new List<Kitap>();
            foreach (var kitap in kitaplar)
            {
                if (kitap.YazarAdi != null && kitap.YazarAdi.Equals(yazarAdi, StringComparison.OrdinalIgnoreCase))
                {
                    bulunanKitaplar.Add(kitap);
                }
            }

            if (bulunanKitaplar.Count == 0)
            {
                Console.WriteLine($"'{yazarAdi}' adlı yazara ait kitap bulunamadı.");
                return new List<Kitap>();
            }

            Console.WriteLine($"'{yazarAdi}' adlı yazara ait kitaplar:");
            foreach (var kitap in bulunanKitaplar)
            {
                Console.WriteLine(kitap);
            }

            return bulunanKitaplar;
        }
    }
}

