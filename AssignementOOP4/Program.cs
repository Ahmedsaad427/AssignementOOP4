#region FirstProjectTest
//using System;
//using Assignment_4.FirstProject;

//class Program
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            // Read points from user
//            Console.Write("Enter coordinates for P1 (format: x,y,z): ");
//            string[] p1Input = Console.ReadLine()?.Split(',');
//            _3DPoint p1 = new _3DPoint(
//                Convert.ToInt32(p1Input[0]),
//                Convert.ToInt32(p1Input[1]),
//                Convert.ToInt32(p1Input[2])
//            );

//            Console.Write("Enter coordinates for P2 (format: x,y,z): ");
//            string[] p2Input = Console.ReadLine()?.Split(',');
//            _3DPoint p2 = new _3DPoint(
//                Convert.ToInt32(p2Input[0]),
//                Convert.ToInt32(p2Input[1]),
//                Convert.ToInt32(p2Input[2])
//            );

//            Console.WriteLine($"P1: {p1}");
//            Console.WriteLine($"P2: {p2}");

//            // Check if points are equal
//            Console.WriteLine(p1 == p2
//                ? "P1 and P2 are equal."
//                : "P1 and P2 are not equal.");

//            // Create and sort an array of points
//            _3DPoint[] points = {
//                new _3DPoint(5, 2, 3),
//                new _3DPoint(2, 3, 1),
//                new _3DPoint(4, 1, 6),
//                new _3DPoint(2, 3, 1) // Duplicate for equality testing
//            };

//            Array.Sort(points);
//            Console.WriteLine("Sorted Points:");
//            foreach (var point in points)
//            {
//                Console.WriteLine(point);
//            }

//            // Clone a point
//            _3DPoint clonedPoint = (_3DPoint)p1.Clone();
//            Console.WriteLine($"Cloned P1: {clonedPoint}");
//        }
//        catch (FormatException)
//        {
//            Console.WriteLine("Invalid input. Please enter valid integers.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"An error occurred: {ex.Message}");
//        }
//    }
//}

#endregion
#region SecondProjectTest
/*
 using System;
using Assignment_4.SecondProject;

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Maths Operations:");

                // Add
                Console.WriteLine($"Add(10, 5) = {Maths.Add(10, 5)}");

                // Subtract
                Console.WriteLine($"Subtract(10, 5) = {Maths.Subtract(10, 5)}");

                // Multiply
                Console.WriteLine($"Multiply(10, 5) = {Maths.Multiply(10, 5)}");

                // Divide
                Console.WriteLine($"Divide(10, 5) = {Maths.Divide(10, 5)}");

                // Test divide by zero
                // Console.WriteLine(Maths.Divide(10, 0)); // Uncomment to see exception
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

 */
#endregion
#region ThirdProjectTest
//using System;

//namespace AssignementOOP4.ThirdProject
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // Test constructors and ToString method
//            Duration D1 = new Duration(1, 10, 15);
//            Console.WriteLine(D1); // Output: Hours: 1, Minutes: 10, Seconds: 15

//            Duration D2 = new Duration(3600);
//            Console.WriteLine(D2); // Output: Hours: 1, Minutes: 0, Seconds: 0

//            Duration D3 = new Duration(7800);
//            Console.WriteLine(D3); // Output: Hours: 2, Minutes: 10, Seconds: 0

//            Duration D4 = new Duration(666);
//            Console.WriteLine(D4); // Output: Minutes: 11, Seconds: 6

//            // Test operator overloading
//            Duration D5 = D1 + D3;
//            Console.WriteLine(D5); // Output: Hours: 3, Minutes: 20, Seconds: 15

//            Duration D6 = D1 + 7800;
//            Console.WriteLine(D6); // Output: Hours: 3, Minutes: 40, Seconds: 15

//            Duration D7 = 666 + D4;
//            Console.WriteLine(D7); // Output: Minutes: 22, Seconds: 12

//            Duration D8 = ++D1;
//            Console.WriteLine(D8); // Output: Hours: 1, Minutes: 11, Seconds: 15

//            Duration D9 = --D3;
//            Console.WriteLine(D9); // Output: Hours: 2, Minutes: 9, Seconds: 0

//            Duration D10 = D1 - D2;
//            Console.WriteLine(D10); // Output: Hours: 0, Minutes: 11, Seconds: 15

//            // Test comparison operators
//            if (D1 > D2)
//                Console.WriteLine("D1 is greater than D2");
//            else if (D1 <= D2)
//                Console.WriteLine("D1 is less than or equal to D2");

//            // Test conversion to DateTime
//            DateTime dateTime = (DateTime)D1;
//            Console.WriteLine($"Converted to DateTime: {dateTime:HH:mm:ss}"); // Output: Converted to DateTime: 01:11:15
//        }
//    }
//}

#endregion