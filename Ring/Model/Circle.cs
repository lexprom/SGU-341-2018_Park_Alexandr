using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ring
{
    public class Circle
    {
        public double Radius { get; private set; }

        public Point Center { get; private set; }

        public Circle(double radius, Point center)
        {
            Radius = radius;
            Center = center;
        }

        public Circle(){}

        public double Square
        {
            get { return Math.PI * Radius * Radius; }
        }

        public double Circuit
        {
            get { return Math.PI * 2 * Radius; }
        }

        public bool IsInside(Point point)
        {
            Point vector = new Point(point.X - Center.X, point.Y - Center.Y);
            double distance = vector.X * vector.X + vector.Y * vector.Y;
            return distance <= Radius * Radius;
        }

        public override string ToString()
        {
            return String.Format("Radius: {0}; Center: {1};", Radius, Center);
        }
    }
}
