internal class Hayvan
{
    public virtual void SesCikar()
    {
        Console.WriteLine("Bir hayvan sesi çıkardı.");
    }
}

internal class Kedi : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("Miyav!");
    }
}

internal class Kopek : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("Hav hav!");
    }
}