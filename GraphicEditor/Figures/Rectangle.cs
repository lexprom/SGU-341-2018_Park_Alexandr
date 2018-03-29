using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.Figures
{
    class Rectangle : Shape
    {
        private Shape width1,width2;
        private Shape height1,height2;

        public Rectangle(Shape width, Shape height)
        {
            width1 = width2 = width;
            height1 = height2 = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Type <{GetType()}> {Environment.NewLine}Width = {width1.Size} {Environment.NewLine}Height = {height1.Size} {Environment.NewLine}");
        }
    }
}
