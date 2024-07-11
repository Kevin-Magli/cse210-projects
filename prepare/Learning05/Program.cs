using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>()
        {
            new Square(5),
            new Rectangle(5, 4),
            new Circle(5)
        };

        // set colors

        shapes[0].SetColor("Red");
        shapes[1].SetColor("Green");
        shapes[2].SetColor("Blue");
        
        Console.WriteLine("Shape Colors:");

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
        }

        Console.WriteLine("Shape Details:");

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
        }

    }
}