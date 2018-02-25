using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n value for 0-n sum of fibonaci sequence.");
            int n = int.Parse(Console.ReadLine());
            int num1 = 0;
            int num2=0;
            int sum = 0;
            for (int i=0;i<n;i++)
            {
                if(i<=1)
                {
                    num1 = i;
                }
                int fib=num1+num2;
                Console.WriteLine(fib);
                num1 = num2;
                num2 = fib;
                sum = sum + fib;
                
            }
                Console.WriteLine("The sum is equal to: " + sum);
        }
    }
}
