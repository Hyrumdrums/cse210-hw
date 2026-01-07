using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Magic Number Game!!");
        bool keepPlaying = true;
        Thread.Sleep(1000);
        while (keepPlaying)
        {
          // Intro, paced to seem like thinking
            Console.WriteLine("I'm thinking of a number between 1 and 100...");
            Thread.Sleep(2000);
            Console.WriteLine("Got it! Can you guess what it is?");
            
            // Generate magic number
            Random random = new Random();
            int magicNumber = random.Next(1, 101); // Generates a number between 1 and 100
            int userGuess = 0;
            int guessCount = 0;
            while (userGuess != magicNumber)
            {
                Console.Write("Enter your guess (1-100): ");
                string input = Console.ReadLine();
                userGuess = int.Parse(input);
                guessCount++;
                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You've guessed the magic number!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }
            // reset count
            guessCount = 0;
            // determine if player wants to play again
            Console.Write("Do you want to play again? (y/n): ");
            string playAgainInput = Console.ReadLine().ToLower();
            if (playAgainInput != "y")
            {
                keepPlaying = false;
                Console.WriteLine("Thanks for playing! Ciao!");
            }
        }
    }
}