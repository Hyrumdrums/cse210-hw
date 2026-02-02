public class WritingAssignment : Assignment
{
    private string _topic;
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, "Writing")
    {
        _topic = topic;
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}