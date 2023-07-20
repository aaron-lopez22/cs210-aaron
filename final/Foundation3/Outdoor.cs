public class Outdoor : Event
{
    private string _weatherforcast;
    
    Address _address;

    public Outdoor(string title, string description, string date, string time, string weatherforcast, Address address) : base (title, description, date, time)
    {
        _weatherforcast = weatherforcast;
        _address = address;
    }

    public string GetWeather()
    {
        return _weatherforcast;
    }

         public void DisplayStandard()
    {
        string title = GetTitle();
        string description = GetDescription();
        string time = GetTime();
        string date = GetDate();
        Console.WriteLine($"Name of Outdoor event {title}, Description {description}, The date of the event is {date} Time of Event {time}");
        _address.GetAddress();
    }

    public void ShortDescription()
    {
        Console.WriteLine($"This event is a Outdoor Event. The name of the event is {GetTitle()} and the Date for the event is {GetDate()}");
    }

       public void FullDetails()
    {
        string title = GetTitle();
        string description = GetDescription();
        string time = GetTime();
        Console.WriteLine($"Name of Outdoor Event {title}, Description {description}, Time of Event {time}");
        _address.GetAddress();
        Console.WriteLine($"The weather forcast for this event will be {_weatherforcast}");

    }
}