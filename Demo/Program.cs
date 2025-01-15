#region Abstraction
////4. Abstraction:
//// abstract: C# Keyword [class methods properties]
//// abstract class
//// abstract method
////abstract property
//// 2D Shape

//using System;

//namespace Demo.Abstraction
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Test Circle
//            Shape circle = new Circle(5);
//            Console.WriteLine($"Area of Circle: {circle.GetArea()}");

//            // Test Rectangle
//            Shape rectangle = new Rectangle(4, 6);
//            Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}");

//        }
//    }
//}

#endregion

#region AbstractClassVSInterface
/*
 1. Purpose:
Abstract Class:
An abstract class is used when you want to share common functionality among multiple derived classes while still enforcing certain methods to be overridden by derived classes. It can provide both abstract methods (that must be implemented) and concrete methods (that already have implementation).
Abstract classes are ideal for creating a common base with shared behavior and common state.
Interface:
An interface is purely a contract that defines a set of methods and properties that implementing classes must adhere to. It does not contain any implementation logic (except for default implementations in C# 8.0+).
Interfaces are ideal when you want to define a capability or behavior that can be applied to classes from different inheritance hierarchies.
2. Implementation:
Abstract Class:
Can contain both abstract (unimplemented) methods and concrete (implemented) methods.
Can have fields (state), constructors, and properties with both getters and setters.
Can define access modifiers for methods and properties.
A class can inherit from only one abstract class (C# supports single inheritance).
Interface:
Can only contain method signatures, properties, events, and indexers (i.e., no implementation).
Cannot have fields or constructors (although, starting from C# 8.0, default methods are allowed).
All members of an interface are implicitly public and cannot have access modifiers.
A class can implement multiple interfaces (C# supports multiple inheritance of interfaces).
3. Inheritance:
Abstract Class:
A class can inherit from only one abstract class.
Abstract classes allow for code reuse in derived classes through shared implementation.
Interface:
A class can implement multiple interfaces, allowing it to inherit behavior from more than one source.
Interfaces provide flexibility in designing class capabilities independent of inheritance.
4. Access Modifiers:
Abstract Class:
Can have different access modifiers (private, protected, internal, public) for methods, fields, and properties.
Interface:
All members of an interface are implicitly public, and cannot have access modifiers.
5. Constructor:
Abstract Class:
Can have constructors to initialize state (fields) in derived classes.
Interface:
Cannot have constructors.
6. When to Use:
Abstract Class:
Use when you want to provide a common base class with shared functionality.
Use when you need to define some default behavior and force derived classes to implement specific methods.
Interface:
Use when you want to define a contract or capability (e.g., IDisposable, IEnumerable) that can be implemented by any class, regardless of its place in the inheritance hierarchy.
Use when you expect multiple inheritance or need the class to adhere to several different contracts.
 */
#endregion


#region +Overloading
//using System;

//namespace Demo.OperatorOverloading
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Create two complex numbers
//            ComplexNumber complex1 = new ComplexNumber(3, 4);  // 3 + 4i
//            ComplexNumber complex2 = new ComplexNumber(1, 2);  // 1 + 2i

//            // Add complex1 and complex2 using the overloaded + operator
//            ComplexNumber result = complex1 + complex2;

//            // Display the result
//            Console.WriteLine($"Complex Number 1: {complex1}");
//            Console.WriteLine($"Complex Number 2: {complex2}");
//            Console.WriteLine($"Sum of Complex Numbers: {result}");
//        }
//    }
//}

#endregion

#region ++Overloading
//using System;

//namespace Demo.OperatorOverloading
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Create a Counter object with an initial value of 5
//            Counter counter = new Counter(5);

//            // Test the prefix ++ operator
//            Console.WriteLine("Before prefix increment: " + counter); // Expected: Counter Value: 5
//            ++counter;  // Prefix increment
//            Console.WriteLine("After prefix increment: " + counter); // Expected: Counter Value: 6

//            // Test the postfix ++ operator
//            Console.WriteLine("Before postfix increment: " + counter); // Expected: Counter Value: 6
//            Counter temp = counter++;  // Postfix increment
//            Console.WriteLine("After postfix increment: " + counter); // Expected: Counter Value: 7
//            Console.WriteLine("Returned from postfix increment: " + temp); // Expected: Counter Value: 6
//        }
//    }
//}

#endregion

#region ComparisonOperator
using System;

namespace Demo.OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two Comparison objects
            Comparison c1 = new Comparison(10);
            Comparison c2 = new Comparison(20);

            // Test equality operator (==)
            Console.WriteLine($"Are c1 and c2 equal? {c1 == c2}");  // Expected: False

            // Test inequality operator (!=)
            Console.WriteLine($"Are c1 and c2 not equal? {c1 != c2}");  // Expected: True

            // Test less than operator (<)
            Console.WriteLine($"Is c1 less than c2? {c1 < c2}");  // Expected: True

            // Test greater than operator (>)
            Console.WriteLine($"Is c1 greater than c2? {c1 > c2}");  // Expected: False

            // Test less than or equal operator (<=)
            Console.WriteLine($"Is c1 less than or equal to c2? {c1 <= c2}");  // Expected: True

            // Test greater than or equal operator (>=)
            Console.WriteLine($"Is c1 greater than or equal to c2? {c1 >= c2}");  // Expected: False
        }
    }
}

#endregion