using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid.Models
{
    public class Point
    {
        private double x;
        private double y;
        private double z;

        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public double Z { get { return z; } set { z = value; } }

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
        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Point p = (Point)obj;
            return (x == p.x) && (y == p.y) && (z ==p.z);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
