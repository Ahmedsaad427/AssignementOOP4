namespace Demo.OperatorOverloading
{
    public class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Overload the + operator
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            double realPart = c1.Real + c2.Real;
            double imaginaryPart = c1.Imaginary + c2.Imaginary;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        // Override ToString method to display complex number in a readable form
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}
