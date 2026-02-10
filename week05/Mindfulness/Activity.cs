public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;

    private DateTime _start;

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long would you like to do this activity(seconds)? ");
        _duration = int.Parse(Console.ReadLine());
        _start = DateTime.Now;
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine("Good Job!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_activityName}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(333);
            Console.Write(".");
            Thread.Sleep(333);
            Console.Write(".");
            Thread.Sleep(333);
            Console.Write("\b\b\b   \b\b\b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public bool isTimeUp()
    {
        return (DateTime.Now - _start).TotalSeconds >= _duration;
    }
}
