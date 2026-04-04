public class Order
{
    private string _packingLabel;
    private string _shippingLabel;
    private double _shippingPrice;
    private double _totalPrice;
    private List<Product> _products = new List<Product>();

    public Order()
    {

    }

     public double CalcCountryPrice(string country)
    {
        if(country == "USA")
        {
            _shippingPrice = 5;
            return _shippingPrice;
        }
        else
        {
            return _shippingPrice = 35;
        }
    }

    public void AddProduct(Product product)
    {
        _products.AddRange(product);
    }

    public double GetTotalPrice()
    {
        foreach(Product product in _products)
        {
            _totalPrice += product.GetProductPrice();
        }
        return _totalPrice + _shippingPrice;
    }

    public string PackingLabel()
    {
        foreach(Product product in _products)
        {
            return $"{product.GetName()} : {product.GetId()}";
        }
        return null;
    }

    public void SetPackingLabel(string name, string id)
    {
        foreach(Product product in _products)
        {
            _packingLabel = $"{product.GetName()} : {product.GetId()}";
        }
    }

    public string GetShippingLabel()
    {
        return _shippingLabel;
    }

    public void SetShippingLabel(string name, string address)
    {
        _shippingLabel = $"{name} \n{address}";
    }

    public void Display()
    {
        Console.WriteLine($"{PackingLabel()}\n{GetShippingLabel()}\n{GetTotalPrice()}\n\n");
    }
}