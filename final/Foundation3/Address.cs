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

    public string FullAddress()
    {
        string addy = $"{_street}, {_city}, {_stateOrOther}, {_country}";
        return addy;
    }
}