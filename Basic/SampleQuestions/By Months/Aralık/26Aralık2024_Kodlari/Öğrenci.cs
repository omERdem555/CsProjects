using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26Aralık2024_Kodlari
{
    public class Öğrenci
    {
        public Öğrenci(string? ad, string? soyad, byte okulNo)
        {
            Ad = !string.IsNullOrEmpty(ad) ? ad : "Ad";
            Soyad = !string.IsNullOrEmpty(soyad) ? soyad : "Soyad";

            if (okulNo >= 0)
                OkulNo = okulNo;
            else
            {
                Console.WriteLine("Öğrencinin okul numarası negatif olamaz! Varsayılan değer atanıyor");
                OkulNo = OkulNo1; //Bu kısımda kontrol hatası var!
                OkulNo1++;
            }
        }

        internal string? Ad { get; set; }
        internal string? Soyad { get; set; }
        internal byte OkulNo { get; set; }

        internal static byte OkulNo1 = 1;

        public override string ToString()
        {
            return $"Öğrencinin:" +
                $"Adı: {Ad}\n" +
                $"Soyadı: {Soyad}\n" +
                $"Okul Numarası: {OkulNo}";
        }
    }

    internal class Okul
    {
        List<Öğrenci> OListesi = new List<Öğrenci>();

        public void OgrenciEkle(Öğrenci O)
        {
            if (O != null)
                OListesi.Add(O);
            else
                Console.WriteLine("Boş bir şekilde öğrenci eklenmesi mümkün değildir!");
        }
        public void OgrenciSil(byte no)
        {
            bool bulundu = false;
            if (OListesi.Count != 0)
            {
                foreach (Öğrenci o in OListesi)
                {
                    if(o.OkulNo == no)
                        OListesi.Remove(o);
                    bulundu = true;
                }
                if(!bulundu)
                    Console.WriteLine("Aranan öğrenci bulunamadı");
            }
        }

        public void TumOgrencileriListele()
        {
            if (OListesi.Count != 0)
            {
                foreach (Öğrenci o in OListesi)
                {
                    Console.WriteLine(o);
                }
                Console.WriteLine("\nTüm öğrenciler başarıyla Listelendi!");
            }
            else
                Console.WriteLine("Okulda hiç öğrenci yoktur!");
        }
    }
}
