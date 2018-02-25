using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers you want to add up? ");
            int n = int.Parse(Console.ReadLine());
            int num;
            int sum = 0;
            Console.WriteLine("Enter " + n + " numbers");
            for(int i=0;i<n;i++)
            {
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine("Sum is: " + sum);
        }
    }
}
