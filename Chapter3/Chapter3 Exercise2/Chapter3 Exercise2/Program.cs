using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter integer number to check if the number is divisable by 5 and 7 and press \"Enter\"");
            num = Convert.ToInt32(Console.ReadLine());
            if (num%5==0 && num%7==0)
            {
                Console.WriteLine("Number is divisable by 5 and 7.");
            }
            else
            {
                Console.WriteLine("Number is not divisable by 5 and 7");
            }
        }
    }
}
