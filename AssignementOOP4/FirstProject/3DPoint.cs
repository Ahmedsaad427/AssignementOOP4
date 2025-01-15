using System;

namespace Assignment_4.FirstProject
{
    internal class _3DPoint : IComparable<_3DPoint>, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        // Constructor chaining
        public _3DPoint() : this(0, 0, 0) { }
        public _3DPoint(int x, int y) : this(x, y, 0) { }
        public _3DPoint(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Override ToString
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        // Override Equals and == operator
        public override bool Equals(object obj)
        {
            if (obj is _3DPoint other)
            {
                return X == other.X && Y == other.Y && Z == other.Z;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }

        public static bool operator ==(_3DPoint p1, _3DPoint p2)
        {
            if (ReferenceEquals(p1, null)) return ReferenceEquals(p2, null);
            return p1.Equals(p2);
        }

        public static bool operator !=(_3DPoint p1, _3DPoint p2)
        {
            return !(p1 == p2);
        }

        // Implement IComparable
        public int CompareTo(_3DPoint other)
        {
            if (X != other.X) return X.CompareTo(other.X);
            if (Y != other.Y) return Y.CompareTo(other.Y);
            return Z.CompareTo(other.Z);
        }

        // Implement ICloneable
        public object Clone()
        {
            return new _3DPoint(X, Y, Z);
        }
    }
}
