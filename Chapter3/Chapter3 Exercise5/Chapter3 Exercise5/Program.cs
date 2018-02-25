using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates surface of trapezoid.");
            Console.WriteLine("Enter 'a' value and press \"Enter\"");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 'b' value and press \"Enter\"");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 'h' value and press \"Enter\"");
            int h = Convert.ToInt32(Console.ReadLine());
            double s = (double)(a + b) * h / 2;
            Console.WriteLine("Surface of trapezoid is: "+s);
        }
    }
}
