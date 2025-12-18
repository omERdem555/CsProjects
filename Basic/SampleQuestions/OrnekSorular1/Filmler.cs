using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    internal class Filmler
    {
        public Filmler(string filmAdi, string yonetmen, int yil, string filmTuru)
        {
            FilmAdi = filmAdi;
            Yonetmen = yonetmen;
            if (yil > 0)
                Yil = yil;
            else
                Console.WriteLine("Filmin çekim yılı bu kadar eski olamaz");
            FilmTuru = filmTuru;
        }

        private string FilmAdi { get; set; }
        private string Yonetmen { get; set; }
        private int Yil { get; set; }
        private string FilmTuru { get; set; }
    }

    class FilmKütüphanesi
    {
        List<FilmListesi> Filmler = new List<FilmListesi>();

        public void FilmEkle(string filmAdi, string yonetmen, int yil, string filmTuru)
        {
            Filmler.Add(new FilmListesi(filmAdi, yonetmen, yil, filmTuru));
        }
        public void FilmleriListele()
        {
            if (Filmler.Count > 0)
            {
                foreach (FilmListesi f in Filmler)
                {
                    Console.WriteLine($" {f.FilmTuru}, {f.FilmAdi} filmi {f.Yonetmen} tarafından {f.Yil} yılında çekilmiştir.");
                }
            }
            else
                Console.WriteLine("Listede hiç film yoktur!");
        }
        public void FilmleriTureGoreListele(string tur)
        {
            if (Filmler.Count > 0)
            {
                if (this.FilmTuru == tur)
                {
                    var Array = Filmler.ToArray();
                    foreach (FilmListesi f in Filmler)
                    {
                        Console.WriteLine($"{f}");
                    }
                }
            }
        }
        public void EskiFilmleriBul(int tarih)
        {
            if (Filmler.Count > 0)
            {
                if (Yil > tarih)
                {
                    var Filmler = this.Filmler.ToArray();
                    foreach (FilmListesi f in Filmler)
                    {
                        Console.WriteLine($"{f}");
                    }
                }
            }
        }
        public void YonetmeneGoreAra(string yonetmen)
        {
            if (Filmler.Count > 0)
            {
                if (this.Yonetmen == yonetmen)
                {
                    var Filmler = this.Filmler.ToArray();
                    foreach (FilmListesi f in Filmler)
                    {
                        Console.WriteLine($"{f}");
                    }
                }
            }
        }
    }
}
}
