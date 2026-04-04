public class Outdoor : Event
{
    private bool _weather;

    public Outdoor(bool weather, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _weather = weather;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public override void FullDisplay()
    {
        if(_weather == true)
        {
            Console.WriteLine($"Full:\n({GetType()}) {_title} - {_description} on {_date} at {_time} \n{_address.GetAddress()} \nThe weather looks promising");
        }
        else
        {
            Console.WriteLine($"Full:\n({GetType()}) {_title} - {_description} on {_date} at {_time} \n{_address.GetAddress()} \nWe are hesitant about the lack of tornados");
        }
    }
}