//namespace Demo.OperatorOverloading
//{
//    public class Counter
//    {
//        public int Value { get; set; }

//        // Constructor to initialize the counter value
//        public Counter(int initialValue)
//        {
//            Value = initialValue;
//        }

//        // Overload the prefix ++ operator
//        public static Counter operator ++(Counter c)
//        {
//            // Increment the value and return the updated Counter object
//            c.Value++;
//            return c;
//        }

//        // Overload the postfix ++ operator
//        public static Counter operator ++(Counter c, int dummy)
//        {
//            // Store the current value for postfix increment
//            Counter temp = new Counter(c.Value);
//            // Increment the value and return the original state
//            c.Value++;
//            return temp;
//        }

//        // Override ToString method to display the counter value
//        public override string ToString()
//        {
//            return $"Counter Value: {Value}";
//        }
//    }
//}
