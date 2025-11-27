using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Ocak2025_Kodları
{
    internal class Ogrenci
    {
        public Ogrenci(string ogrenciNo)
        {
            if (float.TryParse(ogrenciNo, out float o))
                if (new string(ogrenciNo.Substring(0, 2)) == "21" || new string(ogrenciNo.Substring(0, 2)) == "22" || new string(ogrenciNo.Substring(0, 2)) == "23")
                    if (ogrenciNo.ToString().Length == 11)
                    {
                        OgrenciNo = ogrenciNo;
                        Console.WriteLine($"Öğrenci No: {OgrenciNo}");
                    }
                    else
                        Console.WriteLine($"Ogrenci numarası 11 haneli olmalıdır: {ogrenciNo}\a");
                else
                    Console.WriteLine($"Ogrenci numarasının ilk iki hanesi 21 ile 23 arasında değil: {ogrenciNo}\a");
            else
                Console.WriteLine($"Numara rakamlardan oluşmuyor: {ogrenciNo}\a");
        }
        public string? OgrenciNo { get; set; }
    }

    internal class CiftTek
    {
        public CiftTek(int sayi)
        {
            Sayi = sayi;
            if (Sayi % 2 == 0)
                Cift(Sayi);
            else
                Tek(Sayi);
        }
        public int Sayi { get; set; }

        public void Cift(int sayi)
        {
            Console.WriteLine("Sayınız çifttir.");
            for (int i = 0; i < sayi; i++)
            {
                Console.Write(sayi + " ");
            }
        }
        public void Tek(int sayi)
        {
            Console.WriteLine("Sayınız Tektir.");
            for (int i = 0; i < sayi; i++)
            {
                Console.Write(sayi + " ");
            }
        }
    }
}
