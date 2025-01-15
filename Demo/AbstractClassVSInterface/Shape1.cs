public abstract class Shape1
{
    public double Dim01 { get; set; }
    public double Dim02 { get; set; }

    // Abstract method - must be implemented by derived class
    public abstract double GetArea();

    // Concrete method - can be used as is or overridden
    public void DisplayDimensions()
    {
        Console.WriteLine($"Dimensions: {Dim01}, {Dim02}");
    }
}

public class Circle : Shape1
{
    public Circle(double radius)
    {
        Dim01 = radius;
        Dim02 = 0; // Not used for circle
    }

    public override double GetArea()
    {
        return Math.PI * Dim01 * Dim01; // π * r²
    }
}
