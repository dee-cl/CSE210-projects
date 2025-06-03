public class Customer
{
    private string _customerName;
    private string _address;
    private bool InCountry;

    public bool InUSA
    {
        get
        {
            if (InCountry == true)
            {
                return true;
            }
            return false;
        }
    }

}