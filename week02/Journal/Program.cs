// Purpose: Demonstrate abstraction in practice by writing a program to help
//      the user record the events of their day by supplying prompts and storing
//      their responses along with the question and a date.

// Author: Tyler Peterson

// Exceeding requirements: Implemented a method called GetDaysElapsed() within
//      the Journal class, which uses DateTime objects and the TimeSpan class
//      to calculate the number of days between the first and last Entries in
//      the Journal and returns them in a string. This new method is called by
//      Program.cs when the user selects option number 2 to display all Journal
//      entries. The number of days elapsed is written after all the entries are
//      displayed. I've included a file called  testjournal.txt  (containing
//      entries spanning multiple dates) within this repository that can be
//      used to test this method.

using System;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.IO;
using System.IO.Enumeration;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Journal theJournal = new Journal();
        int selection = 0;

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    PromptGenerator prompter = new PromptGenerator();
                    string prompt = prompter.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write(" > ");
                    string response = Console.ReadLine();

                    Entry entry = new Entry();
                    entry._prompt = prompt;
                    entry._response = response;
                    string dateText = DateTime.Now.ToString("MM/dd/yyyy");
                    entry._date = dateText;

                    theJournal.AddEntry(entry);
                    break;

                case 2:
                    theJournal.DisplayAll();
                    Console.WriteLine($"Time between first and most recent entry: {theJournal.GetDaysElapsed()}");
                    break;

                case 3:
                    theJournal._entries.Clear();
                    Console.WriteLine("What is the filename?");
                    string loadFileName = Console.ReadLine();
                    theJournal.LoadFromFile(loadFileName);
                    break;

                case 4:
                    Console.WriteLine("What is the filename?");
                    string saveFileName = Console.ReadLine();
                    theJournal.SaveToFile(saveFileName);
                    break;

                case 5:
                    break;

                default:
                    Console.WriteLine("I'm sorry, your selection is not recognized. Please try again.");
                    break;
            }
        } while (selection != 5);
    }
}