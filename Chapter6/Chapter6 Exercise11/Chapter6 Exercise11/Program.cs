using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter int value");
            int n = int.Parse(Console.ReadLine());
            long fact = 1;
            int zeroCount = 0;
            int divisor = 10;
            for(int i=1;i<=n;i++)
            {
                fact = fact * i;
            }
            while(fact%divisor==0)
            {
                divisor = divisor * 10;
                zeroCount++; 
            }
            Console.WriteLine(fact + " has " + zeroCount + " zero's at the end.");
        }
    }
}
