using System;

class Program
{
    private const int WORDS_TO_HIDE = 3;
    static void Main(string[] args)
    {
        Reference reference = new Reference("D&C", 131, 43);
        Scripture scripture = new Scripture(reference, "Reproving betimes with sharpness, when moved upon by the Holy Ghost; and then showing forth afterwards an increase of love toward him whom thou hast reproved, lest he esteem thee to be his enemy;");
        bool exit = false;
        while (!exit)
        {
          // clear screen
          Console.Clear();
          Console.WriteLine(scripture.GetDisplayText());
          Console.WriteLine();
          Console.WriteLine("Press Enter to hide words.");
          Console.WriteLine("Type 'less' to show a hidden word.");
          Console.WriteLine("Type 'quit' to exit.");
          string input = Console.ReadLine();
          switch (input.ToLower())
          {
            case "quit":
              exit = true;
              continue;
            case "":
              scripture.HideRandomWords(WORDS_TO_HIDE);
              continue;
            case "less":
              scripture.UnHideRandomWord();
              continue;
            default:
              break;
          }
        }
    }
}