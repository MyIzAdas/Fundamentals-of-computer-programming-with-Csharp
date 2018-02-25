using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers.");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if (num1>num2)
            {
                num2 = num1;
            }
            Console.WriteLine("Num1: " + num1 + " Num2: " + num2);
        }
    }
}
