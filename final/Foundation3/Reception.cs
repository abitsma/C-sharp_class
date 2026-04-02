using System.Net.Sockets;

public class Reception : Event
{
    private string _emailRSVP;

    public Reception(string title, string desc, string date, string time, Address addy, string email) : base(title, desc, date, time, addy)
    {
        _emailRSVP = email;
    }

    public override string FullDetails()
    {
        string addy = _address.FullAddress();
        return $"{_title}, a beautiful reception happening on {_date}.\nWe hope you are able to come to {addy} at {_time}.\nIt's {_description}.\nWe ask for those attending to RSVP at {_emailRSVP}.";
    }

    public override string ShortDescription()
    {
        return $"{_title}, a reception on {_date}.";
    }
}