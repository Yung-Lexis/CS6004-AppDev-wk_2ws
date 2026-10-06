class Circle
{
    public const double PI = 3.14;

    public static double GetArea(double radius)
    {
        return PI * radius * radius;
    }

    public static double GetPerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"Area: {Circle.GetArea(5)}");
        Console.WriteLine($"Perimeter: {Circle.GetPerimeter(5)}");

        
        Circle.PI = 3.14159;
    }
}