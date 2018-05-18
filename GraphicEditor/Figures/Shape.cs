using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.Figures
{
    public class Shape : Draw
    {
        private Point first;
        private Point last;

        public Shape(Point first, Point last)
        {
            First = first;
            Last = last;
        }

        public Point First
        {
            get => first;
            set
            {
                if (first == null)
                {
                    throw new ArgumentNullException();
                }
                first = value;
            }
        }
        public Point Last
        {
            get => last;
            set
            {
                if (last == null)
                {
                    throw new ArgumentNullException();
                }
                last = value;
            }
        }

        public override void Drawing()
        {
            Console.WriteLine($"Line: start - ({First.X}, {First.Y}), end - ({Last.X}, {Last.Y})");
        }
    }
}
