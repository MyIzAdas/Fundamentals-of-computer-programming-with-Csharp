using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 int numbers to find out witch of them has highest value");
            Console.Write("num0: ");
            int num0 = int.Parse(Console.ReadLine());
            Console.Write("num1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("num2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("num3: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("num4: ");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Highest number is: "+Math.Max(num4,Math.Max(Math.Max(num0,num1),Math.Max(num2,num3))));
        }
    }
}
