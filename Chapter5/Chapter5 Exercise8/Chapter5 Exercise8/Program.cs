using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5_Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 0 if you want input int variable, 1 if you want to input double variable and 2 if you want to enter string variable");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 0:
                    int intVar = int.Parse(Console.ReadLine());
                    Console.WriteLine("You have chosen int: " + (intVar + 1));
                    break;
                case 1:
                    double dblVar = double.Parse(Console.ReadLine());
                    Console.WriteLine("You have chosen double: " + (dblVar + 1));
                    break;
                case 2:
                    string strVar = Console.ReadLine();
                    Console.WriteLine("You have chosen string: "+strVar+"*");
                    break;
                default:
                    Console.WriteLine("You must enter 0, 1 or 2!");
                    break;
            }
        }
    }
}
