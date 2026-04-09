using System;

// Mark the class 'abstract' so no one can create a generic "Shape" object
public abstract class Shape
{
    private string _color;

    // The constructor that accepts the color
    public Shape(string color)
{
    _color = color;
}

// Getters and Setters for the color
public string GetColor()
{
    return _color;
}


public void SetColor(string color)
{
    _color = color;
}


// The abstract method.

public abstract double GetArea();

}