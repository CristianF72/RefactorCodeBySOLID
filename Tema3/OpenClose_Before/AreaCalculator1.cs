using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3.OpenClose_Before
{
    class AreaCalculator1
    {
        public static double Area(object[] shapes)
        {
            
            double area = 0;
            foreach (var shape in shapes)
            {
                if (shape is Rectangle1)
                {
                    Rectangle1 rectangle = (Rectangle1)shape;
                    area += rectangle.Width * rectangle.Height;
                }
                else
                {
                    Circle1 circle = (Circle1)shape;
                    area += circle.Radius * circle.Radius * Math.PI;
                }
            }

            return area;
        }
    }
}
