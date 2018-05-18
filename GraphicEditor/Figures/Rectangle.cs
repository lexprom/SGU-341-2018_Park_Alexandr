using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.Figures
{
    public class Rectangle : Draw
    {
        private Point[] points;

        public Rectangle(Point[] points)
        {
            Points = points;
        }

        public Point[] Points
        {
            get => points;
            set
            {
                if (points == null || points.Length != 4)
                {
                    throw new Exception("Wron' array");
                }
                points = value;
            }
        }

        public override void Drawing()
        {
            Console.WriteLine($"Type <{GetType()}> {Environment.NewLine} {Points[0]} : {Points[1]} : {Points[2]} : {Points[3]}");
        }
    }
}
