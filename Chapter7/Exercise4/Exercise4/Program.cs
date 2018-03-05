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
            int timesTrue = 0;
            int num = 0;
            int ttaInex = 0;
            Console.WriteLine("This program finds maximal sequence of consecutive equal elements within array.");
            Console.Write("Please enter size of array: ");

            //Reading array
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int[] timesTrueArray = new int [n];
            int[] numArray = new int[n];

            Console.WriteLine("Please enter array of int.");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //finding consecutive equal elements within array
            for(int i=0;i<n;i++)
            {
                int a = i;
                if(i==n-1)
                {
                    a--;
                }
                if(array[a]==array[a+1])
                {
                    timesTrue++;
                    num = array[a];
                }
                else if(timesTrue>0)
                {
                    ttaInex++;
                    timesTrueArray[ttaInex-1] = timesTrue;//number of equal numbers -1 per area
                    numArray[ttaInex - 1] = num;//stores value of area
                    timesTrue = 0;
                }
            }
            int mostSameI = 0;
            int valueInd = 0;
            for(int i=0;i<ttaInex;i++)
            {

                mostSameI = Math.Max(mostSameI, timesTrueArray[i]);
                if(mostSameI==timesTrueArray[i])
                {
                    valueInd = i;
                }
            }

            //Printing
            for(int i=0;i<mostSameI+1;i++)
            {
                Console.Write(numArray[valueInd]);
            }
            Console.WriteLine();
        }
    }
}
