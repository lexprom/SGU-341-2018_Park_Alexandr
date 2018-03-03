using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid.Models
{
    public class FigureReader
    {
        public List<Point> ReadByFile()
        {
            var vertexes = new List<Point>();
            using (StreamReader sr = new StreamReader(@"..\..\cordinates.txt"))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] coords = line.Split(' ');
                    if (coords.Length > 3)
                    {
                        throw new ArgumentOutOfRangeException("Too much cords");
                    }
                    try
                    {
                        vertexes.Add(new Point(double.Parse(coords[0]), double.Parse(coords[1]), double.Parse(coords[2])));
                    }
                    catch(Exception)
                    {
                        throw new FormatException("Wrng parse");
                    }
                    line = sr.ReadLine();
                }
            }
            return vertexes;
        }

        public static void Print(Figure figure)
        {
            using (StreamWriter sw = new StreamWriter(@"..\..\out.txt"))
            {
                sw.WriteLine("Area = {0}", figure.GetArea());
                sw.WriteLine("Volume = {0}", figure.Volume());
            }
        }
    }

}