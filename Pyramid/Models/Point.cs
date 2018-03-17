using System;

namespace Pyramid.Models
{
    public class Point : IEquatable<Point>, ICloneable
    {
        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public double GetDistance(Point p2)
        {
            try
            {
                return Math.Sqrt(
                    Math.Pow(p2.X - this.X, 2) +
                    Math.Pow(p2.Y - this.Y, 2) +
                    Math.Pow(p2.Z - this.Z, 2)
                    );
            }
            catch(Exception)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Point);
        }
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }

        public bool Equals(Point other)
        {
            if (other == null || GetHashCode() != other.GetHashCode())
                return false;
            return (X == other.X) && (Y == other.Y) && (Z == other.Z);
        }

        public object Clone()
        {
            return new Point(X, Y, Z);
        }
    }
}
