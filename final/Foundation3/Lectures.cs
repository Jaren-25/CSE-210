public class Lectures : Event
{
    private string _speaker;
    private string _capacity;


    public Lectures(string speaker, string capacity, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _speaker =  speaker;
        _capacity = capacity;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public override void FullDisplay()
    {
        Console.WriteLine($"Full:\n({GetType()}) {_title} - {_description} by {_speaker} with only {_capacity} seats. On {_date} at {_time} \n{_address.GetAddress()}");
    }


}