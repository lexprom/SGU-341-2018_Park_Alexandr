using GraphicEditor.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphicEditor
{
    public class Point : Draw
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        protected Point()
        { }

        public double X { get; private set; }
        public double Y { get; private set; }

        public override void Drawing()
        {
            Console.WriteLine($"Type <{GetType()}> {Environment.NewLine}X = {X} \t Y = {Y} {Environment.NewLine}");
        }
    }
}
