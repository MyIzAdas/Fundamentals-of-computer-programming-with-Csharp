using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5_Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please eneter a, b and c values to calculate quadratic equation.");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = b * b - 4 * a * c;
            double x;
            if(D==0)
            {
                x = (-1 * b) / (2 * a);
                Console.WriteLine("x1=x2= "+x);
            }
            if(D>0)
            {
                double x1 = (-1 * b + Math.Sqrt(b * b - 4 * a * c)) / (a * 2);
                double x2 = (-1 * b - Math.Sqrt(b * b - 4 * a * c)) / (a * 2);
                Console.WriteLine("x1= " + x1 + " x2= " + x2);
            }
            else
            {
                Console.WriteLine("x= none");
            }
        }
    }
}
