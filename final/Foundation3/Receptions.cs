public class Receptions : Event
{
    private string _rsvpEmail;

    public Receptions(string rsvpEmail, string title, string description, string date, string time, Address address ) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public override void FullDisplay()
    {
        Console.WriteLine($"Full:\n({GetType()}) {_title} - {_description} on {_date} at {_time} \n{_address.GetAddress()}\nRSVP at {_rsvpEmail}");
    }
}