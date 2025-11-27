using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Aralık2025_Kodları
{
    internal class Hastane
    {
        public struct HastaneBilgileri
        {
            public string HastaneAd;
            public string Adres;
            public int Telefon;

            public HastaneBilgileri(string hastaneAd, string adres, int telefon)
            {
                HastaneAd = hastaneAd;
                Adres = adres;
                Telefon = telefon;
            }
        }

        static public List<Doktor> Doktorlar = new List<Doktor>();
        public void DoktorEkle(Doktor doktor)
        {
            if (doktor != null)
                Doktorlar.Add(doktor);
        }

        ~Hastane()
        {
            Console.WriteLine("Hastane siliniyor.");
        }

        public void BilgileriYazdır(HastaneBilgileri hastaneBilgileri)
        {
            Console.WriteLine("Tüm Doktorlar:");
            Console.WriteLine($"{string.Join(", ", Doktorlar)}");

            Console.WriteLine();
            Console.WriteLine($"Hastanenin:\n" +
                $"{hastaneBilgileri.HastaneAd}\n" +
                $"{hastaneBilgileri.Telefon}\n" +
                $"{hastaneBilgileri.Adres}");
        }
    }
    class Kişi
    {
        public Kişi(string? adı, string? soyadı, int yas)
        {
            Adı = !string.IsNullOrEmpty(adı) ? adı : "Adı";
            Soyadı = !string.IsNullOrEmpty(soyadı) ? soyadı : "Soyadı";
            Yas = (yas > 0) ? yas : 0;
        }
        public string? Adı { get; set; }
        public string? Soyadı { get; set; }
        public int Yas { get; set; }

        public virtual void BilgileriYazdır()
        {
            Console.WriteLine($"Kişinin:\n" +
                $"Adı {Adı}\n" +
                $"Soyadı {Soyadı}\n" +
                $"Yası {Yas}");
        }
        ~Kişi()
        {
            Console.WriteLine("Kişi siliniyor.");
        }
    }
    class Doktor : Kişi
    {
        private int Maas;
        public string? UzmanlıkAlanı { get; set; }
        public int maas
        {
            get { return Maas; }
            set
            {
                if (Maas > 0)
                    Maas = value;
            }
        }
        public Doktor(string? adı, string? soyadı, int yas) : base(adı, soyadı, yas)
        {
            Adı = adı; Soyadı = soyadı; Yas = yas;
        }

        List<Hasta> Hastalar = new List<Hasta>();
        public void HastaEkle(Hasta hasta)
        {
            if (hasta != null)
                Hastalar.Add(hasta);
        }

        ~Doktor()
        {
            Console.WriteLine("Doktor siliniyor.");
        }

        public override void BilgileriYazdır()
        {
            Console.WriteLine($"Doktorun:\n" +
                $"Adı: {Adı}\n" +
                $"Soyadı: {Soyadı}\n" +
                $"Yaşı: {Yas}\n" +
                $"Maaşı: {maas}\n");
        }
    }
    class Hasta : Kişi
    {
        public Hasta(string? adı, string? soyadı, int yas) : base(adı, soyadı, yas)
        {
            Adı = adı; Soyadı = soyadı; Yas = yas;
        }

        public override void BilgileriYazdır()
        {
            Console.WriteLine($"Hastanın:\n" +
    $"Adı {Adı}\n" +
    $"Soyadı {Soyadı}" +
    $"Yası {Yas}");
        }
    }
}

