public class Bicycle : Activity
{
    private double _speed;

    public Bicycle(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
        _activityType = "Bicycle";
    }

    public override double GetDistance()
    {
        return _speed * _minutes / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}