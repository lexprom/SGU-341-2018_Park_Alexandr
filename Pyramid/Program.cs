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
            FigureReader fr = new FigureReader();
            Figure pyramid = new Figure(fr.ReadByFile());
            pyramid.Print();
        }
    }
}
