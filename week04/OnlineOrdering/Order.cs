using System.Runtime.CompilerServices;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;    
    }
    public double GetOrderCost()
    {
        double total = 0;
        double shippingCost = 0;
        if (_customer.InUSA == true)
            {shippingCost = 5;}
        if (_customer.InUSA == false)
            {shippingCost = 35;}
        foreach (Product product in _products)
            {
                total += product.GetCost();
            }
        return total + shippingCost;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public string MakePackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += product.ShippingName() + "\n";
        }
        return packingLabel;
    }
    public string MakeShippingLabel()
    {
        string name = _customer.CustomerName;
        string address = _customer.Address.GetAddress();
        string shippingLabel = $"{name}\n{address}";
        return shippingLabel;
    }

}