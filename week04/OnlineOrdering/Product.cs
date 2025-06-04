public class Product
{
    private string _name;
    private string _id;
    private double _quant;
    private double _price;
    public string Name
    {
        get { return _name;}
        set { _name = value;}
    }
    public string Id
    {
        get { return _id;}
        set { _id = value;}
    }
    public double Price
    {
        get { return _price;}
        set { _price = value;}
    }
    public double Quantity
    {
        get { return _quant;}
        set { _quant = value;}
    }
    public double GetCost()
    {
        return _quant * _price;
    }
    public string ShippingName()
    {
        return $"{_name} | {_id}";
    }
}