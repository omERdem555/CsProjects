internal class Program
{
    private static void Main(string[] args)
    {

        int[] Cinsiyetler = new int[100];
        for (int i = 0; i < 100; i++)
        {
            Cinsiyetler[i] = 3;
        }

        Console.WriteLine("Hello, World!");
        CinsiyetDegerleriniDoldur.Cinsiyet cinsiyet = new CinsiyetDegerleriniDoldur.Cinsiyet(); 
        cinsiyet.ShowMenu(Cinsiyetler);
    }
}