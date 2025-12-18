using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular
{
    internal class Ogrenci2
    {
        public string? Ad;
        public string? Soyad;
        private byte? Yas;

        public Ogrenci2(string? ad, string? soyad, byte yas)
        {
            Ad = ad;
            Soyad = soyad;
            if (yas > 0)
                Yas = yas;
            else
            {
                Console.WriteLine("\aYas değeri 0'dan küçük olamaz!");
                Yas = null;
            }
        }

        public void BilgileriYazdır()
        {
            Console.WriteLine($"{Ad} {Soyad} {(Yas.HasValue ? Yas.ToString() : "Bilinmiyor")}");
        }
    }
}
