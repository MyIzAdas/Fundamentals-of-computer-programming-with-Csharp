using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int hexNum = 5;
            double fPos = 1.25445;
            double fNeg = -1.26546;
            Console.Write("|{0,-8:X}|",hexNum);
            Console.Write("|{0,-10:f2}|", fPos);
            Console.Write("|{0,-10:f2}|", fNeg);
        }
    }
}
