using System.Runtime.Intrinsics.X86;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string activityName, string description) : base(activityName, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.Write("Get ready");
        ShowSpinner(3);
        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(3);
        Console.WriteLine();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        // remove it from list
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string question = _questions[index];
        _questions.RemoveAt(index);
        return question;
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(" --- " + prompt + " ---");
    }

    public void DisplayQuestions()
    {
        while (!isTimeUp())
        {
            string question = GetRandomQuestion();
            Console.WriteLine("> " + question + " ");
            ShowSpinner(7);
        }
    }

}