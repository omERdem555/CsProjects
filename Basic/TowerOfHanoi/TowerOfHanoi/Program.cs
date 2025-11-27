using System;

class TowerOfHanoi
{
    static void Main(string[] args)
    {
        int diskSayisi = 3; // Taşıyacağımız disk sayısı
        Console.Write("Hanoi Kulesi için disk sayısını girin:");
        if (int.TryParse(Console.ReadLine(), out int input))
        {
            diskSayisi = input;
        }

        HanoiKulesi(diskSayisi, 'A', 'C', 'B');
    }

    static void HanoiKulesi(int n, char kaynak, char hedef, char ara)
    {
        if (n == 1)
        {
            Console.WriteLine($"Disk 1 {kaynak} kulesinden {hedef} kulesine taşındı.");
            return;
        }

        HanoiKulesi(n - 1, kaynak, ara, hedef);
        Console.WriteLine($"Disk {n} {kaynak} kulesinden {hedef} kulesine taşındı.");
        HanoiKulesi(n - 1, ara, hedef, kaynak);
    }
}
