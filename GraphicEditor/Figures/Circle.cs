using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.Figures
{
    public class Circle : Draw
    {
        private double radius;
        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public double Radius
        {
            get => radius;
            set
            {
                if (value <= 0)
                    throw new System.Exception("Radius can't be less than 0.");
                radius = value;
            }
        }
        public Point Center { get; set; }

        public override void Drawing()
        {
            Console.WriteLine($"Type <{GetType()}> {Environment.NewLine}Radius = {Radius} {Environment.NewLine}");
        }
    }
}
