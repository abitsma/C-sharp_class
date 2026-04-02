public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string desc, string date, string time, Address addy, string speaker, int capacity) : base(title, desc, date, time, addy)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        string addy = _address.FullAddress();
        return $"{_speaker} is going to give an awesome lecture on {_date}.\nIt's {_description}, entitled: {_title}.\nThis event will take place at {addy} at {_time}.\nMake sure to get in early! We only have the ability to seat {_capacity} people.\nSee you there!";
    }

    public override string ShortDescription()
    {
        return $"Come see: {_title}, a lecture on {_date}";
    }
}