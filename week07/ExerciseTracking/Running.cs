public class Running : Activity
{
    private float _distanceInMiles;

    public Running(DateTime date, int lengthInMinutes, float distanceInMiles) : base(date, lengthInMinutes)
    {
        _distanceInMiles = distanceInMiles;
    }

    public override float GetDistance()
    {
        return _distanceInMiles;
    }

    public override float GetSpeed()
    {
        return (_distanceInMiles / _lengthInMinutes) * 60f;
    }

    public override float GetPace()
    {
        return _lengthInMinutes / _distanceInMiles;
    }
}