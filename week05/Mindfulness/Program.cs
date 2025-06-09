// Purpose:
// Author: Tyler Peterson
// Exceeding requirements: Added a small amount of exception handling for invalid user input;
//                          ADD ADDITIONAL INFO HERE

using System;

class Program
{
    static void Main(string[] args)
    {
        int response = 0;

        while (response != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            try
            {
                response = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                response = 0;
                Console.WriteLine("Sorry, your selection was not valid. Please try again.");
                Thread.Sleep(2000);
            }

            if (response == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity(30);
                breathingActivity.Run();
            }
            else if (response == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity(30);
                reflectingActivity.Run();
            }
            else if (response == 3)
            {
                //code
            }
            else if (response == 4)
            {
                //code
            }
            else
            {
                Console.WriteLine("Sorry, your selection was not valid. Please try again.");
                Thread.Sleep(2000);
            }
        }

    }
}