using System.Text.Json.Serialization;

public class ChecklistGoal : Goal
{
    [JsonInclude]
    private int _amountCompleted;
    [JsonInclude]
    private int _target;
    [JsonInclude]
    private int _bonus;

    // required for json deserialization
    public ChecklistGoal()
    {
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return (_amountCompleted >= _target);
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override int GetPoints()
    {
        if (IsComplete())
        {
            return _points * _amountCompleted + _bonus;
        }
        else
        {
            return _points * _amountCompleted;
        }
    }
}