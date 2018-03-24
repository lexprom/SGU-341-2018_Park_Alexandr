using System;

namespace Ring
{
    class Ring : Circle
    {
        public Ring(Circle c1,Circle c2)
        {
            if (c1.D - c2.D < Double.Epsilon)
            {
                throw new Exception("Диаметр круга меньше диаметра вычитаемого круга!");
            }
            return new Ring();
        }
    }

}