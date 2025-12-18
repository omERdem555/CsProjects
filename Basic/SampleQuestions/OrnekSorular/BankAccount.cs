internal class BankAccount
{
    public int HesapNumarasi;
    private byte Bakiye;

    public BankAccount(int hesapNumarasi, byte bakiye)
    {
        HesapNumarasi = hesapNumarasi;
        Bakiye = bakiye;
    }

    public void ParaEkle(int hesapNumarasi, byte miktar)
    {
        if (hesapNumarasi == HesapNumarasi)
        {
            Bakiye += miktar;
            Console.WriteLine($"Mevcut bakiyeniz: {Bakiye}");
        }

        else
            Console.WriteLine("\aBu hesap numarasına sahip kimse yoktur!");
    }

    public void ParaCek(int hesapNumarasi, byte miktar)
    {
        if (Bakiye >= miktar)
        {
            if (hesapNumarasi == HesapNumarasi)
            {
                Bakiye -= miktar;
                Console.WriteLine($"Mevcut bakiyeniz: {Bakiye}");
            }
            else
                Console.WriteLine("\aBu hesap numarasına sahip kimse yoktur!");
        }
        else
            Console.WriteLine("\aYeteri kadar bakiye yoktur!");
    }
}

