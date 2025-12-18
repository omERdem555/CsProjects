using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    public class Kitap3
    {
        public Kitap3(byte sayfaSayisi)
        {
            if (sayfaSayisi > 0)
            {
                SayfaSayisi = sayfaSayisi;
            }
            else
            {
                Console.WriteLine("Sayfa sayısı 0 veya negatif olamaz! Varsayılan olarak 1 atanmıştır.");
                SayfaSayisi = 1;
            }
        }

        private string KitapAdi { get; set; } = "Belirtilmedi";
        private string YazarAdi { get; set; } = "Belirtilmedi";
        private byte SayfaSayisi { get; set; }

        public void KitapAdiGir()
        {
            Console.Write("Kitabın adını giriniz: ");
            string? ad = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(ad))
            {
                KitapAdi = ad;
            }
            else
            {
                Console.WriteLine("Kitabın adı boş olamaz! Varsayılan ad atanmıştır.");
                KitapAdi = "Boş_Kitap";
            }
        }

        public void YazarAdiGir()
        {
            Console.Write("Yazarın adını giriniz: ");
            string? ad = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(ad))
            {
                YazarAdi = ad;
            }
            else
            {
                Console.WriteLine("Yazarın adı boş olamaz! Varsayılan ad atanmıştır.");
                YazarAdi = "Boş_Yazar";
            }
        }

        public void KitapBilgileriniGoster()
        {
            Console.WriteLine($"Kitap Bilgileri:\nAdı: {KitapAdi}\nYazarı: {YazarAdi}\nSayfa Sayısı: {SayfaSayisi}");
        }
    }
}
