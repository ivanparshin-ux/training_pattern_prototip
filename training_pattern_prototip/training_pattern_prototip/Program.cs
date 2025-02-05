public abstract class Shape
{
    public int X { get; set; }
    public int Y { get; set; }
    public string Color { get; set; }

    protected Shape() { }

    protected Shape(Shape source)
    {
        X = source.X;
        Y = source.Y;
        Color = source.Color;
    }

    public abstract Shape Clone();
}

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle() { }

    public Rectangle(Rectangle source) : base(source)
    {
        Width = source.Width;
        Height = source.Height;
    }

    public override Shape Clone()
    {
        return new Rectangle(this);
    }
}

public class Circle : Shape
{
    public int Radius { get; set; }

    public Circle() { }

    public Circle(Circle source) : base(source)
    {
        Radius = source.Radius;
    }

    public override Shape Clone()
    {
        return new Circle(this);
    }
}

public class Cube : Shape
{
    public int Volume { get; set; }

    public Cube() { }

    public Cube(Cube source) : base(source)
    {
        Volume = source.Volume;
    }

    public override Shape Clone()
    {
        return new Cube(this);
    }
}

public class Sphere : Shape
{
    public int Radius { get; set; }

    public Sphere() { }

    public Sphere(Sphere source) : base(source)
    {
        Radius = source.Radius;
    }

    public override Shape Clone()
    {
        return new Sphere(this);
    }
}

public class Application
{
    public void Run()
    {
        // Пример использования
        Rectangle rectangle = new Rectangle { X = 10, Y = 15, Color = "Red", Height = 12, Width = 12 };
        Console.WriteLine($"Rectangle: X={rectangle.X}, Y={rectangle.Y}, Color={rectangle.Color}, Height={rectangle.Height}, Width={rectangle.Width}");
        Console.WriteLine();

        Circle circle = new Circle { X = 3, Y = 2, Color = "Green", Radius = 8 };
        Console.WriteLine($"Circle: X = {circle.X}, Y = {circle.Y}, Color = {circle.Color}, Radius = {circle.Radius}");
        Console.WriteLine();

        Sphere sphere = new Sphere { X = 43, Y = 32, Color = "Yellow", Radius = 7 };
        Console.WriteLine($"Sphere: X = {sphere.X}, Y = {sphere.Y}, Color = {sphere.Color}, Radius = {sphere.Radius}");
        Console.WriteLine();

        Cube cube = new Cube { X = 0, Y = 0, Color = "White", Volume = 13 };
        Console.WriteLine($"Cube: X = {cube.X}, Y = {cube.Y}, Color = {cube.Color}, Volume = {cube.Volume}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Application app = new Application();
        app.Run();
        Console.ReadKey();
    }
}
