using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment baseAssgn = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(baseAssgn.GetSummary());

        MathAssignment mathAssgn = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssgn.GetSummary());
        Console.WriteLine(mathAssgn.GetHomeworkList());

        WritingAssignment writeAssgn = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writeAssgn.GetSummary());
        Console.WriteLine(writeAssgn.GetWritingInformation());
    }
}