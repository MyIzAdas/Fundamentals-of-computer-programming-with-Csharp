using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program finds maximal sequence of consecutively placed increasing integers within array.");
            Console.Write("Please enter size of array: ");

            //Reading array
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Please enter array of int.");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int num = array[0];
            int seqLength = 0;
            int maxLength = 0;
            int cycleCounter = 0;
            int seqStart = 0;
            //finding maximal sequence of consecutively placed increasing integers within array
            for(int i=1;i<n;i++)
            {
                if(num+1==array[i])
                {
                    seqLength++;
                }
                else
                {
                    seqLength = 0;
                }
                if (seqLength > maxLength)
                {
                    maxLength = seqLength;
                    seqStart = cycleCounter;
                }
                num = array[i];
                cycleCounter++;
            }
            //Printing
            for(int i=seqStart-maxLength+1;i<seqStart+2;i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
