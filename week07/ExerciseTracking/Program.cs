using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.Now;
        DateTime date2 = new DateTime(2024, 9, 13, 7, 30, 30, 0, 0);
        DateTime date3 = new DateTime(2025, 3, 30, 7, 49, 5, 0, 0);

        Activity a1 = new Running(date.ToString(), 30, 3.0);
        Console.WriteLine(a1.GetSummary());

        Activity a2 = new Cycling(date2.ToString(), 60, 13.5);
        Console.WriteLine(a2.GetSummary());

        Activity a3 = new Swimming(date3.ToString(), 45, 20);
        Console.WriteLine(a3.GetSummary());
    }
}