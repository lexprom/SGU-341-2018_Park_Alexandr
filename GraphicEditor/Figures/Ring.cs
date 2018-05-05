using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor.Figures
{
    public class Ring : IDraw
    {
        private double ringRadius;
        private Circle greaterCircle;

        public Ring(Circle greaterCircle, double ringRadius)
        {
            GreaterCircle = greaterCircle;
            RingRadius = ringRadius;
        }

        public Circle GreaterCircle
        {
            get => greaterCircle;
            set
            {
                if (value == null && value.Radius > RingRadius)
                    throw new Exception("Wrong circle!");
                else
                    greaterCircle = value;
            }
        }
        public double RingRadius
        {
            get => ringRadius;
            set
            {
                if (value < 0 || value > GreaterCircle.Radius || GreaterCircle == null)
                    throw new Exception("Wrong radius!");

                ringRadius = value;
            }
        }
        public void Draw()
        {
            Console.WriteLine($"Type <{GetType()}> {Environment.NewLine}Radius CircleGreater = {greaterCircle.Radius} {Environment.NewLine}" +
                $"Radius CircleLower = {ringRadius} {Environment.NewLine}");
        }
    }
}
