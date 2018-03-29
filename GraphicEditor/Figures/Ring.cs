using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.Figures
{
    public class Ring : Circle
    {
        private Circle circleOut;
        private Circle circleIn;

        public Ring(Circle c1, Circle c2)
        {
            if(c1.Radius - c2.Radius < Double.Epsilon)
            {
                throw new Exception("Radius OUT circle less than IN circle");
            }
            circleOut = c1;
            circleIn = c2;
        }

        public override void Draw()
        {
            Console.WriteLine($"Type <{GetType()}> {Environment.NewLine}Radius Circle 1 = {circleOut.Radius} {Environment.NewLine}" +
                $"Radius Circle 2 = {circleIn.Radius} {Environment.NewLine}");
        }
    }
}
