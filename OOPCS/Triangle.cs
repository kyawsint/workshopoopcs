using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPCS
{
    class Triangle: Shape
    {
        double side1,side2,side3;

        public Triangle(double s1, double s2, double s3)
            : base(s1, s2)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }

        public void IsRightTriangle()
        {
            if ((side1 * side1) + (side2 * side2) == (side3 * side3))
                Console.WriteLine("This is right triangle.");
        }

        public double Parameter
        {
            get
            {
                double prm = (side1 + side2 + side3);
                //Console.WriteLine("{0} is parameter of triangle.", prm);
                return prm;
            }
        }

        public void Area()
        {
            double prm = this.Parameter;
            double area = Math.Sqrt(prm * (prm - side1) * (prm - side2) * (prm - side3));
            Console.WriteLine("{0} is area of this triangle.", area);
        }

        public override void Draw()
        {
            IsRightTriangle();
            Console.WriteLine(Parameter);
            Area();
        }
    }
}
