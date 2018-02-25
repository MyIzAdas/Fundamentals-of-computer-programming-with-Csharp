using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three integer numbers to find out witch one has biggest value.");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            if(num1>num2)
            {
                if(num1>num3)
                {
                    Console.WriteLine(num1+" has the biggest value.");
                }
                else
                {
                    Console.WriteLine(num3 + " has the biggest value.");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine(num2 + " has the biggest value.");
                }
                else
                {
                    Console.WriteLine(num3 + " has the biggest value.");
                }
            }
        }
    }
}
