public class Event
{
    //attributes
    private string _title;
    private string _description;
    private string _date;
    private Address _address;
    private string _time;
    //constructor
    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _address = address;
        _time = time;
    }
    //methods
    public string getStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.getFullAddress()}\n";
    }
    public string getTitle()
    {
        return _title;
    }
    public string getDate()
    {
        return _date;
    }
}