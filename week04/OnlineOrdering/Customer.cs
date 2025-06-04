    public class Customer
{
    private string _customerName;
    private Address _address;
    public string CustomerName
    {
        get { return _customerName; }
        set { _customerName = value; }
    }

    public Address Address
    {
        get { return _address; }
    }
    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool InUSA
    {
        get {return _address.InCountry();}
    }

}