namespace _3Mart2025_Kodları
{
    internal class Hayvan
    {
        public Hayvan(string? ad, string? ses)
        {
            Ad = !string.IsNullOrEmpty(ad) ? ad : "Varsayılan Ad";
            Ses = !string.IsNullOrEmpty(ses) ? ses : "Varsayılan Ses";
        }

        protected string? Ad { get; set; }
        protected string? Ses { get; set; }

        // Virtual olarak işaretleyerek alt sınıfların ezmesini sağlıyoruz
        public virtual void SesCikar()
        {
            Console.WriteLine($"{Ad} {Ses} çıkardı.");
        }
    }

    internal class Kedi : Hayvan
    {
        public Kedi(string? ad) : base(ad, "Miyav") { } 

        // Metodu ezerek kendine özgü bir ses çıkarmasını sağlıyoruz
        public override void SesCikar()
        {
            Console.WriteLine($"{Ad} miyavladı!");
        }
    }

    internal class Kopek : Hayvan
    {
        public Kopek(string? ad) : base(ad, "Hav") { } 

        public override void SesCikar()
        {
            Console.WriteLine($"{Ad} havladı!");
        }
    }
}
