using System.Drawing;

public class Square : Shape
{
    // create _side attribute as private member variable
    private double _side;

    // constructor that acccepts color and side
    public Square(double side, string color) : base(color)
    {
        _side = side;
    }

    // override GetArea() method from base class
    public override double GetArea()
    {
        return _side * _side;
    }
}