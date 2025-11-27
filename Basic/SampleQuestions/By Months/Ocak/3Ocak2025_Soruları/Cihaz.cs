using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Ocak2025_Kodları
{
    internal class Cihaz
    {
        public Cihaz(string? ad, bool durum)
        {
            Ad = !string.IsNullOrEmpty(ad) ? ad : "Ad";
            Durum = durum;
        }

        public string? Ad { get; set; }
        public bool Durum { get; set; }
        public void Ac()
        {
            Durum = true;
        }
        public void Kapat()
        {
            Durum = false;
        }
        public void DurumGoster()
        {
            Console.WriteLine($"{new string((Durum == true) ? "Cihaz açık" : "Cihaz kapalı")}");
        }

        public override string ToString()
        {
            return $"Cihazın Adı: {Ad}\n" +
                $"Cihazın Durumu: {Durum}";
        }
    }
    internal class Isitici : Cihaz
    {
        public Isitici(string? ad, bool durum, int sicaklik) : base(ad, durum)
        {
            Ad = !string.IsNullOrEmpty(ad) ? ad : "Ad";
            Durum = durum;
            Sicaklik = (sicaklik >= 0 && sicaklik <= 100) ? sicaklik : 0;
        }

        public int Sicaklik { get; set; }

        public void SicaklikArtir(int a)
        {
            Sicaklik = ((a >= 0) && (Sicaklik + a <= 100)) ? Sicaklik + a : Sicaklik;
        }

        public void SicaklikAzalt(int a)
        {
            Sicaklik = ((a <= 0) && (Sicaklik - a >= 0)) ? Sicaklik - a : Sicaklik;
        }

        public override string ToString()
        {
            return $"Cihazın Adı: {Ad}\n" +
                $"Cihazın Durumu: {Durum}\n" +
                $"Cihazın Sıcaklığı: {Sicaklik}";
        }
    }
    internal class Lamba : Cihaz
    {
        public Lamba(string? ad, bool durum, string renk) : base(ad, durum)
        {
            Ad = !string.IsNullOrEmpty(ad) ? ad : "Ad";
            Durum = durum;
            Renk = !string.IsNullOrEmpty(renk) ? renk : "Renk";
        }

        public string? Renk { get; set; }

        public void RenkDegistir(string renk)
        {
            Renk = !string.IsNullOrEmpty(renk) ? renk : Renk;
        }

        public override string ToString()
        {
            return $"Cihazın Adı: {Ad}\n" +
    $"Cihazın Durumu: {Durum}\n" +
    $"Cihazın Rengi: {Renk}";
        }
    }
    internal class AkilliEv
    {
        public List<Cihaz> Cihazlar = new List<Cihaz>();
        public void CihazEkle(Cihaz cihaz)
        {
            Cihazlar.Add(cihaz);
        }

        public void CihazlariListele()
        {
            foreach (Cihaz cihaz in Cihazlar)
            {
                Console.WriteLine($"{cihaz}");
            }
        }
    }
}
