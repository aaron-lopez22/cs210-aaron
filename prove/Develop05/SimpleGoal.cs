class SimpleGoal : Goal
{

    private bool _status = false;

    public SimpleGoal(string shortname, string description, int points, bool status) : base (shortname, description, points) 
    {
        _shortname = shortname;
        _description = description;
        _status = status;
    }
    

   
     public void SimpleGoalDisplay()
    {
        
        Console.WriteLine($"[] {_shortname} ({_description})");
    }


 


}
