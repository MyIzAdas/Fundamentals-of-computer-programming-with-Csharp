using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program finds the longest string sequence within matrix.");
            string[,] arr = {
                {"h","au","h","h","ia" },
                {"ai","ai","ai","ai","ai" },
                {"c","h","ia","au","b" },
                {"d","if","a","f","c" }
            };
            int m = arr.GetLength(1);
            int n = arr.GetLength(0);

            //Calculation
            int lineLength = 0;
            int length = 0;
            int drdLength = 0;
            int rowLength = 0;
            int maxLength = 0;
            int druLength = 0;
            int iStart = 0;
            int jStart = 0;
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    if (j < m - 1)
                    {
                        if (arr[i, j] == arr[i, j + 1]) //lines
                        {
                            lineLength = 1;
                            while (j + lineLength < m - 1 && arr[i, j + lineLength] == arr[i, j + lineLength + 1])
                            {
                                lineLength++;
                            }
                        }
                    }
                    if (i < n - 1)
                    {
                        if (arr[i, j] == arr[i + 1, j]) //rows
                        {
                            rowLength = 1;
                            while (i + rowLength < n - 1 && arr[i + rowLength, j] == arr[i + rowLength + 1, j])
                            {
                                rowLength++;
                            }
                        }
                    }

                    if (j < m - 1 && i < n - 1)
                    {
                        if (arr[i, j] == arr[i + 1, j + 1])//diagonal right down
                        {
                            drdLength = 1;
                            while (j + drdLength < m - 1 && i + drdLength < n - 1 && arr[i + drdLength, j + drdLength] == arr[i + drdLength+1, j + drdLength+1])
                            {
                                drdLength++;
                            }
                        }
                    }

                    if (j < m - 1 && i >0)
                    {
                        if (arr[i, j] == arr[i - 1, j + 1])//diagonal right up
                        {
                            druLength = 1;
                            while(j+druLength<m-1 && i-druLength>0 && arr[i-druLength,j+druLength]==arr[i-druLength-1,j+druLength+1])
                            {
                                druLength++;
                            }
                        }
                    }
                    length = Math.Max(Math.Max(Math.Max(rowLength, lineLength),drdLength),druLength);
                    
                    if (length > maxLength)
                    {
                        maxLength = length; //longest sequence
                        iStart = i;         //longest sequence first value i index
                        jStart = j;         //longest sequence first value j index
                    }
                    lineLength = 0;
                    rowLength = 0;
                    drdLength = 0;
                    druLength = 0;
                }
            }

            //Printing
            Console.WriteLine("2D Array:");
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    Console.Write("{0,3}", arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Longest sequence is: ");
            for(int i=0;i<maxLength+1;i++)
            {
                Console.Write("{0,3}",arr[iStart, jStart]);
            }
            Console.WriteLine();
        }
    }
}
