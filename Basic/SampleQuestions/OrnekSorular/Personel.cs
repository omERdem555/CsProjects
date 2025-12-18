using System.ComponentModel;

internal class Personel
{
    public string? Ad;
    public string? Soyad;
    private int Maas;

    public void PersonelMaasi(int maas)
    {
        if (maas > 0)
            Maas = maas;
        else
            Maas = 0;
    }

    public void MaasArttir(int artis)
    {
        Maas += artis;
    }
}