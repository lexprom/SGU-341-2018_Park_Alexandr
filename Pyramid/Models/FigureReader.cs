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
       public  void ReadByFile(Figure figure)
        {
            using (StreamReader sr = new StreamReader(@"..\..\cordinates.txt"))
            {
                var vertex_one = sr.ReadLine().Split(' ');
                try
                {
                    figure.vertexes.Add(new Point(double.Parse(vertex_one[0]), double.Parse(vertex_one[1]), double.Parse(vertex_one[2])));
                }
                catch(Exception)
                {
                    throw new FormatException("Wrong parse");
                }

                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] coords = line.Split(' ');
                    if (coords.Length > 3)
                    {
                        throw new Exception("Too much cords");
                    }

                    try
                    {
                        figure.vertexes.Add(new Point(
                        double.Parse(coords[0]),
                        double.Parse(coords[1]),
                        double.Parse(coords[2]))
                        );
                    }
                    catch (Exception)
                    {
                        throw new Exception("Miss smth!");
                    }

                    line = sr.ReadLine();
                }

                if (figure.vertexes.Count > 5)
                {
                    throw new Exception("Too much values");
                }
            }
        }

        public void Print(Figure figure)
        {
            using (StreamWriter sw = new StreamWriter(@"..\..\out.txt"))
            {
                sw.WriteLine("Area = {0}", figure.GetArea());
                sw.WriteLine("Volume = {0}", figure.Volume());
            }
        }
    }
}
