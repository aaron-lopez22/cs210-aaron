public class Reception : Event
{

    Address _address;
    private string _rsvp;

   public Reception(string title, string description, string date, string time, Address address, string rsvp) : base(title, description, date, time)
   {
    _address = address;
    _rsvp = rsvp;
   }

   public string GetRsvp()
   {
     return _rsvp;
   }


          public void DisplayStandard()
    {
        string title = GetTitle();
        string description = GetDescription();
        string time = GetTime();
        string date = GetDate();
        Console.WriteLine($"Name of Reception event {title}, Description {description}, The date of the event is {date} Time of Event {time}");
        _address.GetAddress();
    }

    public void ShortDescription()
    {
        Console.WriteLine($"This event is a Receptions Event. The name of the event is {GetTitle()} and the Date for the event is {GetDate()}");
    }

    public void FullDetails()
    {
        string title = GetTitle();
        string description = GetDescription();
        string time = GetTime();
        Console.WriteLine($"Name of Reception {title}, Description {description}, Time of Event {time}");
        _address.GetAddress();
        Console.WriteLine($"Will you be attending the event? {_rsvp}");

    }

}