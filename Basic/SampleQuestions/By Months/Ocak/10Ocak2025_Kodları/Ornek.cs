using System.Reflection.PortableExecutable;
using System.Runtime;

namespace _10Ocak2025_Kodları
{
    enum Bolgeler
    {
        Kuzey = 1,
        Güney,
        Doğu,
        Batı
    }
    internal class Cihaz
    {
        public Cihaz(string? adı)
        {
            Adı = !string.IsNullOrEmpty(adı) ? adı : "Boş";
            Durum = false;
            Adet++;
        }
        public int Bölge;
        public string? Adı { get; set; }
        public bool Durum { get; set; }
        public static int Adet = 0;
        public void Ac()
        {
            if (!Durum)
                Durum = true;
        }
        public void Kapat()
        {
            if (Durum) Durum = false;
        }
        public void DurumGoster()
        {
            Console.WriteLine($"{Adı} cihazın şuan {Durum}");
        }
        ~Cihaz()
        {
            Console.WriteLine("Cihaz parçalandı\a!");
        }
        public override string ToString()
        {
            return $"{Adı} cihaz {Durum} haldedir.";
        }
    }
    internal class Lamba : Cihaz
    {
        public Lamba(string? adı, string? renk) : base(adı)
        {
            Adı = !string.IsNullOrEmpty(adı) ? adı : "boş";
            Renk = !string.IsNullOrEmpty(adı) ? renk : "boş" ;
            Durum = false;
            Adet++;
        }

        public string? Renk { get; set; }
        ~Lamba()
        {
            Console.WriteLine("Lamba parçalandı\a!");
        }
        public override string ToString()
        {
            return $"{Adı} {Renk} lamba {Durum} haldedir. ";
        }

    }
    internal class Kamera : Cihaz
    {
        public Kamera(string? adı, int cozunurluk) : base(adı)
        {
            Adı = !string.IsNullOrEmpty(adı) ? adı : "boş";
            Cozunurluk = (cozunurluk > 0) ? cozunurluk : 0;
            Adet++;
        }
        public int Cozunurluk { get; set; }
        public bool KayitDurumu = false;
        public void KayitBaslat()
        {
            if (!KayitDurumu)
                KayitDurumu = true;
        }
        public void KayitDurdur()
        {
            if (KayitDurumu)
                KayitDurumu = false;
        }
        ~Kamera()
        {
            Console.WriteLine("Kamera parçalandı\a!");
        }

        public override string ToString()
        {
            return $"{Adı} {Cozunurluk} kamera {KayitDurumu} haldedir";
        }

    }
    internal class AkilliSehir
    {
        List<Cihaz> Cihazlar = new List<Cihaz>();
        Random Random = new Random();
        public void CihazEkle(Cihaz cihaz)
        {
            if(Cihazlar != null)
                Cihazlar.Add(cihaz);
            else
                Console.WriteLine("Boş bir cihaz listeye eklenemez\a!");
        }
        public void CihazListele()
        {
            if(Cihazlar.Count != 0)
            {
                foreach(Cihaz cihaz in Cihazlar)
                    Console.WriteLine(cihaz);
            }
        }
        public void BolgeAta(Cihaz cihaz)
        {
            cihaz.Bölge = Random.Next(1, 4);
            Console.WriteLine($"{cihaz.Bölge}");
        }
    }
}
