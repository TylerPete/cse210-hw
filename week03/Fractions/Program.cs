using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testing, testing");

        Fraction f1 = new Fraction();
        Console.WriteLine($"Fraction one: {f1.GetFractionString()}");
        Console.WriteLine($"Decimal: {f1.GetDecimalValue()}");

        f1.SetTop(7);
        Console.WriteLine($"New top: {f1.GetTop()}");
        f1.SetBottom(9);
        Console.WriteLine($"New bottom: {f1.GetBottom()}");

        Fraction f2 = new Fraction(8);
        Console.WriteLine($"Fraction two: {f2.GetFractionString()}");
        Console.WriteLine($"Decimal: {f2.GetDecimalValue()}");

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine($"Fraction three: {f3.GetFractionString()}");
        Console.WriteLine($"Decimal: {f3.GetDecimalValue()}");
    }
}