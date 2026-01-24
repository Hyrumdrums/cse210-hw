using System;

class Program
{
    private const int WORDS_TO_HIDE = 3;
    static void Main(string[] args)
    {
        Reference reference = new Reference("D&C", 131, 43);
        Scripture scripture = new Scripture(reference, "Reproving betimes with sharpness, when moved upon by the Holy Ghost; and then showing forth afterwards an increase of love toward him whom thou hast reproved, lest he esteem thee to be his enemy;");
        // clear screen
        Console.Clear();
        bool exit = false;
        while (!exit)
        {
          Console.WriteLine(scripture.GetDisplayText());
          Console.WriteLine();
          Console.WriteLine("Press Enter to hide words.");
          Console.WriteLine("Type 'quit' to exit.");
          string input = Console.ReadLine();
          exit = input.ToLower() == "quit";
          // no need to check exit, always hide words, if quitting it doesn't matter
          scripture.HideRandomWords(WORDS_TO_HIDE);
          Console.Clear();
        }
    }
}