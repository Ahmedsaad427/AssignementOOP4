namespace Demo.OperatorOverloading
{
    public class Comparison
    {
        public int Value { get; set; }

        public Comparison(int value)
        {
            Value = value;
        }

        // Overload the equality operator (==)
        public static bool operator ==(Comparison c1, Comparison c2)
        {
            return c1.Value == c2.Value;
        }

        // Overload the inequality operator (!=)
        public static bool operator !=(Comparison c1, Comparison c2)
        {
            return !(c1 == c2);  // Reusing the overloaded == operator
        }

        // Overload the less than operator (<)
        public static bool operator <(Comparison c1, Comparison c2)
        {
            return c1.Value < c2.Value;
        }

        // Overload the greater than operator (>)
        public static bool operator >(Comparison c1, Comparison c2)
        {
            return c1.Value > c2.Value;
        }

        // Overload the less than or equal operator (<=)
        public static bool operator <=(Comparison c1, Comparison c2)
        {
            return c1.Value <= c2.Value;
        }

        // Overload the greater than or equal operator (>=)
        public static bool operator >=(Comparison c1, Comparison c2)
        {
            return c1.Value >= c2.Value;
        }

        // Override ToString for better output
        public override string ToString()
        {
            return $"Comparison Value: {Value}";
        }

        // Override Equals and GetHashCode (important for == and !=)
        public override bool Equals(object obj)
        {
            if (obj is Comparison other)
            {
                return this == other;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
