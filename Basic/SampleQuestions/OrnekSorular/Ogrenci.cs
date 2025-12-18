public class Ogrenci
{
    public string? Ad { get; set; }
    public string? Soyad { get; set; }
    public int Numara { get; set; }
    public Ogrenci(string? ad, string? soyad, int numara)
    {
        Ad = ad;
        Soyad = soyad;
        Numara = numara;
    }
    public override string ToString()
    {
        return $"{Ad,-10} {Soyad,-15} {Numara,-5}";
    }
}
