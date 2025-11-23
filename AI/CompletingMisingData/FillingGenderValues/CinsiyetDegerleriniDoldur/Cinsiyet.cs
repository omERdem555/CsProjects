using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinsiyetDegerleriniDoldur
{
    internal class Cinsiyet
    {
        Random random = new Random();
        public void GenerateRandomGenders(int[] ints)
        {
            int a = 2;
            for (int i = 0; i < 100; i++)
            {
                a = random.Next(0, 3); // Randomly assign true or false
                ints[i] = a;
                a = 0; // Reset a for the next iteration

            }
            Console.WriteLine("Tüm Kişilerin Cinsiyeti Belirlendi");
            Console.WriteLine(new string('-', 40));

            ShowMenu(ints);
        }


        public void PrintGenders(int[] ints)
        {
            int a = 1;
            foreach (int C in ints)
            {
                Console.Write($"{a}. Kişinin Cinsiyeti: ");
                if (C == 0)
                {
                    Console.WriteLine("Kadın ");
                }
                else if (C == 1)
                {
                    Console.WriteLine("Erkek ");
                }
                else
                {
                    Console.WriteLine("Belirtilmemiş ");
                }
                a++;
            }

            ShowMenu(ints);
        }


        public int AvarageGender(int[] ints)
        {
            int countKadın = 0;
            int countErkek = 0;
            double toplam = 0;
            for (int i = 0; i < 100; i++)
            {
                if (ints[i] == 0)
                {
                    countKadın++;
                    toplam++;
                }
                else if (ints[i] == 1)
                {
                    countErkek++;
                    toplam++;

                }
                else
                    continue;
            }

            if(countKadın > countErkek)
            {
                Console.WriteLine("Kadın Sayısı Daha Fazladır");
                return 0; // Kadın sayısı daha fazla
            }
            else if (countErkek > countKadın)
            {
                Console.WriteLine("Erkek Sayısı Daha Fazla");
                return 1; // Erkek sayısı daha fazla
            }
            else
            {
                Console.WriteLine("Kadın Erkek Sayısı Eşittir");
                return 2; // Kadın ve erkek sayısı eşit
            }
        }



        public void CountGender(int[] ints)
        {
            int count = 0;
            for (int i = 0; i < 100; i++)
            {
                if (ints[i] >= 0 && ints[i] <= 1)
                {
                    count++;
                }
            }
            Console.WriteLine("Toplam Kişi Sayısı: " + count);
            Console.WriteLine(new string('-', 40));
            ShowMenu(ints);
        }


        public void CenteringGender(int[] ints)
        {
            int ortalama = AvarageGender(ints);

            for (int i = 0; i < 100; i++)
            {
                if (ints[i] == 2)
                {
                    ints[i] = ortalama;
                }
            }
            Console.WriteLine($"Cinsiyet Değeri Belirtilmemiş Olan Kişilerin Cinsiyeti \"En Fazla Cinsiyet: {(ortalama == 1 ? "Erkek":"Kadın" )}\" Olarak Belirlendi");
            Console.WriteLine(new string('-', 40));
            ShowMenu(ints);
        }

        public void ShowMenu(int[] ints)
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. Yeni Cinsiyet Değerleri Oluştur");
            Console.WriteLine("2. Cinsiyetleri Göster");
            Console.WriteLine("3. Ortalama Cinsiyet Değerini Göster");
            Console.WriteLine("4. Toplam Kişi Sayısını Göster");
            Console.WriteLine("5. Kişilerin Tüm Cinsiyet Değerlerini Göster");
            Console.WriteLine("6. Çıkış");
            Console.WriteLine(new string('-', 40));
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    GenerateRandomGenders(ints);
                    break;
                case 2:
                    PrintGenders(ints);
                    break;
                case 3:
                    AvarageGender(ints);
                    ShowMenu(ints);
                    break;
                case 4:
                    CountGender(ints);
                    break;
                case 5:
                    CenteringGender(ints);
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                    ShowMenu(ints);
                    break;
            }
        }

    }

}