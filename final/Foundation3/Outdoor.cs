public class Outdoor : Event
{
    private bool _weather;

    public Outdoor(bool weather, string title, string description, string date, string time, string type, Address address) : base(title, description, date, time, type, address)
    {
        _weather = weather;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _type = type;
        _address = address;
    }

    public override void FullDisplay()
    {
        if(_weather == true)
        {
            Console.WriteLine($"Full:\n({_type}) {_title} - {_description} on {_date} at {_time} \n{_address.GetAddress()} \nThe weather looks promising");
        }
        else
        {
            Console.WriteLine($"Full:\n({_type}) {_title} - {_description} on {_date} at {_time} \n{_address.GetAddress()} \nWe are hesitant about the weather");
        }
    }
}