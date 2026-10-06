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
/*
 ERROR EXPLANATION:
 Error CS0131: The left-hand side of an assignment must be a
 variable, property or indexer.

 Why it happens:
 - PI is declared with the 'const' keyword, so its value is fixed
   at compile time and can never be changed.
 - A constant is not a variable, so the compiler does not allow
   anything to be assigned to it using the '=' operator.
 - The compiler stops the build and shows this error, so the
   mistake is caught before the program even runs.
*/