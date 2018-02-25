using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Position p: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Integer v: ");
            int v = Convert.ToInt32(Console.ReadLine());
            int check = 1 << p;
            bool isBit1 = (v & check) == 1;
            Console.WriteLine(isBit1+"! False ==0, True == 1");
        }
    }
}
