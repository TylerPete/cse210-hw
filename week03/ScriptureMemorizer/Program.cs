// Author: Tyler Peterson

// Purpose: Demonstrate the principles of encapsulation by writing a program
//          using classes, methods, public/private access modifiers, etc. that
//          aids the user in the memorization of a scripture.

// Exceeding requirements: TBD

using System;
using System.Net;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        string scriptureText = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.";
        Reference reference = new Reference("Ether", 12, 27);

        Scripture theScrip = new Scripture(reference, scriptureText);
        string response = "";

        Console.WriteLine(theScrip.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type quit to finish:");

        do
        {
            theScrip.HideRandomWords(3);
            response = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(theScrip.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type quit to finish:");

            if (theScrip.IsCompletelyHidden())
            {
                response = "quit";
            }
        } while (response != "quit");
    }
}