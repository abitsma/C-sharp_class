public abstract class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string desc, string date, string time, Address addy)
    {
        _title = title;
        _description = desc;
        _date = date;
        _time = time;
        _address = addy;
    }

    public string StandardDetails()
    {
        string addy = _address.FullAddress();
        return $"You won't want to miss: {_title}, on {_date}!\nIt's {_description}.\nWant to come? It's being held at {addy} at {_time}!\nSee you there!";
    }

    public abstract string FullDetails();

    public abstract string ShortDescription();
}