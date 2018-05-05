using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphicEditor
{
    public class Point : IDraw
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; private set; }
        public double Y { get; private set; }

        public void Draw()
        {
            Console.WriteLine($"Type <{GetType()}> {Environment.NewLine}X = {X} \t Y = {Y} {Environment.NewLine}");
        }
    }
}
