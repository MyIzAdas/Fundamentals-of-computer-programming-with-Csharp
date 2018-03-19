using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reading array
            Console.WriteLine("This program finds maximal sequence of increasing elements in an array");
            Console.Write("Please enter the length of array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Now please enter values of array.");
            int[] arr = new int [n+1];
            
            for (int i=0;i<n;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }  
            int first = arr[0];
            int[] Seq = new int[n+1];
            int maxSeq = 0;
            int seq = 1;
            int[] result = new int[n];
            for(int i=0;i<n;i++) //Set all Seq array values to lowest
            {
                Seq[i] = int.MinValue;
            }
            //Finding maximal sequence of increasing elements in an array
            for(int i=1;i<n+1;i++)
            {
                for (int j = i; j < n+1; j++)
                {
                    if(first > Seq[seq-1])
                    {
                        Seq[seq] = first;
                        seq++;
                    }
                    else
                    {
                        if (seq >= 2)
                        {
                            if (Seq[seq - 2] < first && Seq[seq-1]>=first)
                            {
                                Seq[seq - 1] = first;
                            }
                        }
                    }
                    if(first==0)        //If there's a zero in array
                    {
                        Seq[seq - 1] = 0;
                    }
                    first = arr[j];
                }

                if (arr[n - 1]>Seq[seq-1])  //To use last number in array
                {
                    Seq[seq] = arr[n - 1];
                    seq++;
                }
                    if (maxSeq<seq)
                {
                    maxSeq = seq;
                    for(int x=0;x<maxSeq-1;x++)
                    {
                        result[x] = Seq[x + 1];
                    }
                }
                for (int xo = 0; xo < n; xo++)  //Reset all array Seq values to lowest
                {
                    Seq[xo] = int.MinValue;
                }
                first = arr[i];
                seq = 1;
                    }
      //Priting
        for(int i=0;i<maxSeq-1;i++)
            {
                Console.Write(result[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
