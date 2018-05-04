using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program shows prime numbers in the range of 1 to 10000000");
            bool prime = true;
            for(int i=1;i<=10000000;i++)
            {
                for(int j=2;j<i;j++)
                {
                    if(i%j==0)
                    {
                        prime = false;
                    }
                }
                if(prime)
                {
                    Console.Write(i + " ");
                }
                prime = true;
            }
        }
    }
}
