public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public bool InCountry()
    {
        if (_country.ToLower() == "usa" || _country.ToLower() == "united states of america")
        {
            return true;
        }
        return false;
    }
}