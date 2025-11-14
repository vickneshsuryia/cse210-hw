using System;
public class Circle : Shape
{
    //attributes
    private double _radius;
    //constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    //method
    public override double GetArea()
    {
        double area = _radius * _radius * Math.PI;
        return area;
    }
}