using _11Mart2025_Kodları;

internal class Program
{
    private static void Main(string[] args)
    {
        //OrnekInternal();

        //OrnekCtor();

    }
    private static void OrnekCtor()
    {
        A o2 = new A();
        o2.Aprop = 4;
        o2.Bprop = 5;

        Ornek2 o1 = new Ornek2();
        o1.Aprop = 2;
        o1.Bprop = 3;

        A o3 = new A();

        Ornek2 o4 = new Ornek2(2, 3);
    }
    private static void OrnekInternal()
    {
        OrnekClass c1 = new OrnekClass(2, 3);
        c1.C(3);
        c1.D(3);

        OrnekClass c2 = new OrnekClass(2);
        c2.D(3);
        c2.C(3);

        OrnekClass2 c3 = new OrnekClass2(4, 6);
        c3.D(5);
        c3.C(3);
        c3.Yaz();
        c3.D(19);

        OrnekClass2 c4 = new OrnekClass2(4, 8);
        c4.D(10);
        c4.Yaz();
        c3.C(4);
    }
}