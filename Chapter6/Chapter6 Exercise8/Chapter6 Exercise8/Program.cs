using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter n value for Catalan number calculation");
            int n = int.Parse(Console.ReadLine());
            int Factorial(int a)
            {
                int fact = 1;
                for(int i=1;i<=a;i++)
                {
                    fact = fact * i;
                }
                return fact;
            }
            Console.WriteLine("Catalan number: "+Factorial(2*n)/(Factorial(n+1)*Factorial(n)));
        }
    }
}
