using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_20
{
    class Program
    {
        static int n;
        static int[] numbers;
        static int[] arr;
        static int s;
        static bool foundS = false;
        static void Main(string[] args)
        {
            Console.WriteLine("This program finds numbers that have sum of S within array");
            Console.Write("Please enter the size of your array: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Now enter values of the array.");
            arr = new int[n];
            for(int i=0;i<n;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Please enter the sum you want to find: ");
            s = int.Parse(Console.ReadLine());
            /*Calucaltion*/
            numbers = new int[n];
            if(n==1 && arr[0]==s)
            {
                Console.WriteLine(arr[0]+"="+s);
                foundS = true;
            }
            for (int i = 0; i <= n; i++)
            {
                RecursiveLoops(0,i);
            }
            if(foundS==false)
            {
                Console.WriteLine("The sum you are looking for was not found.");
            }
        }

        static void RecursiveLoops(int start,int scaling)
        {
            if (foundS == false)
            {
                if (start == scaling)
                {

                    Filter(scaling);
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        numbers[start] = i;
                        RecursiveLoops(start + 1, scaling);
                    }
                }
            }
        }

        static void Filter(int scaling)
        {
            int[] result = new int[n];
            int add = 0;
            int count = 0;
            int sum = 0;
                for (int i = 0; i < scaling; i++)
                {
                    for (int j = 0; j < scaling; j++)
                    {
                        if (numbers[i] != numbers[j])
                        {
                            count++;
                            if (count == scaling - 1)
                            {
                                sum = sum + arr[numbers[i]];
                                result[add] = arr[numbers[i]];
                                add++;
                                if (sum == s)
                                {
                                    foundS = true;
                                Print(add,result);
                                }
                            }
                        }
                    }
                    count = 0;
                }
        }

        static void Print(int add,int[]result)
        {
            for (int i = 0; i < add; i++)
            {
                Console.Write(result[i]);
                if (i < add - 1)
                    Console.Write("+");
            }
            Console.WriteLine("= " + s);
        }
    }
}
