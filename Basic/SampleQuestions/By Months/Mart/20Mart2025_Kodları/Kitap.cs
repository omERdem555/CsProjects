using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Mart2025_Kodları
{
    public class Kitap
    {
        public string? KitapAdi { get; set; }
        public string? YazarAdi { get; set; }
        public string? ISBN { get; set; }
        public int Adet { get; set; }

        public void BilgileriYazdir()
        {
            Console.WriteLine($"Kitabın:\n" +
                $"Adi: {KitapAdi} - {YazarAdi}\n" +
                $"ISBN No: {ISBN}\n" +
                $"Adedi: {Adet}");
        }

        public override string ToString()
        {
            return $"{KitapAdi} {YazarAdi} {ISBN}";
        }
    }

    static class Kutuphane
    {
        static List<Kitap> kutuphane = new List<Kitap>();

        public static void KitapEkleme(Kitap kitap)
        {
            foreach (var k in kutuphane)
            {
                if (k.ISBN == kitap.ISBN)
                {
                    k.Adet += kitap.Adet;
                    return;
                }
            }
            kutuphane.Add(kitap);
        }

        public static void OduncAlma(string isbn)
        {
            Kitap bulunanKitap = null;

            foreach (var kitap in kutuphane)
            {
                if (kitap.ISBN == isbn)
                {
                    bulunanKitap = kitap;
                    break;
                }
            }

            if (bulunanKitap != null)
            {
                if (bulunanKitap.Adet > 0)
                {
                    bulunanKitap.Adet--;
                    Console.WriteLine($"{bulunanKitap.KitapAdi} kitabı ödünç alındı. Kalan adet: {bulunanKitap.Adet}");
                }
                else
                {
                    Console.WriteLine("Bu kitap şu an mevcut değil!");
                }
            }
            else
            {
                Console.WriteLine("Bu ISBN numarasına sahip kitap kütüphanede bulunmuyor.");
            }
        }

        public static void KitapAdetGuncelle(string isbn, int yeniAdet)
        {
            foreach (var kitap in kutuphane)
            {
                if (kitap.ISBN == isbn)
                {
                    kitap.Adet += yeniAdet;
                    Console.WriteLine($"Kitap adedi güncellendi. Yeni adet: {kitap.Adet}");
                    return;
                }
            }
            Console.WriteLine("Bu ISBN numarasına sahip kitap bulunamadı.");
        }

        public static void TumKitaplariListele()
        {
            Console.WriteLine("Kütüphane Kitap Listesi:");
            foreach (var kitap in kutuphane)
            {
                Console.WriteLine($"{kitap.KitapAdi} - {kitap.YazarAdi} - {kitap.ISBN} - Adet: {kitap.Adet}");
            }
        }
    }

}
