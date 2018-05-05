using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.Figures
{
    class Rectangle : IDraw
    {
        private Shape width1, width2;
        private Shape height1, height2;

        public Rectangle(Shape height, Shape width)
        {
            width1 = width2 = width;
            height1 = height2 = height;
        }

        public void Draw()
        {
            Console.WriteLine($"Type <{GetType()}> {Environment.NewLine} Width = {width1} \t Height = {height1}");
        }
    }
}
