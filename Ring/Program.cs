using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ring
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(10, new Point(0, 0)); // out circle
            Circle c2 = new Circle(5, new Point(0, 0)); // in circle
            Ring ring = new Ring(c1, c2,new Point(1,1));
            Console.WriteLine("Ring Square = " + ring.GetSquare);
            Console.WriteLine("Ring Radius = " + ring.GetRadius);
        }
    }
}
