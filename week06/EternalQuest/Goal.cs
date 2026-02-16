using System.Text.Json;
using System.Text.Json.Serialization;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(SimpleGoal), "simple")]
[JsonDerivedType(typeof(EternalGoal), "eternal")]
[JsonDerivedType(typeof(ChecklistGoal), "checklist")]
public class Goal
{
    [JsonInclude]
    protected string _shortName;
    [JsonInclude]
    protected string _description;
    [JsonInclude]
    protected int _points;

    // required for json deserialization
    public Goal()
    {
    }

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public string GetNameAndDescription()
    {
        return $"{_shortName}: {_description}";
    }

    public virtual string GetDetailsString()
    {
        string complete = IsComplete() ? "[X]" : "[ ]";
        return $"{complete} {_shortName}: {_description} ({_points} points)";
    }

    public string ToJson()
    {
        return JsonSerializer.Serialize(this);
    }

    public virtual int GetPoints()
    {
        return 0;
    }

}