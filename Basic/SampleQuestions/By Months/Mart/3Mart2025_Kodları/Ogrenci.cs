namespace _3Mart2025_Kodları
{
    internal class Ogrenci
    {
        public Ogrenci(string? ad, string? soyad, double notOrtalaması)
        {
            Ad = !string.IsNullOrEmpty(ad) ? ad : "Ad";
            Soyad = !string.IsNullOrEmpty(soyad) ? soyad : "Soyad";
            NotOrtalaması = (notOrtalaması >= 0 && notOrtalaması <= 100) ? notOrtalaması : 50;
        }

        public void BilgileriGoster()
        {
            Console.WriteLine($"Öğrencinin Adı: {Ad}\n" +
                $"Öğrencinin Soyadı: {Soyad}\n" +
                $"Öğrencinin Not Ortalaması: {NotOrtalaması}");
        }

        protected string? Ad { get; set; }
        protected string? Soyad { get; set; }
        protected double NotOrtalaması { get; set; }
    }
}
