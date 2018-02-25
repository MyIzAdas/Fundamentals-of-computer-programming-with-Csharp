using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2_Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello ";
            string world = "World";
            object obj = hello + world;
            string comb = (string)obj;
            Console.WriteLine(comb);
        }
    }
}
