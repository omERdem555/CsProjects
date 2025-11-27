using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Aralık2024_Kodları
{
    internal class Yemek
    {
        public Yemek(string? yemekAdi, int fiyat)
        {
            YemekAdi = !string.IsNullOrEmpty(yemekAdi) ? yemekAdi : "Varsayılan Yemek";
            Fiyat = (fiyat > 0) ? fiyat : 0;
        }

        internal string? YemekAdi { get; set; }
        internal int Fiyat { get; set; }

        public override string ToString()
        {
            return $"{YemekAdi} - Fiyatı: {Fiyat}TL";
        }

    }
    internal class Sipariş
    {
        List<Yemek>? SiparişListesi = new List<Yemek>();

        public void SiparisEkle(List<Yemek> yemekler)
        {
            if (yemekler == null)
            {
                Console.WriteLine("Boş bir şekilde yemek siparişi yapılamaz");
                return;
            }
            else
            {
                SiparişListesi.AddRange(yemekler);
                Console.WriteLine("Sipariş başarıyla oluşturuldu");
            }
        }
        public void ToplamFiyatiHesapla()
        {
            int toplamFiyat = SiparişListesi.Sum(yemek => yemek.Fiyat);

            Console.WriteLine($"Siparişinizin toplam fiyatı: {toplamFiyat}");
        }
        public void TumSiparisiListele()
        {
            if (SiparişListesi.Count == 0)
            {
                Console.WriteLine("Listede hiç sipasiş bulunmamaktadır.");
                return;
            }
            else
            {
                foreach (Yemek yemek in SiparişListesi)
                {
                    Console.WriteLine(yemek);
                }
            }
        }
    }
}
