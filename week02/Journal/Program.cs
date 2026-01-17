using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool exit = false;
        while (!exit)
        {
            DisplayMenu();
            string choice = Console.ReadLine().ToUpper();
            switch (choice)
            {
                case "N":
                case "1":
                    string prompt = PromptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write(">");
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response);
                    break;
                case "D":
                case "2":
                    journal.DisplayAllEntries();
                    break;
                case "L":
                case "3":
                    Console.WriteLine("Enter filename to load from:");
                    Console.Write(">");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
                case "S":
                case "4":
                    Console.WriteLine("Enter filename to save to:");
                    Console.Write(">");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;
                case "Q":
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Please enter a valid choice.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. [N] Write a new journal entry");
        Console.WriteLine("2. [D] Display all journal entries");
        Console.WriteLine("3. [L] Load journal entries from a file");
        Console.WriteLine("4. [S] Save journal entries to a file");
        Console.WriteLine("5. [Q] Quit");
        Console.Write(">");
    }
}