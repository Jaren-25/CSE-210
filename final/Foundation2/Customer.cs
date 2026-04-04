public class Customer
{
    private string _name;
    private Address _address;


    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }

    public bool isUSA()
    {
        return _address.isUSA();
    }

    public string GetName()
    {
        return _name;
    }

}