public class OutdoorGathering : Event
{
    //attributes
    private string _weatherForecast;
    //constructor
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }
    //methods
    public string getFullDetails()
    {
        return $"{getStandardDetails()}Type: Outdoor Gathering\nWeather Forecast: {_weatherForecast}\n";
    }
    public string getShortDescription()
    {
        return $"Type: Outdoor Gathering\nTitle: {getTitle()}\nDate: {getDate()}";
    }
    public void Display()
    {
        Console.WriteLine("Standard details-\n" +
                        $"{getStandardDetails()}\n" +
                        "Full details-\n" +
                        $"{getFullDetails()}\n" +
                        "Short description-\n" +
                        $"{getShortDescription()}\n\n" +
                        "===============================================================\n");
    }
}