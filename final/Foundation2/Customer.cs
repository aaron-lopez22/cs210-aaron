class Customer
{
    private string _name;

    
    Address _address;

    public Customer(string name,Address address)
    {
         _name = name;
        _address = address;
    }


    public void SetName(string name)
    {
        _name = name;
    }


    public string GetName()
    {
        return _name;
    }


    public void Display()
    {
        Console.WriteLine(_name);
       _address.GetAddress();
      
    }





}