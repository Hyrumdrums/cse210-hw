using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities = new List<Activity>();
        Running run = new Running(new DateTime(2026, 1, 1), 30, 3.0f);
        Cycling cycle = new Cycling(new DateTime(2026, 2, 2), 60, 15.0f);
        Swimming swim = new Swimming(new DateTime(2026, 3, 3), 45, 45);

        activities.Add(run);
        activities.Add(cycle);
        activities.Add(swim);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}