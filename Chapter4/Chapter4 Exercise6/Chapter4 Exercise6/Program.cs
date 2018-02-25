using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two int numbers for comparison without operators.");
            Console.Write("num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Max(num1,num2)+" is bigger than "+Math.Min(num1,num2));
        }
    }
}
