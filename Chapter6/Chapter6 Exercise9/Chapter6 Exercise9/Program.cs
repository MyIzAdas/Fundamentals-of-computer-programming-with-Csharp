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
            Console.WriteLine("Please enter n and x values to calculate the sum of 1+(1!/x)+(2!/x^2)+...+(n!/x^n)");
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("x= ");
            int x = int.Parse(Console.ReadLine());
            double sum = 1;
            int Factorial(int a) //Calculates factorial.
            {
                int fact =1;
                for(int i=1;i<=a;i++)
                {
                    fact = fact * i;
                }
                return fact;
            }
            for(int i=1;i<=n;i++)
            {
                sum = sum + (Factorial(i) / Math.Pow(x,i));
            }
            Console.WriteLine("Sum= "+sum);
        }
    }
}
