using System;

namespace Demo.Abstraction
{
    // Change to public so it matches the accessibility of derived classes
    public abstract class Shape
    {
        // Properties: protected for access by derived classes only
        protected double Dim01 { get; set; } // First dimension (e.g., radius for circle, length for rectangle)
        protected double Dim02 { get; set; } // Second dimension (e.g., width for rectangle, not used for circle)

        // Abstract method for calculating the area
        public abstract double GetArea();
    }
}
