using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program demosntrates use of merge sort.");
            Console.Write("Unsorted array values: ");
            int[] arr = {3,2,5,4,8,0,6,1,7,9};
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write("{0,3}",arr[i]);
            }
            MergeSort(arr,0,arr.Length-1);
            Console.WriteLine();
            Console.Write("Sorted array: ");
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write("{0,3}",arr[i]);
            }
            Console.WriteLine();
        }
        static public void MergeSort(int[] numbers, int left, int right)
        {
            int mid;
            if(right>left)
            {
                mid = (left + right) / 2;
                MergeSort(numbers,left,mid);
                MergeSort(numbers, mid + 1, right);
                Sort(numbers, left, mid + 1, right);
            }
        }
        static public void Sort(int []numbers, int left, int mid, int right)
        {
            int[] temp = new int[numbers.Length];
            int leftEnd = mid - 1;
            int tempPos = left;
            int loopNum = (right - left) + 1;
            while(left<=leftEnd && mid<=right)  //find lowest value
            {
                if(numbers[left]<=numbers[mid])
                { 
                    temp[tempPos++] = numbers[left++];
                }
                else
                {
                    temp[tempPos++] = numbers[mid++];
                }
            }
            while(left<=leftEnd)    //assign spare values
            {
                temp[tempPos++] = numbers[left++];
            }
           while(mid<=right)
            {
                temp[tempPos++] = numbers[mid++];
            }
           for(int i=0;i<loopNum;i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
    }
}
