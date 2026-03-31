public class Product
{
    private string _id;
    private string _productName;
    private double _ppu;
    private int _quantity;

    public Product(string id, string name, double ppu, int quantity)
    {
        _id = id;
        _productName = name;
        _ppu = ppu;
        _quantity = quantity;
    }

    public double GetProductPrice()
    {
        return _ppu * _quantity;
    }

    public string GetId()
    {
        return _id;
    }

    public string GetName()
    {
        return _productName;
    }

}