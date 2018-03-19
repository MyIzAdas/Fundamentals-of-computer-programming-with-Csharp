using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program finds subsequence of numbers with maximal sum.");
            Console.Write("Please enter length of your array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Now enter values of your array.");
            int[] array = new int[n];
            for(int i=0;i<n;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //finding sequence of numbers with max sum
            int[] indArr = new int[n];
            int sum = 0;
            int cyclCount = 0;
            int maxSum = int.MinValue;
            int maxInd = 0;
            int index = 0;
            int[] result = new int[n];
            for(int i=0;i<n;i++)
            {
                for(int j=i;j<n;j++)
                {
                    for(int a=i;a<n-cyclCount;a++)
                    {
                        sum = sum + array[a];
                        indArr[index] = a;
                        index++;
                    }
                    cyclCount++;
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxInd = index;
                        int counter = 0;
                        while (counter < maxInd)
                        {
                            result[counter] = indArr[counter];
                            counter++;
                        }
                    }
                    sum = 0;
                    index = 0;
                }
                cyclCount = 0;
            }
            Console.Write("Maximal sum is equal to "+maxSum+" and it is made by summing up these numbers: ");
            for(int i=0;i<maxInd;i++)
            {
                Console.Write(array[result[i]] + " ");
            }
            Console.WriteLine();
        }
    }
}
