public class Customer
{
    //attributes
    private string _name;
    private Address _address;
    //constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    //method
    public bool isInUSA()
    {
        return _address.isUSA();
    }
    public string getName()
    {
        return _name;
    }
    public string getFullAddress()
    {
        return _address.getFullAddress();
    }
}