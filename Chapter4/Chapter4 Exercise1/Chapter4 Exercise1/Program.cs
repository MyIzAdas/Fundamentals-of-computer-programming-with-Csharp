using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers you want to sum up.");
            Console.Write("Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of these numbers is: " + (num1 + num2 + num3));
        }
    }
}
