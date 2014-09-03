using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.RV.LIB;

namespace OOPCS
{
    class Dice
    {
        public static void Main(string[] args)
        {
            DiceThrow dt = new DiceThrow();
            Console.WriteLine(dt.FaceUp());
        }
    }

    class DiceThrow
    {
        Random rdm = new Random();
        int rdmno;

        public void Throw()
        {
            rdmno = rdm.Next(1, 7);
            //int rdm = ISSMath.RNDInt(6) + 1;
        }

        public DiceThrow()
        {
            Throw();
        }

        public int GetFace()
        {
            return rdmno;
        }

        public string FaceUp()
        {
            if (GetFace() == 1) return "1";
            else if (GetFace() == 2) return "2";
            else if (GetFace() == 3) return "3";
            else if (GetFace() == 4) return "4";
            else if (GetFace() == 5) return "5";
            else if (GetFace() == 6) return "6";
            else return "Error";
        }
    }

}
