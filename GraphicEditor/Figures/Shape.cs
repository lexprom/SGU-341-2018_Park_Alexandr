using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.Figures
{
    public class Shape : IDraw
    {
        private Point x;
        private Point y;

        public Shape(Point p, Point p2)
        {
            x = p;
            y  = p2;
        }

        public void Draw()
        {
            Console.WriteLine($"Type <{GetType()}> {Environment.NewLine}Shape = {x.X}\t{y.Y}  {Environment.NewLine}");
        }
    }
}
