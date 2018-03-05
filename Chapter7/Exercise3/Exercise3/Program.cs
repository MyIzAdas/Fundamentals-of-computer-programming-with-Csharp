using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 2 char arrays to compare their values lexicographically");
            Console.Write("Please enter size of the first array: ");

            //Reading first array
            int firstArraySize = int.Parse(Console.ReadLine());
            char[] firstArray = new char[firstArraySize];
            Console.WriteLine("Please enter first char array.");
            char firstChar = 'a';
            for (int i=0; i<firstArraySize; i++)
            {
                firstArray[i] = char.Parse(Console.ReadLine());
            }

            //Reading second array
            Console.Write("Please enter size of second array");
            int secondArraysize = int.Parse(Console.ReadLine());
            char[] secondArray = new char[secondArraysize];
            Console.WriteLine("Please enter second char array");
            for (int i = 0; i < secondArraysize; i++)
            {
                secondArray[i] = char.Parse(Console.ReadLine());
            }

            //Comparing arrays
            for(int i=0;i<firstArraySize;i++)
            {
                for(int n=0;n<secondArraysize;n++)
                {
                    if(firstArray[i]>secondArray[n])
                    {
                        firstChar = secondArray[n];
                    }
                    else
                    {
                        firstChar = firstArray[i];
                    }
                }
            }
            Console.WriteLine("First char is: " + firstChar);
        }
    }
}
