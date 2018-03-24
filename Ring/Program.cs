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
            Circle c1 = new Circle(7, 10);
            Circle c2 = new Circle(8, 11);
            var x = c1 - c2;
            Console.WriteLine(x.Area);
        }
    }
}
