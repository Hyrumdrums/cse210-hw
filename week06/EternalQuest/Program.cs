using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        GoalManager goalManager = new GoalManager();
        bool quit = false;

        while (!quit)
        {
            goalManager.DisplayPoints();
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            Console.Clear();

            if (choice == "1")
            {
                goalManager.createGoal();
                Console.Clear();
            }
            else if (choice == "2")
            {
                goalManager.displayGoalDetails();
            }
            else if (choice == "3")
            {
                goalManager.saveGoals();
            }
            else if (choice == "4")
            {
                goalManager.loadGoals();
            }
            else if (choice == "5")
            {
                goalManager.recordEvent();
            }
            else if (choice == "6")
            {
                quit = true;
            }
            Console.WriteLine();
        }
    }
}