using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Nisan2025_Kodları
{

    interface IAracKiralama
    {
        public void AracBilgileri(Arac arac);
        public void Odeme(Musteri musteri, Arac arac);
    }

    interface IMusteriIslemleri
    {
        public void HesapOlusturma(Musteri musteri);
        public void HesapSilme(Musteri musteri);
    }
    public class AracKiralamaIslemi : IAracKiralama, IMusteriIslemleri
    {
        public static List<Musteri> Musteriler = new List<Musteri>();

        public void AracBilgileri(Arac arac)
        {
            Console.WriteLine(arac);
        }

        public void HesapOlusturma(Musteri musteri)
        {
            Musteriler.Add(musteri);
            Console.WriteLine("Hesap başarıyla eklenmiştir");
        }

        public void HesapSilme(Musteri musteri)
        {
            Musteri arananMusteri = null;
            foreach (Musteri m in Musteriler)
            {
                if(musteri == m)
                {
                    arananMusteri = m;
                    Console.WriteLine("Girdiğiniz hesap sitemizde bulunmaktadır!");
                    Musteriler.Remove(arananMusteri);
                }
            }
            if(arananMusteri == null)
                Console.WriteLine("Silmeye çalıştığınız hesap bulunmamaktadır!");
        }

        public void Odeme(Musteri musteri, Arac arac)
        {
            if(arac.Fiyat < musteri.Butce)
            {
                Console.WriteLine("Bütçeniz bu aracı almak için yeterlidir." +
                    $"\nMevcut bütçeniz: {musteri.Butce}");
                arac.AracSayisi--;
            }
            else
                Console.WriteLine("Bütçeniz bu aracı almak için yeterli değildir!" +
                    $"\nMevcut büyçeniz: {musteri.Butce}");
        }

    }



    public class Arac
    {
        public Arac(string marka, string model, int yil, float fiyat)
        {
            Marka = marka;
            Model = model;
            Yil = yil;
            Fiyat = fiyat;
        }

        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public float Fiyat { get; set; }
        public int AracSayisi;

        public override string ToString()
        {
            return $"Arabanın\n" +
                $"Markası: {Marka} - " +
                $"Modeli: {Model} - " +
                $"Üretim Yılı: {Yil} - " +
                $"Fiyatı: {Fiyat}";
        }
    }

    public class Otomobil : Arac
    {
        public Otomobil(string marka, string model, int yil, float fiyat) : base(marka, model, yil, fiyat)
        {
            AracSayisi = 100;
        }
        
    }

    public class SUV : Arac
    {
        public SUV(string marka, string model, int yil, float fiyat) : base(marka, model, yil, fiyat)
        {
            AracSayisi = 100;
        }
    }

    public class Kamyonet : Arac
    {
        public Kamyonet(string marka, string model, int yil, float fiyat) : base(marka, model, yil, fiyat)
        {
            AracSayisi = 100;
        }
    }

    public class Musteri
    {
        public Musteri(string ad, string soyad, string ehliyetNo, float butce)
        {
            Ad = ad;
            Soyad = soyad;
            EhliyetNo = ehliyetNo;
            Butce = butce;
        }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string EhliyetNo { get; set; }
        public float Butce { get; set; }

    }
}
