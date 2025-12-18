using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    using System;
    using System.Collections.Generic;

    public class Sinema
    {
        // Dictionary kullanarak film ve koltuk numaralarını tutuyoruz.
        private Dictionary<string, List<int>> filmler;

        public Sinema()
        {
            // Başlangıçta filmler boş olacak.
            filmler = new Dictionary<string, List<int>>();
        }

        // Yeni bir film eklemek için metot.
        public void FilmEkle(string filmAdi)
        {
            if (!filmler.ContainsKey(filmAdi))
            {
                // Film adı yoksa, boş koltuklar ekliyoruz (örneğin 1'den 10'a kadar koltuklar).
                filmler[filmAdi] = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                Console.WriteLine($"{filmAdi} filmi eklendi.");
            }
            else
            {
                Console.WriteLine($"{filmAdi} filmi zaten mevcut.");
            }
        }

        // Bir film için koltuk rezervasyonu yapmak için metot.
        public void KoltukRezerveEt(string filmAdi, int koltukNo)
        {
            if (filmler.ContainsKey(filmAdi))
            {
                if (filmler[filmAdi].Contains(koltukNo))
                {
                    // Koltuk mevcutsa, rezervasyon yapıyoruz.
                    filmler[filmAdi].Remove(koltukNo);
                    Console.WriteLine($"{filmAdi} filmi için {koltukNo} numaralı koltuk rezerve edildi.");
                }
                else
                {
                    // Koltuk zaten rezerve edilmişse.
                    Console.WriteLine($"{filmAdi} filmi için {koltukNo} numaralı koltuk zaten rezerve edilmiş.");
                }
            }
            else
            {
                Console.WriteLine($"{filmAdi} filmi mevcut değil.");
            }
        }

        // Bir filmdeki boş koltukları listelemek için metot.
        public void BosKoltuklariListele(string filmAdi)
        {
            if (filmler.ContainsKey(filmAdi))
            {
                var bosKoltuklar = filmler[filmAdi];
                if (bosKoltuklar.Count > 0)
                {
                    Console.WriteLine($"{filmAdi} filmi için boş koltuklar: {string.Join(", ", bosKoltuklar)}");
                }
                else
                {
                    Console.WriteLine($"{filmAdi} filmi için boş koltuk yok.");
                }
            }
            else
            {
                Console.WriteLine($"{filmAdi} filmi mevcut değil.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sinema sinema = new Sinema();

            // Filmler ekleniyor.
            sinema.FilmEkle("Film A");
            sinema.FilmEkle("Film B");

            // Koltuk rezervasyonu yapılıyor.
            sinema.KoltukRezerveEt("Film A", 3);
            sinema.KoltukRezerveEt("Film B", 5);

            // Boş koltuklar listeleniyor.
            sinema.BosKoltuklariListele("Film A");
            sinema.BosKoltuklariListele("Film B");
        }
    }
}
