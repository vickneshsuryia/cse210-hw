using System.Runtime.CompilerServices;

public class Address
{
    //attributes
    private string _street;
    private string _city;
    private string _state;
    //constructor
    public Address(string street, string city, string state)
    {
        _street = street;
        _city = city;
        _state = state;
    }
    //methods
    public string getFullAddress()
    {
        return $"{_street}, {_city}, {_state}.";
    }
}