using System;

class Program
{
    static void Main(string[] args)
    {
        // We use Console.Write to prompt the user for input, so the answer appears on the same line.
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}