class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();
        Product product = new Product("123-A", "Pizza", 8.99, 3);
        Product product1 = new Product("123-B", "Cutting Board", 21.39, 2);

        order.AddProduct(product);
        order.AddProduct(product1);

        Address address = new Address("Main St.","Rexburg", "Idaho", "USA");
        Customer customer = new Customer("Bob Bobberson", address);

        order.SetPackingLabel(product.GetName(), product.GetId());
        order.SetShippingLabel(customer.GetName(), address.GetAddress());
        order.CalcCountryPrice(address.GetCountry());


        order.Display();

        Order order1 = new Order();
        Product product2 = new Product("234-A", "Pencil", 5.00, 3);
        Product product3 = new Product("235-B", "Pen", 6.99, 2);
        Product product4 = new Product("236-C", "Frying Pan", 20.57, 1);

        order1.AddProduct(product2);
        order1.AddProduct(product3);
        order1.AddProduct(product4);

        //Totally real place
        Address address1 = new Address("Second St.", "Bikini Bottom", "Ontario", "Japan");
        Customer customer1 = new Customer("Henry Ford", address1);

        order1.SetPackingLabel(product.GetName(), product.GetId());
        order1.SetShippingLabel(customer1.GetName(), address1.GetAddress());
        order1.CalcCountryPrice(address1.GetCountry());


        order1.Display();

    }
}