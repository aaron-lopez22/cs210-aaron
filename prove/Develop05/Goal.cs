 class Goal
{
    public string _shortname;
    public string _description;

    private int _points;

    public Goal(string shortname, string description, int points)
    {
        _shortname = shortname;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortname;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetName(string name)
    {
        _shortname = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void Setpoints(int points)
    {
        _points = points;
    }

    public int Getpoints()
    {
        return _points;
    }
  
     public void Display()
    {
        
        Console.WriteLine($"[] {_shortname} ({_description})");
    }



}