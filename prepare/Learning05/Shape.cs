public abstract class Shape
{
    //attributes
    private string _color;
    //constructor
    public Shape(string color)
    {
        _color = color;
    }
    //method
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public abstract double GetArea();
}