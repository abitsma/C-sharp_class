public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, int minutes, double laps) : base(date, minutes)
    {
        _laps = laps;
        _activityType = "Swimming";
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        double pace = GetPace();
        return 60 / pace;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return _minutes / distance;
    }
}