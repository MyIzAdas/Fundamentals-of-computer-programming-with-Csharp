using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me 2 int numbers!");
            Console.Write("num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 < num2)
            {
                for (int i = num1; i <= num2; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            if (num1 > num2)
            {
                for (int i = num2; i <= num1; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
