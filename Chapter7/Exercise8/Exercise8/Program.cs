using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program sorts array");
            Console.Write("Please enter the length of array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Now enter the array values.");
            int []array=new int[n];
            for(int i=0;i<n;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Press 1 if you want to sort from lowest to highest value or press 2 if you want to sort from highest to lowest value.");
            int c = int.Parse(Console.ReadLine());

            //Sorting array
            int first = array[0];
            int smallInd = 0;
            int bump;
            for (int i=1;i<n;i++)
            {
                for(int j=i;j<n;j++) //finding lowest/highest value and its index in array
                {
                    switch (c)//Switch between lowest to highest and higest to lowest.
                    {
                        case 1:
                            if (first > array[j])
                            {
                                first = array[j];
                                smallInd = j;
                            }
                            break;
                        case 2:
                            if (first < array[j])
                            {
                                first = array[j];
                                smallInd = j;
                            }
                            break;
                    }
                }
                bump = array[i - 1]; //swapping values
                array[i - 1] = first;
                array[smallInd] = bump;
                first = array[i];
            }
            //printing
            for(int i=0;i<n;i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
