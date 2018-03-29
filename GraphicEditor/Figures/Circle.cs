using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.Figures
{
    public class Circle
    {
        public double Radius { get; private set; }

        public Circle() { }

        public Circle (double radius)
        {
            Radius = radius;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"Type <{GetType()}> {Environment.NewLine}Radius = {Radius} {Environment.NewLine}");
        }
    }
}
