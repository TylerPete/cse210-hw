using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a series of numbers, type 0 when finished.");

        Console.Write("Enter a number: ");
        string response = Console.ReadLine();
        int number = int.Parse(response);
        
        do
        {
            numbers.Add(number);

            Console.Write("Enter a number: ");
            response = Console.ReadLine();
            number = int.Parse(response);
        } while (number != 0);

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");
    
    }
}