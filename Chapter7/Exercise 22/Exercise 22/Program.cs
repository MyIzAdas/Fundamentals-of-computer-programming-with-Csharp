using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program finds the longest ascending sequence in array and prints it.");
            Console.Write("Enter the size of your array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Now enter values of your array.");
            int[] arr = new int[n];
            for(int i=0;i<n;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int maxLength = 1;
            int length = 0;
            int biggerCount = 0;
            int mover = 0;
            int[] result = new int[n];
            while (maxLength != 0)
            {
                maxLength = -1;
                for (int i = mover; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (arr[i] <= arr[j])
                        {
                            length++;
                        }
                    }
                    if (length > maxLength && biggerCount==0)
                    {
                        result[biggerCount] = arr[i];
                        mover = i+1;
                        maxLength = length;
                    }
                    if (length > maxLength && arr[i]>=result[biggerCount-1])
                    {
                        result[biggerCount] = arr[i];
                        mover = i + 1;
                        maxLength = length;
                    }
                    length = 0;
                }
                biggerCount++;
            }
            //Print
            for(int i=0;i<biggerCount;i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
