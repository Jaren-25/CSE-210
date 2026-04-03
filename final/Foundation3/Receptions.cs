public class Receptions : Event
{
    private string _rsvpEmail;

    public Receptions(string rsvpEmail, string title, string description, string date, string time, string type, Address address ) : base(title, description, date, time, type, address)
    {
        _rsvpEmail = rsvpEmail;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _type = type;
        _address = address;
    }

    public override void FullDisplay()
    {
        Console.WriteLine($"Full:\n({_type}) {_title} - {_description} on {_date} at {_time} \n{_address.GetAddress()}\nRSVP at {_rsvpEmail}");
    }
}