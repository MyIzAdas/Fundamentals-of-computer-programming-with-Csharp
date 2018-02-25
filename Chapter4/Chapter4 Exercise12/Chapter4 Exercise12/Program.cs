using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 1d;
            double newSum=0;
            int i = 1;
            while (Math.Abs(sum-newSum)>0.001)
            {
                newSum = sum;
                i = i + 1;
                if (i % 2 == 0)
                {
                    sum = sum + (1 / (double)i);
                }
                else
                {
                    sum = sum - (1 / (double)i);
                }
            }
            Console.WriteLine("{0:F3}",sum);
        }
    }
}
