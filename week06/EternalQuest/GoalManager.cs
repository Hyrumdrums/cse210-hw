using System.Text.Json;
using System.Text.Json.Serialization;

public class GoalManager
{
    [JsonInclude]
    private List<Goal> _goals;

    public GoalManager()
    {
        _goals = new List<Goal>();
    }

    public void DisplayPoints()
    {
        int score = 0;
        foreach (Goal goal in _goals)
        {
            score += goal.GetPoints();
        }
        Console.WriteLine($"You have {score} points.");
    }

    public void displayGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals yet.");
            return;
        }
        else
        {
            Console.WriteLine("Your goals:");
        }
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void createGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void recordEvent()
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            int index = i + 1;
            Console.WriteLine($"{index}. {_goals[i].GetNameAndDescription()}");
        }
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        Goal goal = _goals[choice - 1];
        goal.RecordEvent();
    }

    public void saveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        var options = new JsonSerializerOptions { WriteIndented = true, IncludeFields = true };
        string json = JsonSerializer.Serialize(this, options);
        File.WriteAllText(fileName, json);
    }

    public void loadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string json = File.ReadAllText(fileName);
        var options = new JsonSerializerOptions { WriteIndented = true, IncludeFields = true };
        GoalManager loadedGoalManager = JsonSerializer.Deserialize<GoalManager>(json, options);

        _goals = loadedGoalManager._goals;

        Console.WriteLine("Goals loaded successfully.");
    }
}