using Pyramid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure pyramid = new Figure();
            Point p1 = new Point(3, 0, 2);
            Point p2 = new Point(3, 0, 3);
            pyramid.ChangePoint(p1, p2);
            pyramid.Print();
        }
    }
}
