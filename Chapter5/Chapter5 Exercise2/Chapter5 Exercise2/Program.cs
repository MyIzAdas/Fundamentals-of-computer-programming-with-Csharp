using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three real numbers to find out if their product is \"+\" or \"-\".");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            int minusCount = 0;
            if(num1<0)
            {
                minusCount=minusCount+1;
            }
            if (num2 < 0)
            {
                minusCount = minusCount + 1;
            }
            if (num3 < 0)
            {
                minusCount = minusCount + 1;
            }
            if(minusCount==1 || minusCount ==3)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
    }
}
