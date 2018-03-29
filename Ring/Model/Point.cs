using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ring
{
    public class Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; private set; }
        public double Y { get; private set; }

        public override string ToString()
        {
            return string.Format("({0}, {1})", X, Y);
        }
    }
}
