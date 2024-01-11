using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        var circle = new Circle{Radius = 200};
        var rectangle = new Rectangle { Height = 200, Width = 200 };

        PrintShape(rectangle);
        PrintShape(circle);
    }

    static void PrintShape(Shape shape)
    {
        Console.WriteLine($"Perimeter: {shape.GetPerimeter()}. Area: {shape.GetArea()}");
    }
}

abstract class Shape
{
    public abstract double GetPerimeter ();
    public abstract double GetArea();
}

class Rectangle : Shape
{
    public float Width { get; set; }
    public float Height { get; set; }

    public override double GetArea() => Width * 2 + Height *2;

    public override double GetPerimeter() => Width * Height;
}

class Circle : Shape
{
    public float Radius { get; set; }

    public override double GetArea()
    {
        double resArea = Radius * 2 * 3.14; 

        return resArea;
    }

    public override double GetPerimeter()
    {
        double resPer = Radius * Radius * 3.14;

        return resPer;
    }
}