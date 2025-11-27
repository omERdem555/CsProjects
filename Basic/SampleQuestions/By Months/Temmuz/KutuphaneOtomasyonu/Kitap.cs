using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu
{
    public class Kitap
    {
        public string? KitapAd { get; set; }
        public string? YazarAd { get; set; }
        public int KitapSayfa { get; set; }
        public string? KitapTuru { get; set; }

        public Kitap(string kitapAd, string yazarAd, int kitapSayfa, string kitapTuru)
        {
            KitapAd = kitapAd;
            YazarAd = yazarAd;
            KitapSayfa = kitapSayfa;
            KitapTuru = kitapTuru;
        }

        override public string ToString()
        {
            return $"{new string('-',20)}\nKitap Adi: {KitapAd}\n Yazar Adi: {YazarAd}\n Sayfa Sayisi: {KitapSayfa}\n Kitap Turu: {KitapTuru}\n{new string('-', 20)}";
        }
    }
}
