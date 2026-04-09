using System;

// Use Shape to inherit from our abstract base class
public class Square : Shape
{
    private double _side;

    // The constructor takes color and side
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Use 'override' to provide the specific behavior for GetArea
    public override double GetArea()
    {
        return _side * _side;
    }
}