using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x and y coordinates to find out if you are inside or outside of circle.");
            Console.WriteLine("x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            if((x * x) + (y * y) <= 5 * 5)
            {
                Console.WriteLine("Point is in the circle");
            }
            else
            {
                Console.WriteLine("Point is outside of the circle");
            }
            if((x>=-1 && x<=5) && (y>=1 && y <=5))      //Exercise9
            {
                Console.WriteLine("Point is inside of the rectangle.");
            }
            else
            {
                Console.WriteLine("Point is outside of rectangle.");
            }
        }
    }
}
