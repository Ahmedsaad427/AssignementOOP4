using System;

namespace Demo.Abstraction
{
    // Concrete class Circle
    public class Circle : Shape
    {
        // Constructor to initialize radius
        public Circle(double radius)
        {
            Dim01 = radius; // Dim01 is radius for Circle
        }

        // Implement GetArea method
        public override double GetArea()
        {
            return Math.PI * Dim01 * Dim01; // Area = π * r²
        }
    }
}
