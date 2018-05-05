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
            Point point = new Point(2, 2);
            Circle circle = new Circle(point, 4);
            Ring ring = new Ring(circle, 2);
            Shape width = new Shape(new Point(2,2),new Point(4,2));
            Shape height = new Shape(new Point(2,1), new Point(4,1));
            Rectangle rectangle = new Rectangle(height, width);

            point.Draw();
            circle.Draw();
            ring.Draw();
            width.Draw();
            height.Draw();
            rectangle.Draw();
        }
    }
}
