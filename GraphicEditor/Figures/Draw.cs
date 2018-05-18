using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.Figures
{
    public abstract class Draw
    {
        public virtual void Drawing()
        {
            Console.WriteLine($"Type{GetType()}");
        }
    }
}
