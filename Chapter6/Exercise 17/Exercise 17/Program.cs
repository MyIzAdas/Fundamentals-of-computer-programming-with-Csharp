using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a and b values to find GCD and LCM");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int gcd = 0;
            
            //Greatest common divisor
            for(int i=1;i<=Math.Max(a,b);i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    gcd=i;
                }
            }

            //Least common multiple
            if(a<0)
            {
                a = a * -1;
            }
            if(b<0)
            {
                b = b * -1;
            }
            int lcm = (a * b) / gcd;
            Console.WriteLine("Greatest common divisor: " + gcd);
            Console.WriteLine("Least common multiple: " + lcm);
        }
    }
}
