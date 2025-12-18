using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrnekSorular1;
namespace OrnekSorular1
{
    public class Firma
    {
        public List<Calisan> CalisanListe = new List<Calisan>();

    }

    public class Calisan 
    {
        public string? Ad;
        public string? Soyad;
        public int Yas;
        public decimal Maas;

        public static int ToplamCalisan = 0;
        public Calisan(string? ad, string? soyad, int yas, decimal maas)
        {
            Ad = ad;
            Soyad = soyad;
            if (yas > 0)
                Yas = yas;
            else
            {
                Console.WriteLine("Çalışan kişinin yaşı negatif olamaz!");
                Yas = 0;
            }
            if (maas > 0)
                Maas = maas;
            else
            {
                Console.WriteLine("Çalışan birinin maaşı en az 17.000,02 olabilir.");
                Maas = 17000.02M;
            }
            ToplamCalisan++;
        }
    }
}
