using System.Collections;
public class Araba<T> : ICollection<T>
{
    //Interface, Kontratları devir alır. (Kalıtım)

    //Araba Class'ına ICollection tanımlanırsa, kabul ettiği fonksiyonları
    //Uygulamak zorundadır. Aksi takdirde bu kontrata uyum sağlayamaz

    //Kalıtım ':' ile sağlanır.
    public int Count => throw new NotImplementedException();

    public bool IsReadOnly => throw new NotImplementedException();

    public void Add(T item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(T item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public bool Remove(T item)
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

public interface ISehir
{
    //ISehir,(I ile ifade edilir) bir kontrattır. Ve bu kontratı kabul eden sınıfların şu metodlara sahip olmalıdır.
    void Tanit();
    void NufusBilgisiGetir(int plakaNo); //Sadece fonksiyon imzası var. Metodların gövdesi yok 
}
public class Sehir : ISehir, IComparable<Sehir>
{
    public int PlakaNo { get; set; }
    public string SehirAdi { get; set; }

    public Sehir(int plakaNo, string sehirAdi)
    {
        PlakaNo = plakaNo;
        SehirAdi = sehirAdi;
    }

    public override string ToString()
    {
        return $"{PlakaNo,-2} {SehirAdi,-15}";
    }


    #region Interface
    //Interface'deki metodların gövdesini kalıtımla eklediğimiz Sınıflarda dolduruyoruz
    public void Tanit()
    {
        throw new NotImplementedException();
    }

    public void NufusBilgisiGetir(int plakaNo)
    {
        throw new NotImplementedException();
    }


    //IComparable Interface'inden Implemente ettiğimiz metod.
    public int CompareTo(Sehir? other)
    {
        if (this.PlakaNo < other.PlakaNo)
            return -1;
        else if (this.PlakaNo == other.PlakaNo)
            return 0;

        else
            return 1;
    }

    #endregion
}

internal class VeriYapilariVeAlgoritmalar
{
    private static void Main(string[] args)
    {
        //Arrayler

        //Hastable

        //SortedList

        //List();

        //Stack();

        //Queue();

        //LinkedList();

        //Dictionary();

        //SortedDictionary();

        //SortedSet();

        //HashSet();
    }

    private static void HashSet()
    {
        //HashSet
        #region Özellikler
        //Generic bir yapıdır. Boxing / Unboxing yoktur -> Type (Tip) güvenliği
        //Elemanlar benzersiz. Elemanlar sıralanmaz bundan dolayı
        //SortedSet'e göre performans anlamında daha başarılıdır.
        //Küme işlemlerine izin verir 

        #endregion

        #region Temelleri ve Karakter Kümesi Örneği
        //Tanımlama 
        var SesliHarf = new HashSet<char>()
        {
            'e', 'ı', 'i', 'u', 'ü', 'o', 'ö', 'b'
        };

        //Ekleme
        SesliHarf.Add('a');


        //Yazdırma
        KoleksiyonYazdir(SesliHarf);
        Console.WriteLine();


        //Çıkarma
        SesliHarf.Remove('b');
        KoleksiyonYazdir(SesliHarf);

        var Alfabe = new List<char>();

        for (int i = 97; i <= 122; i++)
            Alfabe.Add((char)i);


        Console.WriteLine();
        KoleksiyonYazdir(Alfabe);

        /*
        //Türkçe'de Kullanılan Sesli Harfler
        SesliHarf.ExceptWith(Alfabe);
        KoleksiyonYazdir(SesliHarf);
        */

        /*
        //Tüm Türkçe Harfler
        Console.WriteLine();
        SesliHarf.UnionWith(Alfabe);
        KoleksiyonYazdir(SesliHarf);
        */

        /*
        //Kesişim Dışında Olan Elemanlar
        Console.WriteLine();
        SesliHarf.SymmetricExceptWith(Alfabe);
        KoleksiyonYazdir(SesliHarf);
        */

        Console.ReadKey();
        #endregion
    }

    static void KoleksiyonYazdir(IEnumerable Koleksiyon)
    {
        byte i = 0;
        foreach (char h in Koleksiyon)
        {
            Console.Write($"{h,-3}");
            i++;
        }
        Console.WriteLine("\nEleman Sayısı : {0}", i);

    }
    private static void SortedSet()
    {
        //SortedSet

        #region Özellikler
        //Generic bir yapıdır. T -> Tip. Boxing /  Unboxing yoktur.
        //Elemanları benzersiz olmalıdır. Elemanları sıralayarak ekler

        //Add() -> ekleme (Bool) yoksa ekler. varsa false döner
        //Remove() -> silme
        //RemoveWhere(predecate)  

        //Kümelerdeki Kesişim, Ayrışım, AltKüme 
        //A {1, 2, 3, 4}
        //B {1, 2, 5, 6}
        //A.UnionWith(B) = {1, 2, 3, 4, 5, 6}
        //A.IntersetWith(B) = {1, 2}
        //A.ExceptWith(B) = {3, 4}
        //A.SymetricExceptWith(B) = {3, 4, 5, 6}
        #endregion

        #region Temelleri

        //Tanımlama 
        var IsimListesi = new SortedSet<string>();

        //Ekleme
        if (IsimListesi.Add("Mehmet"))
            Console.WriteLine("Mehmet Eklendi.");
        else
            Console.WriteLine("Ekleme Başarısız.");


        Console.WriteLine("{0}",
            IsimListesi.Add("Ahmet") == true ?
            "Ahmet Eklendi." : "Ekleme Başarısız.");

        if (IsimListesi.Add("Mehmet"))
            Console.WriteLine("Mehmet Eklendi.");
        else
            Console.WriteLine("Ekleme Başarısız.");


        IsimListesi.Add("Sule");
        IsimListesi.Add("Neslihan");
        IsimListesi.Add("Fahrettin");
        IsimListesi.Add("Fatih");

        //Dolaşma
        Console.WriteLine("\nİsimler Listesi:");
        Console.WriteLine(new string('-', 17));
        foreach (string i in IsimListesi)
            Console.WriteLine(i);

        //Çıkarma
        IsimListesi.Remove("Sule");
        IsimListesi.RemoveWhere(deger => deger.Contains("a"));
        Console.WriteLine("\nİsimler Listesi:");
        Console.WriteLine(new string('-', 17));
        foreach (string i in IsimListesi)
            Console.WriteLine(i);

        IsimListesi.RemoveWhere(deger => deger.StartsWith("F"));
        Console.WriteLine("\nİsimler Listesi:");
        Console.WriteLine(new string('-', 17));
        foreach (string i in IsimListesi)
            Console.WriteLine(i);

        //Eleman Sayısı
        Console.WriteLine("Eleman Sayısı : {0, 2}", IsimListesi.Count);
        #endregion

        #region SortedSet Benzersiz Elemanlar Örneği
        //Random sayılardan oluşturulan listenin alt
        //kümesindeki elemanların benzersiz olmasını sağlamak

        var sayilar = new List<int>();
        var r = new Random();

        Console.WriteLine();
        for (int i = 0; i < 50; i++)
        {
            sayilar.Add(r.Next(0, 100));
            Console.Write($"{sayilar[i],-3}");
        }
        Console.WriteLine();

        //Listedeki benzersiz elemanları bulmak

        var bSayilarListesi =
            new SortedSet<int>(sayilar);

        Console.WriteLine("\nBenzersiz Sayılar Listesi : ");

        foreach (int s in bSayilarListesi)
        {
            Console.Write($"{s,-3}");
        }

        Console.WriteLine();
        Console.WriteLine("Benzersiz {0} sayi vardir",
            bSayilarListesi.Count);

        Console.ReadLine();
        #endregion

        #region SortedSet Küme Uygulaması

        //Yazdırma
        var A = new SortedSet<int>() { 1, 2, 3, 4 };
        var B = new SortedSet<int>() { 1, 2, 5, 6 };
        var C = new SortedSet<int>() { 3, 4, 8, 6 };
        var D = new SortedSet<int>() { 1, 9, 7, 4 };

        /*
        var A = new SortedSet<int>(RastgeleSayilarUret(20));
        var B = new SortedSet<int>(RastgeleSayilarUret(10));
        var C = new SortedSet<int>(RastgeleSayilarUret(15));
        */

        Console.Write("A Kümesi: ");
        foreach (int s in A) Console.Write($"{s,-3}");
        Console.WriteLine();


        Console.Write("B Kümesi: ");
        foreach (int s in B) Console.Write($"{s,-3}");
        Console.WriteLine();

        Console.Write("C Kümesi: ");
        foreach (int s in C) Console.Write($"{s,-3}");
        Console.WriteLine();

        Console.Write("D Kümesi: ");
        foreach (int s in D) Console.Write($"{s,-3}");
        Console.WriteLine();



        //Union
        A.UnionWith(B);
        Console.Write("A ve B Kümesinin Birleşimi: ");
        foreach (int s in A) Console.Write($"{s,-3}");

        Console.WriteLine();

        Console.WriteLine("Toplam Sayisi : {0}", A.Count);

        //Intersect
        A.IntersectWith(C);
        Console.Write("A ve C Kümesinin Kesişimi: ");
        foreach (int s in A) Console.Write($"{s,-3}");

        Console.WriteLine();

        Console.WriteLine("Toplam Sayisi : {0}", A.Count);

        //Except
        C.ExceptWith(A);
        Console.Write("Sadece C Kümesindeki Elemanlar: ");
        foreach (int s in C) Console.Write($"{s,-3}");

        Console.WriteLine();

        Console.WriteLine("Toplam Sayisi : {0}", C.Count);

        //SymetricExcept
        D.SymmetricExceptWith(A);
        Console.Write("A ve D Kesişimi Dışındaki Elemanlar: ");
        foreach (int s in D) Console.Write($"{s,-3}");
        Console.WriteLine();

        Console.WriteLine("Toplam Sayisi : {0}", D.Count);

        //IsSubsetOf
        A.IsProperSubsetOf(B); //A B'nin alt kümesi mi?
        #endregion
    }

    static List<int> RastgeleSayilarUret(int n)
    {
        var list = new List<int>();
        var r = new Random();
        for (int i = 0; i < n; i++)
        {
            list.Add(r.Next(0, 1000));
        }
        return list;
    }
    private static void SortedDictionary()
    {
        //SortedDictionary
        #region Özellikler

        //Generic bir yapıdır. Boxing / Unboxing yoktur
        //Dictionary sınıfında kullanılan metodların hepsi
        //bu koleksiyon için de kullanılabilir

        //TKey - TValue / Anahtar - Değer çifti
        //TKey benzersiz olmalı. TValue istediğiniz değer olabilir.

        //Ekleme adımında sıralama işlemi de yapıldığından bir miktar 
        //performans kaybı olabilir
        #endregion

        #region Temelleri ve Kelime - Sayfa Örneği
        var KitapIndex = new SortedDictionary<string, List<int>>()
        {
            {"HTML", new List<int>() {8, 10, 12 } },
            {"CSS", new List<int> {70, 80, 90 } },
            {"FTP", new List<int>(){3, 5, 7} },
            {"jQUERY", new List<int>(){3, 5, 15} },
            {"SQL", new List<int>(){70, 80} },
            {"ASP.NET", new List<int>{50, 60} }
        };

        foreach (var kavram in KitapIndex)
        {
            Console.WriteLine(kavram.Key + " : ");
            kavram.Value.ForEach(s => Console.WriteLine($"\t > {s,-3} pp"));
            Console.WriteLine();
        }
        Console.ReadLine();
        #endregion
    }

    private static void Dictionary()
    {
        //Dictionary
        #region Özellikler
        //Generic bir yapıdır
        //Generic -> Boxing / Unboxing yoktur. Type safe
        //TKey - TValue / Anahtar - Değer çifti
        //TKey benzersiz olmalı. TValue istediğiniz değer olabilir.

        //Hastable yapısına benzer ama daha performanslı çalıştığını söyleyebiliriz.
        #endregion

        #region Temeller ve Telefon Kodu Örneği
        //Şehirler arası telefon kodlarını içeren bir sözcük tanımı

        //Tanımlama
        var TelefonKodları = new Dictionary<int, string>()
        {
            {332, "Konya" },
            {424, "Elazığ" },
            {466, "Art" }
        };

        //Ekleme
        TelefonKodları.Add(322, "Adana");
        TelefonKodları.Add(212, "İstanbul");
        TelefonKodları.Add(216, "İstanbul");


        //Erişme
        TelefonKodları[466] = "Artvin";

        //Koşula Bağlı İş - ContainKey
        if (!TelefonKodları.ContainsKey(312))
        {
            Console.WriteLine("\aAnkara'nın Kod bilgisi tanımlı değildir!");
            TelefonKodları.Add(312, "Ankara");
            Console.WriteLine("Yeni Kod eklendi.");
        }

        //ContainsValue
        if (!TelefonKodları.ContainsValue("Malatya"))
        {
            Console.WriteLine("\aMalatya'nın Kod bilgisi tanımlı değildir!");
            TelefonKodları.Add(422, "Malatya");
            Console.WriteLine("Yeni Kod eklendi");
        }

        //Çıkarma
        TelefonKodları.Remove(322); //Adana Kelimeden çıkarıldı


        //Dolaşma
        foreach (var Kod in TelefonKodları)
        {
            Console.WriteLine(Kod);
        }


        Console.ReadKey();
        #endregion

        #region Dictionary Personel Örneği
        var PersonelListesi = new Dictionary<int, Personel>()
        {
            {110, new Personel("Mehmet", "Sonsuz",  7500)},
            {120, new Personel("Ahmet", "Can", 9000) }
        };
        PersonelListesi.Add(100, new Personel("Zeynep", "Coskun", 5000));

        foreach (var p in PersonelListesi)
        {
            Console.WriteLine(p);
        }
        #endregion
    }

    private static void LinkedList()
    {
        //LinkedList
        #region Özellikler

        //Generic bir yapıdır
        //Generic -> Boxing / Unboxing yoktur
        //T -> Type (Tip)

        //Bilgisayar bilimlerinde, elemanların hafızadaki
        //konumlarının sıralı olarak organize edilmediği
        //doğrusal bir Liste yapısıdır

        //Bağlı Liste, düğümlerden oluşur
        //Her bir düğüm iki farklı elemandan oluşur
        //
        //|_Önceki elemanı işaret eden işaretçi(Previous)_|--|_Veri_|--|_İşaretçi(Next)_| 

        //AddFirst, AddLast,    First, Last
        //Remove, RemoveFirst, RemoveLast
        //AddBefore, AddAfter
        #endregion

        #region Temeller ve Şehir Gezi Örneği
        //Tanımlama
        var Sehirler = new LinkedList<string>();
        Sehirler.AddFirst("Ordu");
        Sehirler.AddFirst("Trabzon");
        Sehirler.AddLast("İstanbul");

        Sehirler.AddAfter(Sehirler.Find("Ordu"), "Samsun");
        Sehirler.AddAfter(Sehirler.First.Next.Next, "Giresun");
        Sehirler.AddAfter(Sehirler.Last.Previous, "Sinop");
        Sehirler.AddAfter(Sehirler.Find("Sinop"), "Zonguldak");

        Console.WriteLine("\nGidiş Güzergahı\n");
        var eleman1 = Sehirler.First;
        while (eleman1 != null)
        {
            Console.WriteLine(eleman1.Value);
            eleman1 = eleman1.Next;
        }

        Console.WriteLine("\nDönüş Güzergahı\n");
        var eleman2 = Sehirler.Last;
        while (eleman2 != null)
        {
            Console.WriteLine(eleman2.Value);
            eleman2 = eleman2.Previous;
        }

        Console.ReadLine();
        #endregion
    }

    private static void Queue()
    {
        //Queue

        #region Özellikler
        //Generic bir türdür
        //Generic -> Boxing / Unboxing yoktur
        //T -> Type (Tip)
        //İlk gelen ilk çıkar (FIFO)

        //Enqueu ekleme, Dequeu çıkarma
        //Peek en üstteki eleman, Clear temizleme
        //Count eleman sayısı

        //Operation Systemlerde, çalışma önceliği
        //Ağ yazıcılarında, Mesaj kuyrukları
        //Buffer yapıları (tampon)
        #endregion

        #region Temeller ve Sesli Harfler Örneği
        //Sesli harfleri tutan kuyruk yapısı

        //Queue tanımlama
        var kKuyrugu = new Queue<char>();

        //Ekleme
        kKuyrugu.Enqueue('a');
        kKuyrugu.Enqueue('e');
        Console.WriteLine($"Karakter sayısıs : {kKuyrugu.Count}");
        var dizi = kKuyrugu.ToArray();

        //Çıkarma
        Console.WriteLine($"Kuyruğun başındaki eleman : {kKuyrugu.Peek()}");
        Console.WriteLine($"Silinen eleman : {kKuyrugu.Dequeue()}");  //Kuyruğun başındaki objeyi döner ve siler.
        Console.WriteLine($"Karakter sayısıs : {kKuyrugu.Count}");
        Console.WriteLine($"Kuyruğun başındaki eleman : {kKuyrugu.Peek()}");

        Console.ReadLine();
        #endregion

        #region Kuyruk Seshi Harfleri Liste ve Kuyruğa Ekleme Örneği
        //Sesli Harfleri önce liste yapısına
        //ekleyecek sonra bu listeyi kuyruk yapısına
        //eklemek ister misin? Diye sorup (e) ekleyecek.

        var sesliHarfler = new List<char>()
        {
            'a', 'e', 'ı', 'i',
            'u', 'ü', 'o', 'ö'
        };

        ConsoleKeyInfo secim;

        var sHarflerKuyruk = new Queue<char>();

        foreach (char c in sesliHarfler)
        {
            Console.WriteLine();
            Console.WriteLine($"{c,-5} kuyruğa eklensin mi? [e/h] ");
            secim = Console.ReadKey();
            Console.WriteLine();
            if (secim.Key == ConsoleKey.E)
            {
                sHarflerKuyruk.Enqueue(c);
                Console.WriteLine($"\n{c,-5} kuyruğa eklendi.");
                Console.WriteLine($"Kuyruktaki eleman sayisi : {sHarflerKuyruk.Count}");
                Console.WriteLine();
            }
        }

        Console.Write($"\nKuyruktan elemanların kaldırılması işlemi için Esc tuşuna basın : ");
        secim = Console.ReadKey();
        Console.WriteLine();
        if (secim.Key == ConsoleKey.Escape)
        {
            while (sHarflerKuyruk.Count > 0)
            {
                Console.WriteLine($"{sHarflerKuyruk.Dequeue(),-5} kuyruktan çıkartılıyor. ");
                Console.WriteLine($"Kuyruktaki eleman sayisi : {sHarflerKuyruk.Count}");
            }

            Console.WriteLine("\nKuyruktan eleman silme işlemi tamamlandı. ");
        }

        Console.WriteLine("Program Bitti");

        #endregion
    }

    private static void Stack()
    {
        //Stack
        #region Özellikler
        //Generic bir türdür
        //Generic -> Boxing/Unboxing yok
        //T -> Type (Tip) Stack<int>, Stack<string> 
        //Son gelen ilk çıkar (LIFO)

        //push() ekleme, pop() çıkarma,
        //peek() en üstteki eleman, clear() temizleme
        //count() eleman sayısı, ToArray diziye çevirme

        //Fonksiyon çağırılan ve özyinelemeli 
        //En son kullanılan uygulamaların listesi 
        //Söz dizimi hataları, Geri izleme işlemlerinde 
        //Ters çevirme, Hafıza yönetimi
        //Tarayıcı sekmeler durumlarda yığın kullanılabilir.
        #endregion

        #region Temeller
        //Stack tanımlama
        var KarakterYigini = new Stack<char>();


        //Ekleme
        KarakterYigini.Push('A');
        Console.WriteLine(KarakterYigini.Peek());
        KarakterYigini.Push('B');
        Console.WriteLine(KarakterYigini.Peek());
        KarakterYigini.Push('C');
        Console.WriteLine(KarakterYigini.Peek());


        Console.WriteLine(new string('-', 25));


        //Çıkarma
        Console.WriteLine(KarakterYigini.Pop() + " Yığından Çıkartıldı");
        Console.WriteLine(KarakterYigini.Pop() + " Yığından Çıkartıldı");
        Console.WriteLine(KarakterYigini.Pop() + " Yığından Çıkartıldı");

        Console.ReadLine();
        #endregion

        #region DinamikYığın
        var DKarakterYığını = new Stack<char>();
        for (int a = 65; a < 91; a++)
        {
            DKarakterYığını.Push((char)a);
            Console.WriteLine($"{DKarakterYığını.Peek()} Yığına Eklendi.");
            Console.WriteLine($"Yığındaki eleman sayisi : {DKarakterYığını.Count}");
        }

        Console.WriteLine();
        //Yığını diziye atama
        var dizi = DKarakterYığını.ToArray();
        foreach (var b in dizi)
        {
            Console.WriteLine("Dizinin " + b);
        }


        Console.WriteLine();
        Console.WriteLine("Yığından çıkartma işlemi için bir tuşa basınız.");
        Console.ReadKey();


        while (DKarakterYığını.Count > 0)
        {
            Console.WriteLine(DKarakterYığını.Pop() + " yığından çıkarıldı");
            Console.WriteLine($"Yığındaki eleman sayisi : {DKarakterYığını.Count}");
        }



        Console.ReadKey();
        #endregion

        #region Sayıları Ayıklayıp Yazma
        //Kullanıcının girdiği 432(örn) sayıyı
        //yığının içine 2 3 4 şeklinde alıp 
        //bunları 400 30 2 şeklinde ayıklamak

        Console.Write("Bir sayı giriniz : ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        var sYığını = new Stack<int>();

        while (sayi > 0)
        {
            int k = sayi % 10;
            sYığını.Push(k);
            sayi /= 10;
        }

        int i = 0; int üs = sYığını.Count - 1;

        foreach (var s in sYığını)
        {
            Console.WriteLine($"\t{s,7} x " +
                $"{Math.Pow(10, üs - i),7}\t = " +
                $"{s * Math.Pow(10, üs - i),7}");
            i++;
        }


        Console.ReadLine();

        #endregion
    }

    private static void List()
    {
        //List<T>
        #region Özellikler
        //Generic bir türdür.
        //Interface (Arayüz) Burada tanımlı olan metodları bu kontratı
        //kabul eden sınıflar tarafından uygulanmasıdır.
        #endregion

        #region Sayıları ve Şehirleri Sıralama Örneği

        //Sayılar Listesi
        var Sayilar = new List<int>() { 53, 40, 14, 2, 3, 12, 15 };
        Sayilar.ForEach(x => Console.Write($"{x,-5}"));
        #region Sıralama
        Console.Write("\nSayılar Sıralanıyor");
        Thread.Sleep(50);
        Console.Write(".");
        Thread.Sleep(70);
        Console.Write(".");
        Thread.Sleep(100);
        Console.Write(".");
        Sayilar.Sort();

        Console.WriteLine("\nSıralanmış Sayılar:\n");
        Sayilar.ForEach(x => Console.Write($"{x,-5}"));

        Console.WriteLine("\n\n\n");
        #endregion

        //Sehirler Listesi
        var Sehirler = new List<Sehir>()
        {
            new Sehir(6, "Ankara"),
            new Sehir(34, "İstanbul"),
            new Sehir(55, "Samsun"),
            new Sehir(23, "Elazığ"),
            new Sehir(44, "Malatya"),
            new Sehir(1, "Adana")
        };
        Sehirler.ForEach(s => Console.WriteLine($"{s}"));
        #region Sıralama
        Console.Write("\nŞehirler Sıralanıyor");
        Thread.Sleep(50);
        Console.Write(".");
        Thread.Sleep(70);
        Console.Write(".");
        Thread.Sleep(100);
        Console.Write(".");
        Sehirler.Sort();

        Console.WriteLine("\nSıralanmış Şehirler:\n");
        Sehirler.ForEach(s => Console.WriteLine($"{s}"));

        Console.WriteLine("\n\n\n");
        #endregion


        Console.ReadLine();
        #endregion
    }

    private static void SortedList()
    {
        //SortedList
        #region Özellikler
        //NonGeneric
        //Key-Value
        //Anahtara bağlı sıralama yapılır. Ekleme yapıldığı zaman sıralama yapılır
        //Sıralı olarak organize edilirler
        //Hem anahtarlarla hem indislerle elemanlara erişmek 
        #endregion

        #region Temeller
        var List = new SortedList()
            {
                {1, "Bir" },
                {2, "İki" },
                {8, "Sekiz" },
                {5, "Beş" },
                {3, "Üç" },
                {6, "Altı" }
            };

        //Dolaşma
        foreach (DictionaryEntry l in List)
        {
            Console.WriteLine($"{l.Key} - {l.Value}");
        }


        Console.WriteLine("Listedeki Eleman Sayisi: {0}", List.Count);
        Console.WriteLine("Listenin Kapasitesi: {0}", List.Capacity);
        List.TrimToSize();
        Console.WriteLine("Listenin Kapasitesi: {0}", List.Capacity);


        //Erişme
        Console.WriteLine(List[3]); //key
        Console.WriteLine(List.GetByIndex(0)); //İndis
        Console.WriteLine(List.GetKey(0)); // Get -> Key
        Console.WriteLine(List.GetKey(List.Count - 1)); //Sondaki elemanın Key değeri

        //Anahtarlara Erişme
        var Anahtarlar = List.Keys;
        Console.WriteLine("\nAnahtarlar");
        foreach (var l in Anahtarlar)
        {
            Console.Write("{0,-2}", l);
        }

        //Değerlere Erişme
        var Değerler = List.Values;
        Console.WriteLine("\nDeğerler");
        foreach (var d in Değerler)
        {
            Console.Write("{0} ", d);
        }


        //Değer Değiştirme 
        if (List.ContainsKey(1))
        {
            List[1] = "One";
        }
        Console.WriteLine("\nGüncel Liste:");
        foreach (DictionaryEntry l in List)
        {
            Console.WriteLine($"{l.Key} - {l.Value}");
        }
        Console.ReadKey();

        #endregion

        #region İçindekiler Örneği
        //Örneğin bir kitabın 'İçindekiler' kısmında başlığın hangi sayfada 
        //Olduğunu görmek için sayfa numarası ve konu başlığı şeklini ele alacağız
        var KitapIcerigi = new SortedList()
        {
            {1, "Önsöz"},
            {50, "Değişkenler"},
            {40, "Operatörler"},
            {60, "Döngüler"},
            {45, "İlişkisel Operatörler"},

        };

        Console.WriteLine("\n\n\nİçindekiler:");
        Console.WriteLine(new string('-', 27));
        foreach (DictionaryEntry i in KitapIcerigi)
        {
            Console.WriteLine($"{i.Key,-3}- {i.Value,-20}");
        }

        Console.ReadKey();

        #endregion
    }

    private static void Hastable()
    {

        //NonGeneric
        //Key-Value
        #region Hastable
        //Tanımlama
        var Sehirler = new Hashtable();

        //Ekleme
        Sehirler.Add(6, "Ankara");
        Sehirler.Add(34, "İstanbul");
        Sehirler.Add(55, "Samsun");
        Sehirler.Add(23, "Elazığ");


        //Dolaşma
        foreach (DictionaryEntry s in Sehirler)
        {
            Console.WriteLine($"{s.Key,-5}" +
                $"{s.Value,-20}");
        }

        //Anahtarları Alma
        Console.WriteLine("\nAnahtarlar:");
        var Anahtarlar = Sehirler.Keys;
        foreach (var a in Anahtarlar)
        {
            Console.WriteLine(a);
        }

        //Değerleri Alma
        Console.WriteLine("\nDeğerler:");
        ICollection Değerler = Sehirler.Values;
        foreach (var d in Değerler)
        {
            Console.WriteLine(d);
        }


        //Elemana Erişme
        Console.WriteLine("\nElemena Erişme");
        Console.WriteLine("{0} [55]", Sehirler[55]); //Dizilerdeki gibi 0'dan başlayan bir indeksleme yoktur

        //Eleman Silme
        Console.WriteLine("\nEleman Silme");
        Sehirler.Remove(34);

        Console.WriteLine("Yeni Hastable:");
        foreach (DictionaryEntry s in Sehirler)
        {
            Console.WriteLine($"{s.Key,-5}" +
            $"{s.Value,-20}");
        }
        Console.ReadKey();

        #endregion

        #region İnternet Adresi Örneği
        //Örneğin https://www.btkakademi.gov.tr/portal/course/player/deliver/algoritma-programlama-ve-veri-yapilarina-giris-12565
        //Burda "Algoritma Programlama ve Veri Yapılarına Giriş" dersi
        //adres içine yazılmış. Ders başlığındaki büyük harfler ve boşluk adrese
        //yazılma şeklini ele alacağız
        //HASTABLE UYGULAMASI (İnternet Sitelerindeki URL adresi)


        //Başlığı Okuma
        Console.Write("Başlık Giriniz: ");
        string Baslik = Console.ReadLine();


        //Değerleri Küçültme
        Baslik = Baslik.ToLower();

        //Hashtable
        var KarakterSeti = new Hashtable()
            {
                {'ç', 'c'},
                {'ı', 'i'},
                {'ğ', 'g'},
                {'ü', 'u'},
                {'ş', 's'},
                {'ö', 'o'},
                {'\'', '-'},
                {'.', '-'},
                {'?', '-'},
                {'=', '-'},
                {')', '-'},
                {'(', '-'},
                {' ', '-'}
            };

        //Dolaşma
        foreach (DictionaryEntry item in KarakterSeti)
        {
            Baslik = Baslik.Replace((char)item.Key, (char)item.Value);
        }


        //Ekrana Yazdır
        Console.WriteLine(Baslik);

        Console.ReadLine();

        #endregion
    }

    private static void Arrayler()
    {
        //Array | Dizi

        #region Temeller
        //Tanımlama
        int[] sayilar = new int[] { 31, 20, 85, 49, 51, 18, 55, 43 };
        var numbar = Array.CreateInstance(typeof(int), sayilar.Length);
        sayilar.CopyTo(numbar, 0);
        var arr = new ArrayList(sayilar);



        //Dolaşma
        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.WriteLine($"Sayilar[{i}] = " +
                $"{sayilar[i]} - " +
                $"Numbar[{i}] = " +
                $"{numbar.GetValue(i)}" +
                $" arr[{i}] = " +
                $"{arr[i]}");
        }
        Console.WriteLine(new string('-', 42));

        Array.Sort(sayilar);
        Array.Clear(sayilar, 2, 2);
        Console.WriteLine(Array.IndexOf(sayilar, 49));


        //Sıralama ve Dolaşma
        arr.Sort();
        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.WriteLine($"Sayilar[{i}] = " +
                $"{sayilar[i]} - " +
                $"Numbar[{i}] = " +
                $"{numbar.GetValue(i)}" +
                $" arr[{i}] = " +
                $"{arr[i]}");
        }

        Console.ReadLine();

        #endregion
    }
}
