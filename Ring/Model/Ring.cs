using System;

namespace Ring
{
   public class Ring : Circle
    {
        private Circle circleIn;
        private Circle circleOut;

        public Ring(Circle c1, Circle c2,Point center)
        {
            if (c1.Radius - c2.Radius < Double.Epsilon)
            {
                throw new Exception("Диаметр круга меньше диаметра вычитаемого круга!");
            }
            circleOut = c1;
            circleIn = c2;
        }

        public double GetSquare
        {
            get
            {
                return Math.PI * (Math.Pow(circleOut.Radius, 2) - Math.Pow(circleIn.Radius, 2));
            }
        }

        public double GetRadius
        {
            get
            {
                return circleOut.Circuit + circleIn.Circuit;
            }
        }
    }
}