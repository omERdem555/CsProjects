using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    internal class Kitap2
    {
        public string KitapAdi { get; private set; }
        public string YazarAdi { get; private set; }
        public int MevcutAdet { get; private set; }
        public Kitap2(string kitapAdi, string yazarAdi, int adet)
        {
            KitapAdi = kitapAdi;
            YazarAdi = yazarAdi;
            MevcutAdet = adet > 0 ? adet : 0;
        }

        public void KitapOduncAl()
        {
            if (MevcutAdet > 0)
            {
                MevcutAdet--;
                Console.WriteLine($"{KitapAdi} kitabını ödünç aldınız. Kalan adet {MevcutAdet}");
            }
            else
                Console.WriteLine($"{KitapAdi} kitabı mevcut değildir!");
        }

        public void KitapIadeEt()
        {
            Console.WriteLine($"{KitapAdi} kitabını iade ettiniz.");
            MevcutAdet++;
        }
    }
    internal class Kutuphane
    {
        private List<Kitap2> kitaplar = new List<Kitap2>();
        public void KitapEkle(string kitapAdi, string yazarAdi, int adet)
        {
            var kitap = new Kitap2(kitapAdi, yazarAdi, adet);
            kitaplar.Add(kitap);
            Console.WriteLine($"{kitapAdi} kitabı eklendi. Adet: {adet}");
        }
        public void KitapOduncAl(string kitapAdi)
        {
            var kitap = kitaplar.FirstOrDefault(k => k.KitapAdi == kitapAdi);
            if (kitap != null)
            {
                kitap.KitapOduncAl();
            }
            else
            {
                Console.WriteLine($"{kitapAdi} isimli kitap kütüphanede bulunmuyor!");
            }
        }
        public void KitapIadeEt(string kitapAdi)
        {
            var kitap = kitaplar.FirstOrDefault(k => k.KitapAdi == kitapAdi);
            if (kitap != null)
            {
                kitap.KitapIadeEt();
            }
            else
            {
                Console.WriteLine($"{kitapAdi} isimli kitap kütüphanede bulunmuyor, iade edilemez!");
            }
        }
        public void TumKitaplariListele()
        {
            if (kitaplar.Count > 0)
            {
                Console.WriteLine("Kütüphanedeki kitaplar:");
                foreach (var kitap in kitaplar)
                {
                    Console.WriteLine($"{kitap.KitapAdi} - {kitap.YazarAdi} (Mevcut: {kitap.MevcutAdet})");
                }
            }
            else
            {
                Console.WriteLine("Kütüphanede kitap bulunmuyor.");
            }
        }
    }
}