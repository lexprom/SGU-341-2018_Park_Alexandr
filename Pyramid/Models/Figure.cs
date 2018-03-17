using System;
using System.Collections.Generic;
using System.Linq;

namespace Pyramid.Models
{
    public class Figure
    {
        public List<Point> vertexes = new List<Point>();
        private const double height = 4;

        public Figure(List<Point> vertexes)
        {
            ValidationVertexes(vertexes);
        }

        public void ValidationVertexes(List<Point> vertexes)
        {
            if (vertexes.Count == 5)
            {
                vertexes.ForEach(el => this.vertexes.Add((Point)el.Clone()));
            }
            else
            {
                throw new ArgumentOutOfRangeException("Wrong numbers of vertexes");
            }
        }

        public double GetArea()
        {
            var res = vertexes.Where(x => !x.Equals(vertexes[0])).ToList();
            double a = res[0].GetDistance(res[1]);
            double b = res[1].GetDistance(res[2]);
            double c = res[2].GetDistance(res[3]);
            double d = res[3].GetDistance(res[0]);

            try
            {
                double p = (a + b + c + d) / 2;
                return Math.Sqrt((p - a) * (p - b) * (p - c) * (p - d));
            }
            catch (Exception)
            {
                throw new ArithmeticException("Smth wrong");
            }

        }

        public double Volume()
        {
            return (1.0 / 3.0) * height * GetArea();
        }


        public void ChangePoint(Point p1,Point p2)
        {
            bool flag = false;
            for (int i = 0; i < vertexes.Count; i++)
            {
                if(vertexes[i].Equals(p1))
                {
                    vertexes[i] = p2;
                    flag = true;
                }
            }
            if(!flag)
            {
                vertexes.Add(p2);
            }
        }
    }
}