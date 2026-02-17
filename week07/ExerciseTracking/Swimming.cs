public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int lengthInMinutes, int laps) : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return _laps * 50 / 1000 * 0.62f;
    }

    public override float GetSpeed()
    {
        return (GetDistance() / _lengthInMinutes) * 60f;
    }

    public override float GetPace()
    {
        return _lengthInMinutes / GetDistance();
    }
}