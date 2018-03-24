using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ring
{
    class Circle
    {
        private double InneR { get; set; }
        private double OutR { get; set; }

        public double D { get { return InneR + OutR; } }
        public Circle(double ind,double oud)
        {
            InneR = ind;
            OutR = oud;
        }

        public double Area
        {
            get { return Math.PI * Math.Pow(InneR, 2); }
        }
    }
}
