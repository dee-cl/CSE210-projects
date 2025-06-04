using System;

class Program
{
    static void Main()
    {
        Address davesAddress = new Address();
        Customer customer1 = new Customer("Dave Lopez", davesAddress);
        Order daveorder1 = new Order(customer1);
        davesAddress.StreetAddress = "111 Test st";
        davesAddress.City = "Idaho Falls";
        davesAddress.State = "Idaho";
        davesAddress.Country = "USA";
        Product davesproduct1 = new Product();
        davesproduct1.Name = "Potato";
        davesproduct1.Id = "907470";
        davesproduct1.Price = .75;
        davesproduct1.Quantity = 5;
        daveorder1.AddProduct(davesproduct1);
        Product davesproduct2 = new Product();
        davesproduct2.Name = "Lemon";
        davesproduct2.Id = "73304";
        davesproduct2.Price = .67;
        davesproduct2.Quantity = 8;
        daveorder1.AddProduct(davesproduct2);
        Product davesproduct3 = new Product();
        davesproduct3.Name = "3.06 x20 pack";
        davesproduct3.Id = "64412";
        davesproduct3.Price = 25.99;
        davesproduct3.Quantity = 2;
        daveorder1.AddProduct(davesproduct3);
        string dpackingLabel = daveorder1.MakePackingLabel();
        string dshippingLabel = daveorder1.MakeShippingLabel();
        double dtotalCost = daveorder1.GetOrderCost();

        Console.WriteLine($"packing label: \n{dpackingLabel}\nshipping label: \n{dshippingLabel}\n\ntotal: ${dtotalCost}\n\n");

        Address jamesAddress = new Address();
        Customer customer2 = new Customer("James Roundabout", jamesAddress);
        Order jamesorder1 = new Order(customer2);
        jamesAddress.StreetAddress = "309 Super circle";
        jamesAddress.City = "Toronto";
        jamesAddress.State = "Ontario";
        jamesAddress.Country = "Canada";
        Product jamesproduct1 = new Product();
        jamesproduct1.Name = "Potato";
        jamesproduct1.Id = "907470";
        jamesproduct1.Price = 3;
        jamesproduct1.Quantity = 5;
        jamesorder1.AddProduct(jamesproduct1);
        Product jamesproduct2 = new Product();
        jamesproduct2.Name = "Lemon";
        jamesproduct2.Id = "73304";
        jamesproduct2.Price = 1.33;
        jamesproduct2.Quantity = 8;
        jamesorder1.AddProduct(jamesproduct2);
        Product jamesproduct3 = new Product();
        jamesproduct3.Name = "600 airsoft pellets";
        jamesproduct3.Id = "64412";
        jamesproduct3.Price = 47.67;
        jamesproduct3.Quantity = 2;
        jamesorder1.AddProduct(jamesproduct3);
        string jpackingLabel = jamesorder1.MakePackingLabel();
        string jshippingLabel = jamesorder1.MakeShippingLabel();
        double jtotalCost = jamesorder1.GetOrderCost();

        Console.WriteLine($"packing label: \n{jpackingLabel}\nshipping label: \n{jshippingLabel}\n\ntotal: ${jtotalCost}");
    }
}