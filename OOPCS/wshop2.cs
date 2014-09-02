using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPCS
{
    class wshop2
    {
        static void Main(string[] args)
        {
            // For Rectangle
            Console.WriteLine("For Rectangle.");
            Rectangle rec = new Rectangle(2, 3);
            rec.Area();
            rec.Parameter();

            // For Triangle
            Console.WriteLine("\nFor Triangle.");
            Triangle tri = new Triangle(3, 4, 5);
            tri.IsRightTriangle();
            Console.WriteLine("{0} is parameter of triangle.", tri.Parameter);
            tri.Area();


            // For Dice
            Console.WriteLine("\nFor Dice.");

        }
    }
}
