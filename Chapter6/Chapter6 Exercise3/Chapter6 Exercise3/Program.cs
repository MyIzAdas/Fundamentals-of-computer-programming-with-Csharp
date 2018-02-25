using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of integers you want to enter.");
            int n = int.Parse(Console.ReadLine());
            int biggest=int.MinValue;
            int smallest=int.MaxValue;
            for (int i=0;i<n;i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(num>biggest)
                {
                    biggest = num;
                }
                if(num<smallest)
                {
                    smallest = num;
                }
            }
            Console.WriteLine("The biggest number is: "+biggest+" and the lowest number is: "+smallest);
        }
    }
}
