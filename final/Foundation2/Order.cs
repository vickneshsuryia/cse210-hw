public class Order
{
    //attributes
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    //constructor
    public Order(Customer customer)
    {
        _customer = customer;
    }
    //methods
    public float getTotalCost()
    {
        float totalCost = 0;
        foreach (Product p in _products)
        {
            totalCost += p.getTotalCost();
        }
        if (_customer.isInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }
    public string getPackingLabel()
    {
        string label = "======Label======\n";
        foreach (Product product in _products)
        {
            label += $"Name: {product.getName()}\n";
            label += $"Product ID: {product.getProductID()}\n";
        }
        label += "=================\n\n";
        return label;
    }
    public string getShippingLabel()
    {
        string label = "";
        label += $"Name: {_customer.getName()}\n";
        label += $"Address: {_customer.getFullAddress()}\n";
        return label;
    }
    public void AppendProducts(Product product)
    {
        _products.Add(product);
    }
    public void Display()
    {
        Console.WriteLine($"{getShippingLabel()}\n{getPackingLabel()}Total cost: ${getTotalCost()}\n\n");
    }
}