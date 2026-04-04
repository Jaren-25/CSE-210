public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _type;
    protected Address _address;

    public Event(string title, string description, string date, string time,string type, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _type = type;
        _address = address;
    }

    public void StandardDisplay()
    {
        Console.WriteLine($"Standard:\n{_title} - {_description} on {_date} at {_time} \n{_address.GetAddress()}");
    }

    public virtual void FullDisplay()
    {
        Console.WriteLine($"Full:\n({GetType()}) {_title} - {_description} on {_date}  at {_time} \n{_address.GetAddress()} (name & capacity/rsvp email/weather)");
    }

    public void ShortDisplay()
    {
        Console.WriteLine($"Short:\n{GetType()} {_title} on {_date}");
    }
}