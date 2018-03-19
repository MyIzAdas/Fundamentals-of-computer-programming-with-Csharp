using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program finds most frequently occuring number in array.");
            Console.Write("How big is your array? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your array values");
            int[] arr = new int[n];
            for(int i=0;i<n;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int timesTrue = 0;
            //Finding most frequently used number
            int maxTrue = 0;
            int mostFreq=0;
            for(int i=0;i<n;i++)
            {
                for(int j=i+1;j<n;j++)
                {
                    if(arr[i]==arr[j])
                    {
                        timesTrue++;
                    }
                }
                if(timesTrue>maxTrue)
                {
                    mostFreq = arr[i];
                }
                timesTrue = 0;
            }
            Console.WriteLine("It's "+mostFreq+"!");
        }
    }
}
