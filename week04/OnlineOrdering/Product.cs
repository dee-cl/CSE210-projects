public class Product
{
    private string _name;
    private string _id;
    private int _quant;
    private int _price;

    public int TotalCost
    {
        get
        { 
            return _quant * _price; 
        }
    }
}