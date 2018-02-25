using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 'a'value of the rectangle and press \"Enter\"");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 'b'value of the rectangle and press \"Enter\"");
            int b = Convert.ToInt32(Console.ReadLine());
            int p = a * 2 + b * 2;
            int s = a * b;
            Console.WriteLine("Perimeter of rectangle: " + p +" Area of rectangle: "+s);
        }
    }
}
