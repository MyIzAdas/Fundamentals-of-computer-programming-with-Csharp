using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What size matrix do you want?");
            int n = int.Parse(Console.ReadLine());
            int increase = 0;
            if (n < 20)
            {
                for (int i = 0; i < n; i++)
                {
                    increase++;
                    for (int a = 0; a < n; a++)
                    {
                        Console.Write(a + increase + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Max size is 19!");
            }
        }
    }
}
