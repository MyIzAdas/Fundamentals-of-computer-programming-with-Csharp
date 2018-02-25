using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n to list [1...n]: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i=1; i<=n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
