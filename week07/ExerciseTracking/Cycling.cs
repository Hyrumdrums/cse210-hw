public class Cycling : Activity
{
    private float _speedInMph;

    public Cycling(DateTime date, int lengthInMinutes, float speedInMph) : base(date, lengthInMinutes)
    {
        _speedInMph = speedInMph;
    }

    public override float GetDistance()
    {
        return (_speedInMph * _lengthInMinutes) / 60f;
    }

    public override float GetSpeed()
    {
        return _speedInMph;
    }

    public override float GetPace()
    {
        return 60f / _speedInMph;
    }
}