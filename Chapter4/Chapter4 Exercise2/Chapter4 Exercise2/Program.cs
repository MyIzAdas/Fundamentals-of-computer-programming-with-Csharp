using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter r value of the circle and I will print it's area and perimeter.");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area: "+Math.PI*r*r+"Perimeter: "+2*Math.PI*r);
        }
    }
}
