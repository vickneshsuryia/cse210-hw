public class Swimming : Activity
{
    //attributes
    private int _laps;
    //constructor
    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }
    //methods
    public override float getDistance()
    {
        return _laps * 0.05f;
    }
    public override float getSpeed()
    {
        return getDistance() / getMinutes() * 60;
    }
    public override float getPace()
    {
        return getMinutes() / getDistance();
    }
}