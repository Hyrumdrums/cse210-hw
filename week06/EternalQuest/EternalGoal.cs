using System.Text.Json.Serialization;

public class EternalGoal : Goal
{

    [JsonInclude]
    private int _amountCompleted;

    // required for json deserialization
    public EternalGoal()
    {
    }

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} -- completed: {_amountCompleted} times";
    }

    public override int GetPoints()
    {
        return _amountCompleted * _points;
    }
}