using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response;

        do
        {
            Random randomGenerator = new Random();
            int theNumber = randomGenerator.Next(1, 101);

            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int guessNumber = int.Parse(guess);
            int numGuesses = 1;

            while (guessNumber != theNumber)
            {
                if (guessNumber < theNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber > theNumber)
                {
                    Console.WriteLine("Lower");
                }

                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
                numGuesses++;
            }

            Console.WriteLine($"You guessed it! It took you {numGuesses} tries.");

            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "yes");
    }
}