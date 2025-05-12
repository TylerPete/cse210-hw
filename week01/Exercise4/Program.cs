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
        int largest = numbers[0];
        int smallestPositive = 1000000;

        foreach (int num in numbers)
        {
            sum += num;

            if (num > largest)
            {
                largest = num;
            }

            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }

        float avg = (float)sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}