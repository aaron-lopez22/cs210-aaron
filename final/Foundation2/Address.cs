class Address
{
    private string _streetAddress, _city, _state, _country;
    
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public void SetStreet(string streetAddress)
    {
        _streetAddress = streetAddress;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    public string GetStreet()
    {
        return _streetAddress;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _state;
    }

    public string GetCountry()
    {
        return _country;
    }

    public bool isInUSA()
    {
        if (_country.ToLower() == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public void GetAddress()
    {
        Console.WriteLine($"{_streetAddress}");
        Console.WriteLine($"{_city}, {_state}");
        Console.WriteLine($"{_country.ToUpper()}");
    }

}