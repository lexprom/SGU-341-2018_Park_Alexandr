using GraphicEditor.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape height = new Shape(5);
            Shape width = new Shape(10);
            var shapeFigures = new List<Shape> { height, width, new Rectangle(width,height)};
            shapeFigures.ForEach(item => item.Draw());

            Circle circleOut = new Circle(10);
            Circle circleIn = new Circle(5);
            var circleFigures = new List<Circle> { circleOut, circleIn, new Ring(circleOut, circleIn) };
            circleFigures.ForEach(item => item.Draw());
        }
    }
}
