using OrnekSorular1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    public class Hayvan
    {
        public string? Ad { get; set; }
        public string? Tur { get; set; }
        public List<Hayvan>? HayvanListesi { get; set; }

        // SesCıkar metodu virtual olarak tanımlandı
        public virtual void SesCıkar()
        {
            Console.WriteLine("Bir hayvan ses çıkardı!");
        }

        public void HayvanEkle(List<Hayvan> h)
        {
            // HayvanListesi'ni kontrol et ve eğer null ise yeni bir liste başlat
            if (HayvanListesi == null)
            {
                HayvanListesi = new List<Hayvan>();
            }

            // Parametre olarak gelen hayvanları mevcut listeye ekle
            HayvanListesi.AddRange(h);
        }
    }

    public class Kedi : Hayvan
    {
        // SesCıkar metodunu override ettik
        public override void SesCıkar()
        {
            Console.WriteLine("Miyav!");
        }
    }

    public class Köpek : Hayvan
    {
        // SesCıkar metodunu override ettik
        public override void SesCıkar()
        {
            Console.WriteLine("Hav!");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Örnek kullanım
        Hayvan hayvan = new Hayvan();
        hayvan.SesCıkar(); // Bir hayvan ses çıkardı!

        Kedi kedi = new Kedi();
        kedi.SesCıkar(); // Miyav!

        Köpek kopek = new Köpek();
        kopek.SesCıkar(); // Hav!

        // Hayvan ekleme işlemi
        List<Hayvan> yeniHayvanlar = new List<Hayvan> { new Kedi(), new Köpek() };
        hayvan.HayvanEkle(yeniHayvanlar);

        // Hayvan listesinin çıktısı
        Console.WriteLine($"Hayvan listesi {hayvan.HayvanListesi?.Count} eleman içeriyor.");
    }
}
