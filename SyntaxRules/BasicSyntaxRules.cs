using System.Collections;
using System.Diagnostics.CodeAnalysis;
internal class Program
{
    enum Islemler
    {
        Toplama,
        Cikarma,
        Carpma,
        Bolme

    }
    private static void Main(string[] args)
    {
        //DegiskenTanimlama();

        //DizeDegismezleri();

        //Operatorler();

        //If_ElseYapisi();

        //SwitchCase();

        //Donguler();

        //Diziler();

        //Matrisler();

        //ArrayList();

        //List();

        //Metodlar();

        //Referans();

        //Listeler();


    }

    #region Metodlar
    private static void Listeler()
    {
        var Sehirler = new List<string>()
        {
            "Ankara",
            "İstanbul",
            "Van",
            "Samsun",
            "Ordu"
        };

        foreach (string item in Sehirler)
        {
            Console.WriteLine(item);
        }


        Console.WriteLine(new string('_', 50));


        //Lambda expression =>
        Sehirler.ForEach(x => Console.WriteLine(x));//Foreach döngüsünün pratik hali

        Console.WriteLine(new string('_', 50));


        var İller = Sehirler;
        İller.ForEach(x => Console.WriteLine(x));
        Console.WriteLine();


        Sehirler.Add("Sinop");
        Sehirler.ForEach(s => Console.WriteLine(s));
        Console.WriteLine();
        İller.ForEach(i => Console.WriteLine(i));
        Console.WriteLine();


        İller.Remove("Ankara");
        İller.ForEach(i => Console.WriteLine(i));
        Console.WriteLine(new string('_', 50));
        Sehirler.ForEach(s => Console.WriteLine(s));


        Console.ReadKey();
    }
    private static void Referans()
    {
        int x = 10, y = 20;
        Degistir(x, y);
        Console.WriteLine("{0}, {1}", x, y);
        RefDegistir(ref x, ref y);
        Console.WriteLine("{0}, {1}", x, y);


        Console.ReadKey();
    }

    private static void Degistir(int x, int y)
    {
        int temp;
        temp = x;
        x = y;
        y = temp;
        Console.WriteLine("{0}, {1}", x, y);
    }

    private static void RefDegistir(ref int x,ref int y)
    {
        int temp;
        temp = x;
        x = y;
        y = temp;
        Console.WriteLine("{0}, {1}", x, y);
    }
    private static void Metodlar()
    {
        //Basit Fonksiyonlar
        Metod();
        Karsilastir(3, 5);
        KareAl(9);


        //Dinamik Parametreli Fonksiyon
        double toplam = SeriToplami(5.12, 15.0, 25.5);
        Console.WriteLine("{0,-3:0.##}", toplam);



        double odenecekMiktar = SatisYap(100.0);
        Console.WriteLine(odenecekMiktar);

        double odenecekMiktar2 = SatisYap(100, .1);
        Console.WriteLine(odenecekMiktar2);


        Console.ReadKey();
    }

