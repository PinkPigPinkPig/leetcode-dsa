using CsharpDSA.Exercises.Medium._3623;

namespace CsharpDSA;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var countTrapezoids = new CountTrapezoids();
        var result = countTrapezoids.Run();
        Console.WriteLine(result);
    }
}