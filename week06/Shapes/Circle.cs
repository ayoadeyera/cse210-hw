using System;

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        // Math.PI is a built-in constant for 3.14159...
        return Math.PI * _radius * _radius;
    }
}