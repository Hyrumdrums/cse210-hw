public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string activityName, string description) : base(activityName, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        ShowCountDown(5);
        Console.WriteLine("List as many responses as you can, pressing enter after each one:");
        int count = 0;
        while (!isTimeUp())
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine();
        Console.WriteLine($"You listed {count} items!");
        Console.WriteLine();
        DisplayEndingMessage();
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        Console.WriteLine("Enter your items one by one hitting 'Enter'. Type 'done' when you are finished:");
        string input = "";
        while (input != "done")
        {
            input = Console.ReadLine();
            if (input != "done")
            {
                items.Add(input);
            }
        }
        return items;
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        _prompts.RemoveAt(index);
        return prompt;
    }

}