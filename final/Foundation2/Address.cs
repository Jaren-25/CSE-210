public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private bool _isUSA;


    public Address(string street, string city, string state, string country)
    {
            _street = street;
            _city = city;
            _state = state;
            _country = country;
    }

    public string GetCountry()
    {
        return _country;
    }

    public bool isUSA()
    {
        if(_country == "USA")
        {
            _isUSA = true;
            Console.WriteLine(true);
            return _isUSA;
        }
        else
        {
            Console.WriteLine(false);
            _isUSA = false;
            return _isUSA;
        }
    }

    public string GetAddress()
    {
        return $"{_street}\n{_city} {_state}\n{_country}";
    }

}