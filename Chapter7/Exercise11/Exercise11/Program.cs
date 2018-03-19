using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program finds sum of certain number S.");
            Console.Write("How big is your array? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your array values.");
            int[] arr = new int[n];
            for(int i=0;i<n;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter your sum: ");
            int s = int.Parse(Console.ReadLine());

            //finding array numbers
            int sum = 0;
            int[] numbers = new int[n];
            int index = 0;
            int[] result = new int[n];
            int maxInd = 0;
            for(int i=0;i<n;i++)
            {
               for(int j=i;j<n;j++)
                {
                    numbers[index] = arr[j];
                    sum = sum + arr[j];
                    if(sum==s)
                    {
                        maxInd = index;
                        int counter = 0;
                        while(maxInd+1>counter)
                        {
                            result[counter] = numbers[counter];
                                counter++;
                        }
                    }
                    index++;
                }
                sum = 0;
                index = 0;
            }
            Console.Write(s + " is equal to the sum of these numbers ");
            for(int i=0;i<maxInd+1;i++)
            {
                Console.Write(result[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
