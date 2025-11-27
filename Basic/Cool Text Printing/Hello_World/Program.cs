internal class Hello_World
{
    private static void Main(string[] args)
    {
        Console.Write("Hangi Metni Bastırmak İstiyorsun : ");
        string Metin = Convert.ToString(Console.ReadLine());
        char[] ArananHarfler = new char[Metin.Length];
        for (int j = 0; j < Metin.Length; j++)
        {
            for (int i = 32; i <= 122; i++)
            {
                foreach (char c in ArananHarfler)
                    Console.Write(c);
                Console.WriteLine((char)i);
                if (Metin[j] == (char)i)
                {
                    ArananHarfler[j] = (char)i;
                    break;
                }
                Thread.Sleep(5);
            }
        }
    }
}