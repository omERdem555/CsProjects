internal class Kelime
{
    public string ArananMetin { get; set; }

    public void Yaz()
    {
        string bulunan = new string(' ', ArananMetin.Length);

        for (int index = 0; index < ArananMetin.Length; index++)
        {
            char hedef = ArananMetin[index];

            // Harf değilse direkt ekle
            if (!char.IsLetter(hedef))
            {
                bulunan = bulunan.Remove(index, 1).Insert(index, hedef.ToString());
                Console.WriteLine(bulunan);
                continue;
            }

            // Unicode aralığında karakterleri dene (Türkçe dahil)
            for (char c = '\u0020'; c <= '\u05FF'; c++)
            {
                string temp = bulunan.Remove(index, 1).Insert(index, c.ToString());
                Console.WriteLine(temp);
                Thread.Sleep(5);

                if (hedef == c)
                {
                    bulunan = temp;
                    break;
                }
            }
        }

        // Sonuç rengini değiştir
        Console.WriteLine("\a");
        Console.ForegroundColor = ConsoleColor.Green; // İstediğin renk
        Console.WriteLine(bulunan);
        Console.ResetColor();
    }
}