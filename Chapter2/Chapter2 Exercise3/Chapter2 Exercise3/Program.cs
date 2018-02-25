using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            Console.WriteLine("a= ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            b = float.Parse(Console.ReadLine());
            if (a>b)
            {
                Console.WriteLine("A is more than B "+a+" > "+b);
            }
            if (a<b)
            {
                Console.WriteLine("B is more than A "+b+" > "+a);
            }
            if (a==b)
            {
                Console.WriteLine("A and B are equal "+a+" = "+b);
            }
        }
    }
}
