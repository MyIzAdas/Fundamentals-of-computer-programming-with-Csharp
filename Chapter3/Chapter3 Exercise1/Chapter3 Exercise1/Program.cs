using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number and press \"Enter\"");
            num = Convert.ToInt32(Console.ReadLine());
            if (num%2 != 0)
            {
                Console.WriteLine("Number is odd.");
            }
            else
            {
                Console.WriteLine("Number is even.");
            }
        }
    }
}
