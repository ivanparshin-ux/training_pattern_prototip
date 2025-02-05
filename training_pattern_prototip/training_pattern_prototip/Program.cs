using System;
public abstract class Shape
{
    protected int x, y;
    protected string color;

    public Shape(int x, int y, string color)
    {
        this.x = x;
        this.y = y;
        this.color = color;
    }
    public abstract Shape Clone();
    public override string ToString()
    {
        return $"Shape at ({x}, {y}) with color {color}";
    }
}
public class Rectangle : Shape
{
    private int width, height;

    public Rectangle(int x, int y, string color, int width, int height)
        : base(x, y, color)
    {
        this.width = width;
        this.height = height;
    }
    public override Shape Clone()
    {
        return new Rectangle(x, y, color, width, height);
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Width: {width}, Height: {height}";
    }
}
public class Circle : Shape
{
    private int radius;

    public Circle(int x, int y, string color, int radius)
        : base(x, y, color)
    {
        this.radius = radius;
    }
    public override Shape Clone()
    {
        return new Circle(x, y, color, radius);
    }
    public override string ToString()
    {
        return $"{base.ToString()}, Radius: {radius}";
    }
}
public class Cube : Shape
{
    private int side;
    public Cube(int x, int y, string color, int side)
        : base(x, y, color)
    {
        this.side = side;
    }
    public override Shape Clone()
    {
        return new Cube(x, y, color, side);
    }
    public override string ToString()
    {
        return $"{base.ToString()}, Side: {side}";
    }
}
public class Sphere : Shape
{
    private int radius;

    public Sphere(int x, int y, string color, int radius)
        : base(x, y, color)
    {
        this.radius = radius;
    }
    public override Shape Clone()
    {
        return new Sphere(x, y, color, radius);
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Radius: {radius}";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Rectangle originalRectangle = new Rectangle(10, 20, "Red", 50, 30);
        Circle originalCircle = new Circle(15, 25, "Blue", 20);
        Cube originalCube = new Cube(20, 30, "Green", 40);
        Sphere originalSphere = new Sphere(25, 35, "Yellow", 30);
        Shape clonedRectangle = originalRectangle.Clone();
        Shape clonedCircle = originalCircle.Clone();
        Shape clonedCube = originalCube.Clone();
        Shape clonedSphere = originalSphere.Clone();
        Console.WriteLine("Original Rectangle: " + originalRectangle);
        Console.WriteLine("Cloned Rectangle: " + clonedRectangle);
        Console.WriteLine("Original Circle: " + originalCircle);
        Console.WriteLine("Cloned Circle: " + clonedCircle);
        Console.WriteLine("Original Cube: " + originalCube);
        Console.WriteLine("Cloned Cube: " + clonedCube);
        Console.WriteLine("Original Sphere: " + originalSphere);
        Console.WriteLine("Cloned Sphere: " + clonedSphere);
    }
}