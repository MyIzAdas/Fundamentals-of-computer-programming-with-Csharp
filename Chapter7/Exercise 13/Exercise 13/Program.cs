using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program finds maximal 3x3 sum in 2D array.");
            Console.Write("Number of lines: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Number of columns: ");
            int c = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, c];
            Console.WriteLine("Now please enter your 2D array values.");
            int[,] scanArr = new int[3, 3];
            int[,] maxArr = new int[3, 3];

            //building array
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Calculation
            int sum = 0;
            int iAdd = 0;
            int jAdd = 0;
            int maxSum = 0;
            for (int k = 0; k < (c - 2) * (n - 2); k++)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                            scanArr[i, j] = arr[i+iAdd, j+jAdd];//scanning arr with scanArr
                            sum = sum + scanArr[i, j];//and checking it's 3x3 sum
                    }
                }
                if(sum>maxSum)//Storing max array
                {
                    for(int i=0;i<3;i++)
                    {
                        for(int j=0;j<3;j++)
                        {
                            maxArr[i,j]= scanArr[i,j];
                        }
                    }
                    maxSum = sum;
                }
                if(iAdd<n-3)
                {
                    iAdd++;
                }
                else
                {
                    iAdd = 0;
                    jAdd++;
                }
                sum = 0;
            }

            //Printing
            Console.WriteLine("Your array:");
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<c;j++)
                {
                    Console.Write("{0,3}",arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Max 3x3 array:");
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write("{0,3}", maxArr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("With a sum of " + maxSum);
        }
    }
}
