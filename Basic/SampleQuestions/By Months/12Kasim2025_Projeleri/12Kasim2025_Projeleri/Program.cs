internal class Program
{
    private static void Main(string[] args)
    {/*
        int i = 2;
        Console.Write(++i);
        Console.Write(i++);
        Console.Write(i);
        Console.WriteLine("\n\n");

        int x = 15, y = 5, result;

        result = x & y;
        Console.WriteLine(result);
        result = x | y;
        Console.WriteLine(result);
        result = x ^ y;
        Console.WriteLine(result);
        result = x << 2;
        Console.WriteLine(result);
        result = x >> 2;
        Console.WriteLine(result);*/

        byte x = 15, y = 254;
        Console.WriteLine(Convert.ToString(x, toBase: 2));
        Console.WriteLine(Convert.ToString(y, toBase: 2));

        var result = x & y;
        Console.WriteLine(result);

        result = result - (x | y);
        Console.WriteLine(--result);

        result = result - x ^ y;
        Console.WriteLine(result++);

        result = (result + x) << 2; 
        Console.WriteLine("result");

        result = result + x >> 2;
        Console.WriteLine(result);
    }
}