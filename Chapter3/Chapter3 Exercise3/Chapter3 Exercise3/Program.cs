using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number and press \"Enter\" and I will tell if it's 3rd number is 7.");
            int num = Convert.ToInt32(Console.ReadLine())/100;
            if(num%10==7)
            {
                Console.WriteLine("Third character is 7!");
            }
            else
            {
                Console.WriteLine("It is not 7.");
            }
        }
    }
}
