using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Aralık2024_Kodları
{
    internal class Hasta
    {
        public Hasta(string? ad, string? soyad, int tCNo, string? hastalık)
        {
            Ad = !string.IsNullOrEmpty(ad) ? ad : "Hasta Adı";
            Soyad = !string.IsNullOrEmpty(soyad) ? soyad : "Hasta Soyadı";
            if (GecerliTC(tCNo))
                TCNo = tCNo;
            else
                TCNo = 0;
            Hastalık = !string.IsNullOrEmpty(hastalık) ? hastalık : "Hastadır.";
        }
        private bool GecerliTC(long tCNo)
        {
            // Basit TC Kimlik Doğrulama
            string tc = tCNo.ToString();
            return tc.Length == 11 && tc.All(char.IsDigit) && tc[0] != '0';
        }
        internal string? Ad { get; set; }
        internal string? Soyad { get; set; }
        internal int TCNo { get; set; }
        internal string? Hastalık { get; set; }

        public override string ToString()
        {
            return $"{Ad} {Soyad} hastalığı {Hastalık}";
        }
    }
    internal class Doktor
    {
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? Uzmanlık { get; set; }
        public List<Hasta> Hastalar = new List<Hasta>();
        public static List<Doktor> Doktorlar = new List<Doktor>();

        public Doktor(string? ad, string? soyad, string? uzmanlık, List<Hasta> hastalar)
        {
            Ad = !string.IsNullOrEmpty(ad) ? ad : "Doktor Ad";
            Soyad = !string.IsNullOrEmpty(soyad) ? soyad : "Doktor Soyad";
            Uzmanlık = !string.IsNullOrEmpty(uzmanlık) ? uzmanlık : "Uzmanlık";
            Hastalar = (hastalar != null) ? hastalar : new List<Hasta>();
            Doktorlar.Add(this);
        }

        public void HastaEkle(Hasta hasta)
        {
            if(hasta == null || hasta.TCNo == 0)
                Console.WriteLine("Geçerli bir hasta tanımlayınız!");

            Hastalar.Add(hasta);
            Console.WriteLine("Hasta eklenmiştir!");
        }
        public void UzmanlıkAra(string uzmanlık)
        {
            if(Doktorlar.Count == 0)
                Console.WriteLine("Hiç doktor bulunmamaktadır!");

            bool doktorBulundu = false;
            foreach (Doktor doktor in Doktorlar)
            {
                if (doktor.Uzmanlık == uzmanlık)
                {
                    Console.WriteLine(doktor);
                    doktorBulundu = true;
                }
            }

            if (!doktorBulundu)
                Console.WriteLine($"Uzmanlık alanı {uzmanlık} olan doktor bulunamadı.");
        }
        public void HastalarıListele()
        {
            if(Hastalar.Count == 0)
            {
                Console.WriteLine($"Dr. {Ad} hiç hastası bulunmamaktadır.");
                return;
            }

            foreach (Hasta hasta in Hastalar)
            {
                Console.WriteLine(hasta);
            }
        }
        public override string ToString()
        {
            return $"{Ad} {Soyad} doktorun uzmanlık alanı: {Uzmanlık}\n" +
                $"Hastaları: {string.Join("", Hastalar)}";
        }
    }
}
