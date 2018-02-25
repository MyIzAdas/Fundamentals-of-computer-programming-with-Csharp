using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bit value: ");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bit position: ");
            int p = Convert.ToInt32(Console.ReadLine());
            int bitCheck = 1 << p;
            if (v == 1)
            {
                Console.WriteLine(n | bitCheck);
            }
            else
            {
                Console.WriteLine(n ^ bitCheck);
            }
            
        }
    }
}
