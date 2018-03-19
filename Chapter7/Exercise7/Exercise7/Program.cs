using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int sum = 0;
            int maxSum = int.MinValue;

            Console.Write("Please enter the number of values your array has: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter the number of values you want to add up: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Now enter your array values.");
            int[] array = new int[n];
            for(int i=0;i<n;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //Finding k numbers max sum
            for(int i=0; i<=n-k;i++)
            {
                for(int j=i;j<k+i;j++)
                {
                    sum = sum + array[j];
                }
                if(sum>maxSum)
                {
                    maxSum = sum;
                }
                sum = 0;
            }
            Console.WriteLine("Biggest sum of " + k + " consecutive numbers is " + maxSum); //printing
        }
    }
}
