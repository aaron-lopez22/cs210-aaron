class Product
{
    private string _name, _productID;

    private int _price, _quantity;


    public Product(string name,string productID, int price, int quantity)
    {
         _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;

    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetProductID(string productID)
    {
        _productID = productID;
    }

    public void SetPrice(int price)
    {
        _price = price;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public int GetPrice()
    {
        return _price;
    }

    public int GetProductPrice()
    {
        return _price * _quantity;
    }


}

