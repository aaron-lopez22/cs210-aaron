class Order
{
    Customer _customer;

    List<Product> _product = new List<Product>();

    int _totalCost;


    public Order(Customer customer)
    {

        _customer = customer;
    }



    public List<Product> GetProduct()
    {
        return _product;
    }

    public void GetTotalPrice()
    {
        _totalCost = 0;
        foreach (Product product in _product)
        {
            _totalCost = _totalCost + product.GetProductPrice();

        }

        Console.WriteLine(_totalCost);

    }

    public void PackingLabel()
    {
        Console.WriteLine($"Customer Information");
        Console.WriteLine();
        _customer.Display();
        Console.WriteLine();
        Console.WriteLine("Down Below Will be Order Details: ");
        foreach (Product product in _product)
        {
            Console.WriteLine($"Order ID: {product.GetProductID()}, Order Name: {product.GetName()}, Order Price: {product.GetPrice()}, Order Quatity: {product.GetQuantity()}");

        }

        Console.Write("The total price for the order is: $");
        GetTotalPrice();
        Console.WriteLine();
    }

    public void ShippingLabel()
    {
        Console.WriteLine("Ship From Company Name:");
        Console.WriteLine("555 w. 1254 s");
        Console.WriteLine("Sandy, Utah");
        Console.WriteLine("Suite Number 300");
        Console.WriteLine();
        Console.WriteLine($"This package will ship to:");
        _customer.Display();
        Console.WriteLine();
    }


}

