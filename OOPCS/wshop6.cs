using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPCS
{
    class wshop6
    {
        public static void Main(string[] args)
        {
            Shape[] shape = new Shape[] { new Rectangle(3, 4), new Triangle(3, 4, 5) };
            foreach (Shape s in shape)
            {
                s.Draw();   
            }
        }
    }

    abstract class Shape
    {
        double x, y;
        public Shape(double xx, double yy)
        {
            this.x = xx;
            this.y = yy;
        }

        public abstract void Draw();
    }
}
