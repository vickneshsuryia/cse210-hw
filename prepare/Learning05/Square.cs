public class Square : Shape
{
    //attributes
    private double _side;
    //constructor
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    //method
    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
}