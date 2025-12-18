using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    internal class Urun
    {
        private string? Ad;
        private int? Fiyat;
        private int? KDV;

        public Urun(string? ad, int? fiyat, int? kDV)
        {
            Ad = ad;
            if (fiyat > 0)
                Fiyat = fiyat;
            else
            {
                Console.WriteLine("Ürün için girdiğiniz negatif fiyat geçersizdir!");
                Fiyat = null;
            }
            if (kDV > 0)
                KDV = kDV;
            else
            {
                Console.WriteLine("Ürün için girdiğiniz negatif KDV geçersizdir!");
                KDV = null;
            }
        }
        private int? FiyatHesapla()
        {
            if (Fiyat.HasValue && KDV.HasValue)
                return Fiyat * (1 + KDV / 100);
            else
                return null;
        }

        public void FiyatYazdır()
        {
            var hesaplananFiyat = FiyatHesapla();
            string fiyatBilgisi = hesaplananFiyat.HasValue ? hesaplananFiyat.Value.ToString() : "geçersiz";
            Console.WriteLine($"Ürünün fiyatı: {fiyatBilgisi}");
        }
    }
}
