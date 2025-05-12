using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeString = Console.ReadLine();
        int gradePercentage = int.Parse(gradeString);
        string letter = "";

        int gradeRemainder = gradePercentage % 10;
        string gradeSign = "";

        if (gradeRemainder >= 7)
        {
            gradeSign = "+";
        }
        else if (gradeRemainder < 3)
        {
            gradeSign = "-";
        }

        if (gradePercentage >= 90)
        {
            letter = "A";
            if (gradePercentage >= 97)
            {
                gradeSign = "";
            }
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
            gradeSign = "";
        }

        Console.WriteLine($"Letter grade: {letter}{gradeSign}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations on passing the course!");
        }
        else
        {
            Console.WriteLine("I'm sorry, you did not pass the course. Good luck next time!");
        }
    }
}