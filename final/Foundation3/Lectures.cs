public class Lectures : Event
{
    private string _speaker;
    private string _capacity;


    public Lectures(string speaker, string capacity, string title, string description, string date, string time, string type, Address address) : base(title, description, date, time, type, address)
    {
        _speaker =  speaker;
        _capacity = capacity;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _type = type;
        _address = address;
    }

    public override void FullDisplay()
    {
        Console.WriteLine($"Full:\n({_type}) {_title} - {_description} by {_speaker} with only {_capacity} seats. On {_date} at {_time} \n{_address.GetAddress()}");
    }


}