using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter spiral matrix size.");
            Console.Write("Size: ");
            int n = int.Parse(Console.ReadLine());
            int[,] array2D = new int[n,n];
            int mem = n;
            int start = 0;
            int num = 1;
            
            //Create matrix
            while(mem-start>=1)
            {
                for(int i=start;i<mem;i++)
                {
                    array2D[start, i] = num;
                    num++;
                }
                for(int a=start+1;a<mem;a++)
                {
                    array2D[a, mem - 1] = num;
                    num++;
                }
                for(int b=mem-2;b>=start;b--)
                {
                    array2D[mem - 1, b] = num;
                    num++;
                }
                for(int c=mem-2;c>start;c--)
                {
                    array2D[c, start]=num;
                    num++;
                }

                mem--;
                start++;
            }

            //Print matrix
            for(int i=0;i<n;i++)
            {
                for(int a=0;a<n;a++)
                {
                    Console.Write("{0,3}", array2D[i, a]);
                }
                Console.WriteLine();
            }
        }
    }
}
