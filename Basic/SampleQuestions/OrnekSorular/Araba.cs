internal class Araba
{
    private string? Marka;
    private string? Model;
    private int Yil;

    public Araba(string? marka, string? model, int yil)
    {
        Marka = marka; Model = model; Yil = yil;
    }

    public override string ToString()
    {
        return $"{Marka,-10} {Model,-10} {Yil}";
    }
}