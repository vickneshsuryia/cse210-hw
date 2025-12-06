public class Product
{
    //attributes
    private string _name;
    private string _productID;
    private float _pricePerUnit;
    private int _quantity;
    //constructor
    public Product(string name, string productID, float pricePerUnit, int quantity)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }
    public float getTotalCost()
    {
        return _pricePerUnit * _quantity;
    }
    //methods
    public string getName()
    {
        return _name; 
    }
    public string getProductID()
    {
        return _productID;
    }
}