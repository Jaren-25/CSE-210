public class Order
{
    private string _packingLabel;
    private string _shippingLabel;
    private double _shippingPrice;
    private double _totalPrice;
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

     public double CalcCountryPrice()
    {
        if(_customer.isUSA() == true)
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
        CalcCountryPrice();
        foreach(Product product in _products)
        {
            _totalPrice += product.GetProductPrice();
        }
        return _totalPrice + _shippingPrice;
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
        foreach(Product product in _products)
        {
            Console.WriteLine($"{product.GetName()} : {product.GetId()}");
        }
        Console.WriteLine($"{GetShippingLabel()}\n{GetTotalPrice()}\n\n");
    }
}