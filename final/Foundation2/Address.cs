public class Address
{
    private string _street;
    private string _city;
    private string _stateOrOther;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _stateOrOther = state;
        _country = country;
    }

    public void SetAddress(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _stateOrOther = state;
        _country = country;
    }

    public bool GetUS()
    {
        if (_country == "USA" || _country == "US" || _country == "United States of America")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string FullAddress()
    {
        string addy = $"{_street}\n{_city}\n{_stateOrOther}\n{_country}";
        return addy;
    }
}