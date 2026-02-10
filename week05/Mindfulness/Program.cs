// Dallin Layton - Feb 10, 2026
// My creative addition was to measure the total time
// the user spent in the program and display it on exit
using System;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Project.");
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        while (!exit)
        {
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.Write("Enter the number of your choice or 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                exit = true;
            }
            else if (input == "1")
            {
                BreathingActivity breathingActivity =
                  new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingActivity.Run();
            }
            else if (input == "2")
            {
                ReflectingActivity reflectingActivity =
                  new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflectingActivity.Run();
            }
            else if (input == "3")
            {
                ListingActivity listingActivity =
                  new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.Run();
            }
            Console.Clear();
        }
        DateTime endTime = DateTime.Now;
        TimeSpan totalTime = endTime - startTime;
        Console.WriteLine($"Thank you! You spent a total of {Math.Round(totalTime.TotalSeconds)} seconds doing activities. Goodbye!");
    }
}