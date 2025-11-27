using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Aralık2024_Kodları
{
    internal class Film
    {
        public Film(string? filmAdi, string? yonetmen, int yil, List<string>? kategoriler)
        {
            FilmAdi = !string.IsNullOrEmpty(filmAdi) ? filmAdi : "Varsayılan Film Adı";
            Yonetmen = !string.IsNullOrEmpty(yonetmen) ? yonetmen : "Varsayılan Yönetmen";
            Yil = (yil >= 0) ? yil : 0;
            Kategoriler = (kategoriler != null) ? kategoriler : new List<string>() { "Varsayılan Kategori" };
        }

        internal string? FilmAdi { get; set; }
        internal string? Yonetmen { get; set; }
        internal int Yil { get; set; }
        internal List<string>? Kategoriler { get; set; }

        public override string ToString()
        {
            return $"{FilmAdi} - {Yonetmen} - {Yil} - Kategoriler: {string.Join(", ", Kategoriler)}";
        }
    }
    internal class FilmFestivali
    {
        List<Film> Filmler = new List<Film>();

        public void FilmEkle(Film film)
        {
            bool VarMı = false;
            if (film == null) Console.WriteLine("Boş bir film listeye eklenemez!");
            else
            {
                foreach (Film film1 in Filmler)
                {
                    if(film1.FilmAdi.Contains(film.FilmAdi)) 
                        VarMı = true;
                }
                if(!VarMı)
                    Filmler.Add(film);
            }

        }

        public void KategoriyeGoreListele(string kategori)
        {
            bool VarMı = false;
            if (Filmler.Count == 0 )
            {
                Console.WriteLine("Listede hiç film bulunmamaktadır.");
                return;
            }

            foreach (Film film in Filmler)
            {
                if(film.Kategoriler.Contains(kategori))
                {
                    Console.WriteLine(film);
                    VarMı = true;
                }
            }

            if(!VarMı)
                Console.WriteLine("Aradığınız kategoride film listede bulunmamaktadır.");
        }

        public void YonetmeneGoreListele(string yonetmen)
        {
            bool VarMı = false;
            if (Filmler.Count == 0)
            {
                Console.WriteLine("Listede hiç film bulunmamaktadır.");
                return;
            }

            foreach (Film film in Filmler)
            {
                if (film.Yonetmen == yonetmen)
                {
                    Console.WriteLine(film);
                    VarMı = true;
                }
            }

            if (!VarMı)
                Console.WriteLine("Aradığınız yönetmenin filmi listede bulunmamaktadır.");
        }
    }
}
