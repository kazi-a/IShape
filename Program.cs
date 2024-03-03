using System;

// Create an interface
interface IShape
{
    // Properties
    public double Area { get; }
    public double Perimeter { get; }

    // Methods
    public void DisplayInfo();
}

// Implement the interface in a class
class Rectangle : IShape
{
    // Properties
    public double Length { get; }
    public double Width { get; }

    // Constructor
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    // Implementing properties from the interface
    public double Area => Length * Width;
    public double Perimeter => 2 * (Length + Width);

    // Implementing method from the interface
    public void DisplayInfo()
    {
        Console.WriteLine($"Rectangle: Length = {Length}, Width = {Width}");
        Console.WriteLine($"Area = {Area}, Perimeter = {Perimeter}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Implemented class and display information
        Rectangle rectangle = new Rectangle(5, 7);
        rectangle.DisplayInfo();
    }
}
