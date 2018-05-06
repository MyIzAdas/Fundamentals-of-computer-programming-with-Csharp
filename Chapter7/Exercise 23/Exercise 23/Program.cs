using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_23
{
    class Program
    {
        static int k;
        static int[] arr;
        static void Main(string[] args)
        {
            Console.WriteLine("This program prints all variations of elements from 1 to max value.");
            Console.Write("Enter the number of values: ");
            k = int.Parse(Console.ReadLine());
            Console.Write("Enter the the maximum value: ");
            int n = int.Parse(Console.ReadLine());
            arr = new int[k];
            RecursiveVariatons(0,k, n);
        }
        static void RecursiveVariatons(int start,int k,int n)
        {
            if (start != k)
            {
                for (int i = 1; i <= n; i++)
                {
                    arr[start] = i;
                    RecursiveVariatons(start + 1, k, n);
                }
            }
            else
            {
                Print(k);
            }
        }
        static void Print(int n)
        {
            for(int i=0;i<n;i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
