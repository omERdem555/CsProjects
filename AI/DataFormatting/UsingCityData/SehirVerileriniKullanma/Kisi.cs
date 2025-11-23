namespace SehirVerileriniKullanma
{
    public class Kisi
    {
        public string? Isim { get; set; }
        public int Yas { get; set; }
        public double Kilo { get; set; }
        public string? Ulke { get; set; }


        public override string ToString()
        {
            return $"{Isim}\t{Yas}\t{Kilo}\t{Ulke}";
        }
    }

}
