using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.Now;

        Activity a1 = new Running(date.ToString(), 30, 3.0);
        Console.WriteLine(a1.GetSummary());
    }
}