using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This programs uses binary search in the sorted array of integer elements.");
            Console.Write("Please enter the number you want to find in array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = {19,12,55,4,8,10,31,18,26,97 };
            int lowest = int.MaxValue;
            int mem = 0;
            int iLow = 0;
            bool found = false;
            for(int i=0;i<arr.Length;i++) //Sorting
            {
                for(int j=i;j<arr.Length;j++)
                {
                   if(arr[j]<lowest)
                    {
                        lowest = arr[j];
                        iLow = j;
                    }
                }
                mem = arr[i];
                arr[i] = lowest;
                arr[iLow] = mem;
                lowest = int.MaxValue;
                Console.WriteLine(arr[i]);
            }

            //Binary search
            int divisor = arr.Length/2;
            int count = 0;
            while (found == false && count<=arr.Length)
            {
                if (arr[divisor] == n)
                {
                    found = true;
                }
                else if (arr[divisor] > n)
                {
                    divisor = divisor / 2;
                }
                else if(arr.Length/2<n)
                {
                    divisor = divisor / 2 + arr.Length/2;
                }
                else
                {
                    divisor = ((arr.Length / 2) + divisor)/2;
                }
                count++;
            }
            
            //Print
            if(found)
            {
                Console.WriteLine(n + " was found.");
            }
            else
            {
                Console.WriteLine(n + " wansn't found.");
            }
        }
    }
}
