namespace SehirVerileriniKullanma
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Veriler.UlkeleriYazdir();
            Console.WriteLine($"\n\nIsim\tYas\tKilo\tUlke");
            Veriler.KisiBilgileriniYazdir();
            //Türkiye Fransa  Italya  Ispanya ABD     Almanya Yunanistan      Rusya   Kanada  Ingiltere
        }
    }
}