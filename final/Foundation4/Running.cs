public class Running : Activity
{
    //attributes
    private float _distance;
    //constructor
    public Running(string date, int minutes, float distance) : base(date, minutes)
    {
        _distance = distance;
    }
    //methods
    public override float getDistance()
    {
        return _distance;
    }
    public override float getSpeed()
    {
        return _distance / getMinutes() * 60;
    }
    public override float getPace()
    {
        return getMinutes() / _distance;
    }
}