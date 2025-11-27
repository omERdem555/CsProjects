class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Türkçe karakterler için
        Console.Write("Metin girin: ");
        var metin = "İstemiyorsanız Gideyim";

        Kelime k = new Kelime
        {
            ArananMetin = metin
        };
        k.Yaz();
    }
}
