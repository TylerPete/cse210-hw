// Purpose: Demonstrate abstraction in practice by writing a program to help
//      the user record the events of their day by supplying prompts and storing
//      their responses along with the question and a date.
// Author: Tyler Peterson
// Exceeding requirements: TBD

using System;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.IO;
using System.IO.Enumeration;

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
                    string dateText = DateTime.Now.ToShortDateString();
                    entry._date = dateText;

                    theJournal.AddEntry(entry);
                    break;

                case 2:
                    theJournal.DisplayAll();
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