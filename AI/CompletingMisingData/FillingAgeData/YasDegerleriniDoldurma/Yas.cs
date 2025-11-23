using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YasDegerleriniDoldurma
{
    internal class Yas
    {
        double[] Yaslar = new double[100];
        Random random = new Random();
        public void GenerateRandomNumbers()
        {
            int a = 0;
            for (int i = 0; i < 100; i++)
            {
                Yaslar[i] = a;
                a += random.Next(-2, 10);
                if (a < 0)
                {
                    a = 0; // Ensure that the age does not go below 0
                }
                else if (a > 35)
                {
                    a = 0; // Ensure that the age does not exceed 35
                }
            }
            Console.WriteLine("Tüm Kişilerin Yaşı Belirlendi");
            Console.WriteLine(new string('-', 40));

            ShowMenu();
        }


        public void PrintNumbers()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write((i + 1) + ". Kişinin Yaşı " + ": ");
                Console.WriteLine(Yaslar[i]);
            }
            Console.WriteLine(new string('-', 40));

            ShowMenu();
        }


        public double AvarageAge()
        {
            double toplam = 0;
            for (int i = 0; i < 100; i++)
            {
                if (Yaslar[i] == 0)
                {
                    continue; // Skip if the age is 0
                }
                toplam += Yaslar[i];
            }

            double ortalama = toplam / 100;

            Console.WriteLine("Ortalama Yaş Değeri: " + ortalama);
            Console.WriteLine(new string('-', 40));
            return ortalama;
        }


        public void MaxAge()
        {
            double max = Yaslar[0];
            for (int i = 1; i < 100; i++)
            {
                if (Yaslar[i] > max)
                {
                    max = Yaslar[i];
                }
            }
            Console.WriteLine("En Yüksek Yaş Değeri: " + max);
            Console.WriteLine(new string('-', 40));

            ShowMenu();
        }

        public void MinAge()
        {
            double min = Yaslar[0];
            for (int i = 1; i < 100; i++)
            {
                if (Yaslar[i] < min && Yaslar[i] != 0)
                {
                    min = Yaslar[i];
                }
            }
            Console.WriteLine("En Düşük Yaş Değeri: " + min);
            Console.WriteLine(new string('-', 40));

            ShowMenu();
        }

        public void CountAge()
        {
            int count = 0;
            for (int i = 0; i < 100; i++)
            {
                if (Yaslar[i] != 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Toplam Kişi Sayısı: " + count);
            Console.WriteLine(new string('-', 40));
            ShowMenu();
        }


        public void CenteringAge()
        {
            double ortalama = AvarageAge();

            for (int i = 0; i < 100; i++)
            {
                if (Yaslar[i] == 0)
                {
                    Yaslar[i] = ortalama;
                }
            }
            Console.WriteLine($"Yaş Değeri 0 Olan Kişilerin Yaşı \"Ortalama Yaş: {ortalama}\" Olarak Belirlendi");
            Console.WriteLine(new string('-', 40));
            ShowMenu();
        }

        public void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. Yeni Yaş Değerleri Oluştur");
            Console.WriteLine("2. Yaşları Göster");
            Console.WriteLine("3. En Yüksek Yaş Değerini Göster");
            Console.WriteLine("4. En Düşük Yaş Değerini Göster");
            Console.WriteLine("5. Ortalama Yaş Değerini Göster");
            Console.WriteLine("6. Toplam Kişi Sayısını Göster");
            Console.WriteLine("7. Kişilerin Tüm Yaş Değerlerini Göster");
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
                    MaxAge();
                    break;
                case 4:
                    MinAge();
                    break;
                case 5:
                    AvarageAge();
                    ShowMenu();
                    break;
                case 6:
                    CountAge();
                    break;
                case 7:
                    CenteringAge();
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
