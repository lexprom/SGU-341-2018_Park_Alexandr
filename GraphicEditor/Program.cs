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
            //Point[] arr = new Point[] { new Point(1, 2), new Point(4, 2), new Point(1, 0), new Point(4, 0) };

            //Rectangle rec = new Rectangle(arr);
            //rec.Drawing();

            Ring ring = new Ring(new Circle(new Point(-3.2, 4.5), 20), 14.5);
            ring.Drawing();

            Shape line = new Shape(new Point(3.3, 4.4), new Point(1.8, -4.5));
            line.Drawing();

            Circle circle = new Circle(new Point(3.3, 4.4), 13);
            circle.Drawing();

            Console.WriteLine("*************************************");
        }
    }
}
