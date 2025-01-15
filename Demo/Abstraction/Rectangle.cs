using System;

namespace Demo.Abstraction
{
    // Concrete class Rectangle
    public class Rectangle : Shape
    {
        // Constructor to initialize dimensions
        public Rectangle(double length, double width)
        {
            Dim01 = length;  // Dim01 is length for Rectangle
            Dim02 = width;   // Dim02 is width for Rectangle
        }

        // Implement GetArea method
        public override double GetArea()
        {
            return Dim01 * Dim02; // Area = length * width
        }
    }
}
