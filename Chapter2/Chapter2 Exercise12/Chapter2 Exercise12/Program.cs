using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2_Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("a: "+a+" b: "+b);
            int na = b;
            int nb = a;
            a = na;
            b = nb;
            Console.WriteLine("a: " + a + " b: " + b);
        }
    }
}
