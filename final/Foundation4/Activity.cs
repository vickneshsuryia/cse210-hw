public abstract class Activity
{
    //attributes
    private string _date;
    private int _minutes;
    //constructor
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    //methods
    public abstract float getDistance();
    public abstract float getSpeed();
    public abstract float getPace();
    public int getMinutes()
    {
        return _minutes;
    }
    public string getSummary()
    {
        return $"{_date} {GetType().Name} ({getMinutes()} min): Distance: {getDistance():F2}km, Speed: {getSpeed():F2}kph, Pace: {getPace():F2} min per km";
    }
}