using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.Figures
{
    public class Shape
    {
        public double Size { get; set; }

        public Shape() { }

        public Shape(double size)
        {
            Size = size;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"Type <{GetType()}> {Environment.NewLine}Size = {Size} {Environment.NewLine}");
        }
    }
}
