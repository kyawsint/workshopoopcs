using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPCS
{
    class Rectangle: Shape
    {
        double length, width;

        public Rectangle(double len, double wid)
            : base(len, wid)
        {
            length = len;
            width = wid;
        }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public void Area()
        {
            double area = length * width;
            Console.WriteLine("Rectangle area is {0}.", area);
        }

        public void Parameter()
        {
            double prm = (2 * length) + (2 * width);
            Console.WriteLine("Rectangle parimeter is {0}.", prm);
        }

        public override void Draw()
        {
            Area();
            Parameter();
        }
    }
}
