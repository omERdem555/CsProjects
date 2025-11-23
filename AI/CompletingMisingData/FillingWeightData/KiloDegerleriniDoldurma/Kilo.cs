using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiloDegerleriniDoldurma
{
    internal class Kilo
    {
        double[] Kilolar = new double[100];
        Random random = new Random();
        public void GenerateRandomNumbers()
        {
            int a = 0;
            for (int i = 0; i < 100; i++)
            {
                Kilolar[i] = a;
                a += random.Next(-40, 60);
                if (a < 0)
                {
                    a = 0; // Ensure that the age does not go below 0
                }
                else if (a > 150)
                {
                    a = 0; // Ensure that the age does not exceed 35
                }
            }
            Console.WriteLine("Tüm Kişilerin Kiloları Belirlendi");
            Console.WriteLine(new string('-', 40));

            ShowMenu();
        }


        public void PrintNumbers()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write((i + 1) + ". Kişinin Kilosu " + ": ");
                Console.WriteLine(Kilolar[i]);
            }
            Console.WriteLine(new string('-', 40));

            ShowMenu();
        }


        public double AvarageWeight()
        {
            double toplam = 0;
            for (int i = 0; i < 100; i++)
            {
                if (Kilolar[i] == 0)
                {
                    continue; // Skip if the weight is 0
                }
                toplam += Kilolar[i];
            }

            double ortalama = toplam / 100;

            Console.WriteLine("Ortalama Kilo Değeri: " + ortalama);
            Console.WriteLine(new string('-', 40));
            return ortalama;
        }


        public void MaxWeight()
        {
            double max = Kilolar[0];
            for (int i = 1; i < 100; i++)
            {
                if (Kilolar[i] > max)
                {
                    max = Kilolar[i];
                }
            }
            Console.WriteLine("En Yüksek Kilo Değeri: " + max);
            Console.WriteLine(new string('-', 40));

            ShowMenu();
        }

        public void MinAge()
        {
            double min = Kilolar[0];
            for (int i = 1; i < 100; i++)
            {
                if (Kilolar[i] < min && Kilolar[i] != 0)
                {
                    min = Kilolar[i];
                }
            }
            Console.WriteLine("En Düşük Kilo Değeri: " + min);
            Console.WriteLine(new string('-', 40));

            ShowMenu();
        }

        public void CountWeight()
        {
            int count = 0;
            for (int i = 0; i < 100; i++)
            {
                if (Kilolar[i] != 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Toplam Kişi Sayısı: " + count);
            Console.WriteLine(new string('-', 40));
            ShowMenu();
        }


        public void CenteringWeight()
        {
            double ortalama = AvarageWeight();

            for (int i = 0; i < 100; i++)
            {
                if (Kilolar[i] == 0)
                {
                    Kilolar[i] = ortalama;
                }
            }
            Console.WriteLine($"Kilo Değeri 0 Olan Kişilerin Kilosu \"Ortalama Kilo: {ortalama}\" Olarak Belirlendi");
            Console.WriteLine(new string('-', 40));
            ShowMenu();
        }

        public void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. Yeni Kilo Değerleri Oluştur");
            Console.WriteLine("2. Kiloları Göster");
            Console.WriteLine("3. En Yüksek Kilo Değerini Göster");
            Console.WriteLine("4. En Düşük Kilo Değerini Göster");
            Console.WriteLine("5. Ortalama Kilo Değerini Göster");
            Console.WriteLine("6. Toplam Kişi Sayısını Göster");
            Console.WriteLine("7. Kişilerin Tüm Kilo Değerlerini Göster");
            Console.WriteLine("8. Çıkış");
            Console.WriteLine(new string('-', 40));
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    GenerateRandomNumbers();
                    break;
                case 2:
                    PrintNumbers();
                    break;
                case 3:
                    MaxWeight();
                    break;
                case 4:
                    MinAge();
                    break;
                case 5:
                    AvarageWeight();
                    ShowMenu();
                    break;
                case 6:
                    CountWeight();
                    break;
                case 7:
                    CenteringWeight();
                    break;
                case 8:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                    ShowMenu();
                    break;
            }
        }

    }

}
