public class Lecture : Event
{
    //attributes
    private string _speaker;
    private int _capacity;
    //constructor
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    //methods
    public string getFullDetails()
    {
        return $"{getStandardDetails()}Type: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
    public string getShortDescription()
    {
        return $"Type: Lecture\nTitle: {getTitle()}\nDate: {getDate()}";
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