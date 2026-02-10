public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description) : base(activityName, description)
    {
      
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready");
        ShowSpinner(3);
        while (!isTimeUp())
        {
          Console.Clear();
          Console.Write("Breathe in ... ");
          ShowCountDown(4);
          Console.WriteLine();
          Console.WriteLine();
          Console.Write("Breathe out ... ");
          ShowCountDown(4);
        }
        DisplayEndingMessage();
    }
}