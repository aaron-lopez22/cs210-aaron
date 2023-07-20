public class Lectures : Event
{
    private int _capacity;

    private string _speaker;

    Address _address;

    public Lectures(string title, string description, string date, string time, int capacity, string speaker, Address address) : base(title, description, date, time)
    {
        _capacity = capacity;
        _speaker = speaker;
        _address = address;
    }
    
    public int GetCapacity()
    {
        return _capacity;
    }
    

    public string GetSpeaker()
    {
        return _speaker;
    }

       public void DisplayStandard()
    {
        string title = GetTitle();
        string description = GetDescription();
        string time = GetTime();
        string date = GetDate();
        Console.WriteLine($"Name of Lecture event {title}, Description {description}, The date of the event is {date} Time of Event {time}");
        Console.WriteLine();
        _address.GetAddress();
        Console.WriteLine();
    }

    public void ShortDescription()
    {
        Console.WriteLine($"This event is a Lecture Event. The name of the event is {GetTitle()} and the Date for the event is {GetDate()}");
    }

       public void FullDetails()
    {
        string title = GetTitle();
        string description = GetDescription();
        string time = GetTime();
        Console.WriteLine($"Name of Lecture Event {title}, {description}, Time of Event {time}");
        _address.GetAddress();
        Console.WriteLine($"The Speakder for this event will be {_speaker} and the Capacity will be {_capacity}");

    }


}