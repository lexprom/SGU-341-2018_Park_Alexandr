using Pyramid.Models;

namespace Pyramid
{
    public class Program
    {
        static void Main(string[] args)
        {
            FigureReader fr = new FigureReader();
            Figure pyramid = new Figure(fr.ReadByFile());
            FigureReader.Print(pyramid);
        }
    }
}
