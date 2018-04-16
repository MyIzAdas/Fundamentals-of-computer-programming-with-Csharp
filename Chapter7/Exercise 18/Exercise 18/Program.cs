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
            Console.WriteLine("This program uses quick sort to sort array.");
            int[] arr = {6,4,2,7,3,0,1,8,9,5};
            Console.Write("Unsorted array: ");
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write("{0,3}", arr[i]);
            }
            QuickSort(arr,arr.Length-1);
            Console.WriteLine();
            Console.Write("Sorted array: ");
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write("{0,3}", arr[i]);
            }
            Console.WriteLine();
        }
        static public void QuickSort(int[]numbers,int pivot)
        {
            int index=0;
            int temp;
            while (index < pivot && pivot<numbers.Length)
            {
                if (numbers[pivot] < numbers[index])
                {
                    
                    temp = numbers[pivot - 1];
                    numbers[pivot - 1] = numbers[pivot];
                    pivot--;
                    if (pivot != index)
                    {
                        numbers[pivot + 1] = numbers[index];
                        numbers[index] = temp;
                    }
                    else
                    {
                        numbers[pivot + 1] = temp;
                    }
                }
                else
                {
                    index++;
                }
                if(index==pivot)
                {
                    int length = numbers.Length - 1;
                    if (numbers[length] < numbers[length - 1])
                    {
                        pivot = length + 1;
                    }
                    while (length>0 && numbers[length] >= numbers[length - 1])
                    {
                    pivot = length;
                    length--;
                    }
                    if (length != 0)
                    {
                        QuickSort(numbers, pivot - 1);
                    }
                }
            }
        }
    }
}
