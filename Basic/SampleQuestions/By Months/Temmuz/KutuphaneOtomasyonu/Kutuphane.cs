using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu
{
    public static class Kutuphane
    {
        public static List<Kitap> kitaplar = new List<Kitap>();
        static Kutuphane()
        {
            Console.WriteLine("Kutuphane Otomasyonu Baslatildi.");
            new List<Kitap>();
        }


        public static void KitapEkle(Kitap kitap)
        {
            kitaplar.Add(kitap);
            Console.WriteLine("Kitap Ekleme Islemi Gerceklestirildi.");
        }
        public static void KitapSil(Kitap kitap)
        {
            kitaplar.Remove(kitap);
            Console.WriteLine("Kitap Silme Islemi Gerceklestirildi.");
        }
        public static void KitaplariListele()
        {
            if (kitaplar.Count == 0)
            {
                Console.WriteLine("Kutuphane Bos.");
                return;
            }
            else
            {
                foreach (Kitap kitap in kitaplar)
                {
                    Console.WriteLine(kitap);
                }
            }
                Console.WriteLine("Kitaplar Listelendi.");
        }
    }
}
