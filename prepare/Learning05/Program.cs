using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Square square = new Square("blue", 3);
        Console.WriteLine($"Color Square: {square.GetColor()} - Area: {square.GetArea()}");
        Rectangule rectangule = new Rectangule("red", 3, 7);
        Console.WriteLine($"Color Rectangule: {rectangule.GetColor()} - Area: {rectangule.GetArea()}");
        Circle circle = new Circle("yellow", 3);
        Console.WriteLine($"Color Circle: {circle.GetColor()} - Area: {circle.GetArea()}");

        List<Shape> listShapes = new List<Shape>();

        listShapes.Add(square);
        listShapes.Add(rectangule);
        listShapes.Add(circle);

        foreach (Shape shape in listShapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} - Area: {shape.GetArea()}");
        }
    }
}