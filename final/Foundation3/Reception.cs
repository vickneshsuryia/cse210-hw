public class Reception : Event
{
    //attributes
    private string _rsvpEmail;
    //constructor
    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    //methods
    public string getFullDetails()
    {
        return $"{getStandardDetails()}Type: Reception\nRSVP here: {_rsvpEmail}";
    }
    public string getShortDescription()
    {
        return $"Type: Reception\nTitle: {getTitle()}\nDate: {getDate()}";
    }
    public void Display()
    {
        Console.WriteLine("Standard details-\n" +
                        $"{getStandardDetails()}\n" +
                        "Full details-\n" +
                        $"{getFullDetails()}\n\n" +
                        "Short description-\n" +
                        $"{getShortDescription()}\n\n" +
                        "===============================================================\n");
    }
}