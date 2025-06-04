public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public string StreetAddress
    {
        get { return _streetAddress; }
        set { _streetAddress = value; }
    }
    public string City
    {
        get { return _city; }
        set { _city = value; }
    }
    public string State
    {
        get { return _state; }
        set { _state = value; }
    }
    public string Country
    {
        get { return _country; }
        set { _country = value; }
    }
    public bool InCountry()
    {
        if (_country.ToLower() == "usa" || _country.ToLower() == "united states of america")
        {
            return true;
        }
        return false;
    }
    public string GetAddress()
        {
        return $"{_streetAddress}, {_city}, \n{_state}, {_country}";
        }
    
}