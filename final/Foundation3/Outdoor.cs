public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string desc, string date, string time, Address addy, string weather) : base(title, desc, date, time, addy)
    {
        _weather = weather;
    }

    public override string FullDetails()
    {
        string addy = _address.FullAddress();
        return $"Come experience: {_title}, and outdoor event on {_date}.\nIt's {_description}.\nYou can expect the weather to be {_weather}.\nIt will take place at {addy} at {_time}.";
    }

    public override string ShortDescription()
    {
        return $"Come to: {_title}, an outdoor event on {_date}.";
    }
}