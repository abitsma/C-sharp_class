public abstract class Activity
{
    protected string _date;
    protected int _minutes;
    protected string _activityType;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public void GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        Console.WriteLine($"{_date} {_activityType} ({_minutes} min)\nDistance: {distance} miles\nSpeed: {speed} mph\nPace: {pace} min per mile\n\n");
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
}