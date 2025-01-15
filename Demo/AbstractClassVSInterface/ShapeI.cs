public interface ShapeI
{
    double GetArea(); // No implementation, just a contract
    void DisplayDimensions(); // Contract for displaying dimensions
}

public class Circle1 : ShapeI
{
    public double Dim01 { get; set; }

    public Circle1(double radius)
    {
        Dim01 = radius;
    }

    public double GetArea()
    {
        return Math.PI * Dim01 * Dim01; // π * r²
    }

    public void DisplayDimensions()
    {
        Console.WriteLine($"Radius: {Dim01}");
    }
}
