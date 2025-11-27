using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu
{
    internal class Menu
    {
        public static void Ana()
        {
            Console.WriteLine("Kutuphane Otomasyonuna Hosgeldiniz!\n" +
                "Yapmak Istediginiz Islemi Seciniz\n\n" +
                "" +
                "Kitap Ekle(1)\n" +
                "Kitap Sil(2)\n" +
                "Kitap Yazdir(3)\n" +
                "Çık(4)\n");
            string? secenek = Console.ReadLine();

            switch (secenek)
            {
                case "1":
                    Console.WriteLine("Kitap Adi Giriniz:");
                    string? kitapAd = Console.ReadLine();
                    Console.WriteLine("Yazar Adi Giriniz:");
                    string? yazarAd = Console.ReadLine();
                    Console.WriteLine("Kitap Sayfa Sayisini Giriniz:");
                    int kitapSayfa = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Kitap Turu Giriniz:");
                    string? kitapTuru = Console.ReadLine();
                    Kitap? kitap = new Kitap(kitapAd, yazarAd, kitapSayfa, kitapTuru);
                    Kutuphane.KitapEkle(kitap);

                    Ana();
                    break;


                case "2":
                    Console.WriteLine("Silmek Istediginiz Kitabin Adini Giriniz:");
                    string? silinecekKitapAd = Console.ReadLine();
                    Kitap? silinecekKitap = Kutuphane.kitaplar.FirstOrDefault(k => k.KitapAd == silinecekKitapAd);
                    if (silinecekKitap != null)
                    {
                        Kutuphane.KitapSil(silinecekKitap);
                    }
                    else
                    {
                        Console.WriteLine("Bu isimde bir kitap bulunamadı.");
                    }
                    Ana();
                    break;


                case "3":
                    Kutuphane.KitaplariListele();
                    Ana();
                    break;


                case "4":
                    Console.WriteLine("Cikis Yapiliyor...");
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

    }
}
