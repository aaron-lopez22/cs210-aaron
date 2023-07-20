public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;

    public Event(string title, string description, string date, string time)
    {
        _time = time;
        _date = date;
        _description = description;
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetTime()
    {
        return _title;
    }

    public string GetDate()
    {
        return _date;
    }

    public void StandardDetails()
    {
       

    }



}