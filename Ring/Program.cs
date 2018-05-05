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
            Ring ring = new Ring(new Circle(new Point(3, 3), 5), 2);
            Console.WriteLine(ring);
        }
    }
}