    /// <summary>
    /// Satış yapan fonksiyon
    /// </summary>
    /// <param name="miktar">Alış-veriş tutarı</param>
    /// <returns>KDV eklenmiş toplam ödenecek miktar</returns>  fonksiyonun üstünde 
    /// 3 kere / basıp şablon oluşturulabilir
    static double SatisYap(double miktar)
    {
        return miktar * 1.18;
    }
    static double SatisYap(double miktar, double indirim)
    {
        return (miktar * (1.10 - indirim)) * 1.18;
    }
    private static double SeriToplami(params double[] seri)
    {
        double toplam = 0;
        foreach (var item in seri)
            toplam += item;

        return toplam;
        
    }
    public static double KareAl(double x)
    {
        return x*x;
    }
    public static int Karsilastir(int A,  int B)
    {
        return A > B ? A : B;
    }
    private static void Metod()
    {
        Console.WriteLine("\aMetod Çalıştı");
    }
    private static void List()
    {
        //Tanımlama
        List<int> sayilar = new List<int>();
        int[] Seri = new int[] { 70, 80, 90 };


        //Ekleme
        sayilar.Add(10);
        sayilar.Add(15);
        sayilar.Add(20);

        foreach (int i in Seri)
        {
            sayilar.Add(i);
        } // sayilar.AddRange(Seri);



        //Araya Ekleme
        sayilar.Insert(3, 100);
        sayilar.InsertRange(4, new int[] { 40, 50, 60 });

        //Dolaşma
        foreach (int s in sayilar)
        {
            Console.Write($"{s,-3}");
        }
    }
    private static void ArrayList()
    {
        //Tanımlama
        ArrayList arrayList = new ArrayList()
        {20, "Van", false, 'a'};

        arrayList.Add(10);
        arrayList.Add("BTK Akademi");
        arrayList.Add(true);
        arrayList.Add('e');

        int[] sayilar = new int[] { 23, 44, 55 };
        arrayList.AddRange(sayilar);



        //Dolaşma
        foreach (var i in arrayList)
        {
            Console.Write($"{i} ");
        }



        //Elemana Erişme
        Console.WriteLine(arrayList[4]);



        //Elemana Erişme - Atama
        var x = arrayList[0]; //objeden int tipine dönüşüm
        Console.WriteLine(x);


        //Eleman Silme 
        arrayList.Remove(10);
        arrayList.RemoveAt(3);
        arrayList.RemoveRange(5, 2);


        Console.ReadKey();
    }
    private static void Matrisler()
    {
        /*
        Console.WriteLine("Dizi boyutunu giriniz: ");
        int boyut = Convert.ToInt32(Console.ReadLine());
        int[] sayilar = new int[boyut];


        var r = new Random();
        for (int i = 0; i < sayilar.Length; i++)
            sayilar[i] = r.Next(1, 10);
        
        foreach (var i in sayilar)
        {
            Console.WriteLine($"{i, 5} {i*i, 5}");
        }


        */

        double[,] matris = new double[,]
        { { 1, 2, 3 },
        { 2, 3, 4 },
        { 3, 4, 5 } };


        double toplam = 0;
        for (int i = 0; i < matris.GetLength(0); i++)
        {
            for (int j = 0; j < matris.GetLength(1); j++)
            {
                if (i == j)
                    matris[i, j] = -1;

                if (matris[i, j] % 2 == 0)
                    matris[i, j] = 0;

                toplam += matris[i, j];

                Console.Write($"{matris[i, j],4}");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"Toplam = {toplam}");
    }
    private static void Diziler()
    {
        int[] numaralar = new int[3] { 3, 5, 7 };

        for (int i = 0; i < numaralar.Length; i++)
        {
            numaralar[i] = i;
            Console.WriteLine($"Numaralar[{i}] = " +
                $"{numaralar[i]}");
        }
    }
    private static void Donguler()
    {
        /*
        int i = 0;

        while (i < 10)
        {
            Console.WriteLine(i);
            i++;
        }

        int sayac = 1;
        while (sayac <= 10)
        {
            Console.WriteLine("{0,-3} {1, -3}", sayac, sayac * sayac);
            sayac += 1;
        }
        */





        /*
        Console.WriteLine("Bir Sayı Giriniz: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int a = 2;

        do
        {
            Console.WriteLine("{0,-3}", a);
            a += 2;
        } while (a < n);
        */




        /*
        for (int j = 100; j >= 0; j -= 5)
        {
            Console.WriteLine(j);
        }
        */



        /*
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        for (int b = c; b <= d; b++)
        {
            if (b % 3 == 0)
                continue;
            else
                Console.WriteLine("{0,-3} {1, -3}", b, b * b);
            
        }
        */



        /*
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write("{0},{1}  ", i, j);
            }
            Console.WriteLine();
        }
        */



        /*
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();
        }*/

        Console.ReadLine();
    }
    private static void SwitchCase()
    {
        int A = 10, B = 20;
        Islemler secim = (Islemler)(new Random().Next(1, 4));

        switch (secim)
        {
            case Islemler.Toplama:
                Console.WriteLine($"{A} + {B} = {A + B}");
                break;
            case Islemler.Cikarma:
                Console.WriteLine($"{A} - {B} = {A - B}");
                break;
            case Islemler.Carpma:
                Console.WriteLine($"{A} * {B} = {A * B}");
                break;
            case Islemler.Bolme:
                Console.WriteLine($"{A} / {B} = {A / B}");
                break;
            default:
                Console.WriteLine("\aGeçersiz İşlem!");
                break;
        }

        var k = Console.ReadKey();
        switch (k.Key)
        {
            case ConsoleKey.None:
                break;
            case ConsoleKey.Backspace:
                break;
            case ConsoleKey.Tab:
                break;
            case ConsoleKey.Clear:
                break;
            case ConsoleKey.Enter:
                break;
            case ConsoleKey.Pause:
                break;
            case ConsoleKey.Escape:
                break;
            case ConsoleKey.Spacebar:
                break;
            case ConsoleKey.PageUp:
                break;
            case ConsoleKey.PageDown:
                break;
            case ConsoleKey.End:
                break;
            case ConsoleKey.Home:
                break;
            case ConsoleKey.LeftArrow:
                break;
            case ConsoleKey.UpArrow:
                break;
            case ConsoleKey.RightArrow:
                break;
            case ConsoleKey.DownArrow:
                break;
            case ConsoleKey.Select:
                break;
            case ConsoleKey.Print:
                break;
            case ConsoleKey.Execute:
                break;
            case ConsoleKey.PrintScreen:
                break;
            case ConsoleKey.Insert:
                break;
            case ConsoleKey.Delete:
                break;
            case ConsoleKey.Help:
                break;
            case ConsoleKey.D0:
                break;
            case ConsoleKey.D1:
                break;
            case ConsoleKey.D2:
                break;
            case ConsoleKey.D3:
                break;
            case ConsoleKey.D4:
                break;
            case ConsoleKey.D5:
                break;
            case ConsoleKey.D6:
                break;
            case ConsoleKey.D7:
                break;
            case ConsoleKey.D8:
                break;
            case ConsoleKey.D9:
                break;
            case ConsoleKey.A:
                break;
            case ConsoleKey.B:
                break;
            case ConsoleKey.C:
                break;
            case ConsoleKey.D:
                break;
            case ConsoleKey.E:
                break;
            case ConsoleKey.F:
                break;
            case ConsoleKey.G:
                break;
            case ConsoleKey.H:
                break;
            case ConsoleKey.I:
                break;
            case ConsoleKey.J:
                break;
            case ConsoleKey.K:
                break;
            case ConsoleKey.L:
                break;
            case ConsoleKey.M:
                break;
            case ConsoleKey.N:
                break;
            case ConsoleKey.O:
                break;
            case ConsoleKey.P:
                break;
            case ConsoleKey.Q:
                break;
            case ConsoleKey.R:
                break;
            case ConsoleKey.S:
                break;
            case ConsoleKey.T:
                break;
            case ConsoleKey.U:
                break;
            case ConsoleKey.V:
                break;
            case ConsoleKey.W:
                break;
            case ConsoleKey.X:
                break;
            case ConsoleKey.Y:
                break;
            case ConsoleKey.Z:
                break;
            case ConsoleKey.LeftWindows:
                break;
            case ConsoleKey.RightWindows:
                break;
            case ConsoleKey.Applications:
                break;
            case ConsoleKey.Sleep:
                break;
            case ConsoleKey.NumPad0:
                break;
            case ConsoleKey.NumPad1:
                break;
            case ConsoleKey.NumPad2:
                break;
            case ConsoleKey.NumPad3:
                break;
            case ConsoleKey.NumPad4:
                break;
            case ConsoleKey.NumPad5:
                break;
            case ConsoleKey.NumPad6:
                break;
            case ConsoleKey.NumPad7:
                break;
            case ConsoleKey.NumPad8:
                break;
            case ConsoleKey.NumPad9:
                break;
            case ConsoleKey.Multiply:
                break;
            case ConsoleKey.Add:
                break;
            case ConsoleKey.Separator:
                break;
            case ConsoleKey.Subtract:
                break;
            case ConsoleKey.Decimal:
                break;
            case ConsoleKey.Divide:
                break;
            case ConsoleKey.F1:
                break;
            case ConsoleKey.F2:
                break;
            case ConsoleKey.F3:
                break;
            case ConsoleKey.F4:
                break;
            case ConsoleKey.F5:
                break;
            case ConsoleKey.F6:
                break;
            case ConsoleKey.F7:
                break;
            case ConsoleKey.F8:
                break;
            case ConsoleKey.F9:
                break;
            case ConsoleKey.F10:
                break;
            case ConsoleKey.F11:
                break;
            case ConsoleKey.F12:
                break;
            case ConsoleKey.F13:
                break;
            case ConsoleKey.F14:
                break;
            case ConsoleKey.F15:
                break;
            case ConsoleKey.F16:
                break;
            case ConsoleKey.F17:
                break;
            case ConsoleKey.F18:
                break;
            case ConsoleKey.F19:
                break;
            case ConsoleKey.F20:
                break;
            case ConsoleKey.F21:
                break;
            case ConsoleKey.F22:
                break;
            case ConsoleKey.F23:
                break;
            case ConsoleKey.F24:
                break;
            case ConsoleKey.BrowserBack:
                break;
            case ConsoleKey.BrowserForward:
                break;
            case ConsoleKey.BrowserRefresh:
                break;
            case ConsoleKey.BrowserStop:
                break;
            case ConsoleKey.BrowserSearch:
                break;
            case ConsoleKey.BrowserFavorites:
                break;
            case ConsoleKey.BrowserHome:
                break;
            case ConsoleKey.VolumeMute:
                break;
            case ConsoleKey.VolumeDown:
                break;
            case ConsoleKey.VolumeUp:
                break;
            case ConsoleKey.MediaNext:
                break;
            case ConsoleKey.MediaPrevious:
                break;
            case ConsoleKey.MediaStop:
                break;
            case ConsoleKey.MediaPlay:
                break;
            case ConsoleKey.LaunchMail:
                break;
            case ConsoleKey.LaunchMediaSelect:
                break;
            case ConsoleKey.LaunchApp1:
                break;
            case ConsoleKey.LaunchApp2:
                break;
            case ConsoleKey.Oem1:
                break;
            case ConsoleKey.OemPlus:
                break;
            case ConsoleKey.OemComma:
                break;
            case ConsoleKey.OemMinus:
                break;
            case ConsoleKey.OemPeriod:
                break;
            case ConsoleKey.Oem2:
                break;
            case ConsoleKey.Oem3:
                break;
            case ConsoleKey.Oem4:
                break;
            case ConsoleKey.Oem5:
                break;
            case ConsoleKey.Oem6:
                break;
            case ConsoleKey.Oem7:
                break;
            case ConsoleKey.Oem8:
                break;
            case ConsoleKey.Oem102:
                break;
            case ConsoleKey.Process:
                break;
            case ConsoleKey.Packet:
                break;
            case ConsoleKey.Attention:
                break;
            case ConsoleKey.CrSel:
                break;
            case ConsoleKey.ExSel:
                break;
            case ConsoleKey.EraseEndOfFile:
                break;
            case ConsoleKey.Play:
                break;
            case ConsoleKey.Zoom:
                break;
            case ConsoleKey.NoName:
                break;
            case ConsoleKey.Pa1:
                break;
            case ConsoleKey.OemClear:
                break;
            default:
                Console.WriteLine("\aGeçersiz İşlem!");
                break;
        }
    }
    private static char If_ElseYapisi()
    {
        // tek-çift
        Console.WriteLine("Bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        if (sayi % 2 == 0)
        {
            Console.WriteLine($"{sayi} çift bir sayıdır.");

        }

        //Mutlak Değer
        int n = Convert.ToInt32(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine($"|{n}| = {n * -1}");
        }
        else
        {
            Console.WriteLine($"|{n}| = {n}");

        }

        //
        var k = (char)Console.Read();
        if (char.IsDigit(k))
        {
            Console.WriteLine("Rakamdır!");
        }
        else if (char.IsLower(k))
        {
            Console.WriteLine("Kucuk karakter!");
        }
        else if (char.IsUpper(k))
        {
            Console.WriteLine("Buyuk karakter!");
        }
        else
        {
            Console.WriteLine("Bilinmeyen karakter!");
        }

        return k;
    }
    private static void Operatorler()
    {
        //Aritmetik Oparetörler
        int A = 20; int B = 10;

        Console.WriteLine(A + B);
        Console.WriteLine(A - B);
        Console.WriteLine(A * B);
        Console.WriteLine(A / B);
        Console.WriteLine(A % B);


        //İlişkisel Oparetörler
        Console.WriteLine(A > B);
        Console.WriteLine(A < B);
        Console.WriteLine(A <= B);
        Console.WriteLine(A >= B);
        Console.WriteLine(A == B);
        Console.WriteLine(A != B);

        Console.WriteLine(!(A > B && A > 5));
        Console.WriteLine(A < B || B > 5);
    }
    private static void DizeDegismezleri()
    {
        var ifade = "Merhaba program dünyası ";

        Console.WriteLine(ifade);
        Console.WriteLine(ifade.Length);
        Console.WriteLine(ifade.ToUpper());
        Console.WriteLine(ifade.ToLower());
        Console.WriteLine(ifade.TrimStart());
        Console.WriteLine(ifade.TrimEnd());
        Console.WriteLine(ifade[0]);
        Console.WriteLine(ifade[1]);
        Console.WriteLine(ifade[ifade.Length - 1]);
        Console.ReadKey();
    }
    private static void DegiskenTanimlama()
    {
        string isim = "Ömer";
        Console.WriteLine("Merhaba " + isim + ".");
        Console.ReadKey();
    }
}
    #endregion
