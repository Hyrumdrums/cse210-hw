using System.Text.Json.Serialization;

public class SimpleGoal : Goal
{
    [JsonInclude]
    private bool _isComplete;

    // required for json deserialization
    public SimpleGoal()
    {
    }

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override int GetPoints()
    {
        if (IsComplete())
        {
            return _points;
        }
        else
        {
            return 0;
        }
    }
}