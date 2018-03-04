using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program checks if 2 arrays are equal.");
            Console.Write("Please enter size of first array: ");
            int firstArraySize = int.Parse(Console.ReadLine());
            Console.Write("Please enter size of second array: ");
            int secondArraysize = int.Parse(Console.ReadLine());
            int equalNum = 0;//Number of equal arrays
            if (firstArraySize != secondArraysize)
            {
                Console.WriteLine("Both arrays are not equal.");
            }
            else
            {
                Console.WriteLine("Now enter values of first array: ");
                int[] firstArray = new int[firstArraySize];

                //Reading first array
                for (int i = 0; i < firstArraySize; i++)
                {
                    firstArray[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Now enter values of second array: ");
                int[] secondArray = new int[secondArraysize];

                //Reading second array
                for (int i = 0; i < secondArraysize; i++)
                {
                    secondArray[i] = int.Parse(Console.ReadLine());
                }

                //Checking
                for(int i=0;i<firstArraySize;i++)
                {
                    if(firstArray[i]==secondArray[i])
                    {
                        equalNum++;
                    }
                }
                if(equalNum==firstArraySize)
                {
                    Console.WriteLine("Both arrays are equal.");
                }
                else
                {
                    Console.WriteLine("Both arrays are not equal.");
                }
            }
        }
    }
}
