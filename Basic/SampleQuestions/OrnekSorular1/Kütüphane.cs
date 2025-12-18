using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    public class Kütüphane
    {
        public List<string> KitapListesi { get; set; }

        public Kütüphane()
        {
            KitapListesi = new List<string>();
        }

        public void KitapEkle()
        {
            Console.Write("Eklemek istediğiniz kitabın adını giriniz: ");
            string? ad = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(ad))
            {
                KitapListesi.Add(ad);
                Console.WriteLine($"{ad} adlı kitap listeye eklendi.");
            }
            else
            {
                Console.WriteLine("Kitap adı boş olamaz! 'Boş_Kitap' varsayılan olarak eklendi.");
                KitapListesi.Add("Boş_Kitap");
            }
        }

        public void KitapSil()
        {
            Console.Write("Silmek istediğiniz kitabın adını giriniz: ");
            string? ad = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(ad))
            {
                if (KitapListesi.Remove(ad))
                {
                    Console.WriteLine($"{ad} adlı kitap listeden silindi.");
                }
                else
                {
                    Console.WriteLine($"'{ad}' adlı kitap listede bulunamadı.");
                }
            }
            else
            {
                Console.WriteLine("Boş bir kitap adı girilemez!");
            }
        }

        public void KitapListele()
        {
            if (KitapListesi.Count > 0)
            {
                Console.WriteLine("Kütüphanedeki kitaplar:");
                foreach (string kitap in KitapListesi)
                {
                    Console.WriteLine($"- {kitap}");
                }
            }
            else
            {
                Console.WriteLine("Kütüphanede hiç kitap bulunmamaktadır.");
            }
        }
    }
}
