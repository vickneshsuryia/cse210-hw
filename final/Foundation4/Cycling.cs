public class Cycling : Activity
{
    //attributes
    private float _speed;
    //constructor
    public Cycling(string date, int minutes, float speed) : base(date, minutes)
    {
        _speed = speed;
    }
    //methods
    public override float getDistance()
    {
        return _speed * getMinutes() / 60;
    }
    public override float getSpeed()
    {
        return _speed;
    }
    public override float getPace()
    {
        return getMinutes() / getDistance();
    }
}
