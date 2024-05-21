using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square(3, "bluish"));
        shapes.Add(new Rectangle(2, 4, "reddish"));
        shapes.Add(new Circle(3, "yellowish"));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }

        Square sq1 = new Square(3, "blue");

        System.Console.WriteLine(sq1.GetColor());
        System.Console.WriteLine(sq1.GetArea());

        Rectangle re1 = new Rectangle(2, 4, "red");

        System.Console.WriteLine(re1.GetColor());
        System.Console.WriteLine(re1.GetArea());

        Circle ci1 = new Circle(3, "yellow");

        System.Console.WriteLine(ci1.GetColor());
        System.Console.WriteLine(ci1.GetArea());
    }
}