using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        double x = double.Parse(Console.ReadLine());

        double result = (Math.Sin(x) + Math.Cos(x)) / 2;

        Console.WriteLine($"Result: {result}");
    }
}
