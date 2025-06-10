using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 15);
        Rectangle rectangle = new Rectangle(6, 7, "blue");
        Circle circle = new Circle(8, "green");

        List<Shape> shapeList = new List<Shape>();
        shapeList.Add(square);
        shapeList.Add(rectangle);
        shapeList.Add(circle);

        foreach (Shape shape in shapeList)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }
}