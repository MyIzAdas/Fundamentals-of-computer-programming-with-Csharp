using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int primeCheck=0;
            for(int i=2;i<100;i++)
            {
                if ((n % i != 0) || n==i)
                {
                    primeCheck =primeCheck+ 1;
                }
            }
            Console.WriteLine(primeCheck==98 ? "Prime number":"Not prime number");
        }

    }
}
