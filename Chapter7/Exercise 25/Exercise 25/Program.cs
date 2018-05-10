using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_25
{
    class Program
    {
        static int x = 5;
        static int y = 6;
        static void Main(string[] args)
        {
            Console.WriteLine("This program finds larger area with equal numbers within the matrix.");
            int[,] matrix = new int[,]
          { {1,3,2,2,2,4 },
            {3,3,3,2,4,4 },
            {4,3,1,2,3,3 },
            {4,3,1,3,3,1 },
            {4,3,3,3,1,1 } };

            for (int i=0;i<x;i++) //Print matrix
            {
                for(int j=0;j<y;j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            FindMostNum(matrix);
        }

        static void FindMostNum(int[,] matrix)
        {
            int[] jPos=new int[x*y];
            int[] iPos=new int [x*y];
            bool cycling;
            int number;
            int biggest = 0;
            int count = 0;
            int bigCount = 0;
            int mostCommonNumber=0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    cycling = true;
                    number = matrix[i, j];
                    jPos[count] = j;
                    iPos[count] = i;
                    while (cycling)
                    {
                        bool addPI = false;
                        bool addMI = false;
                        bool addPJ = false;
                        bool addMJ = false;
                        int works = 0;
                        if (iPos[count] + 1 < x && matrix[iPos[count], jPos[count]] == matrix[iPos[count] + 1, jPos[count]])
                       {
                            for (int a = 0; a < bigCount + 1; a++)
                            {
                                if (iPos[a]==iPos[count]+1&& jPos[a]==jPos[count])
                                {
                                    addPI = true;
                                }
                            }
                            if (addPI==false)
                            {
                                count++;
                                bigCount++;
                                jPos[bigCount] = jPos[count - 1];
                                iPos[bigCount] = iPos[count - 1] + 1;
                                addPI = true;
                                works++;
                            }
                       }
                        if (iPos[count]-1>=0&&matrix[iPos[count], jPos[count]] == matrix[iPos[count] - 1, jPos[count]])
                        {
                            for (int a = 0; a < bigCount + 1; a++)
                            {
                                if (iPos[a] == iPos[count] - 1 && jPos[a] == jPos[count])
                                {
                                    addMI = true;
                                }
                            }
                            if (addMI == false)
                            {
                                count++;
                                bigCount++;
                                jPos[bigCount] = jPos[count - 1];
                                iPos[bigCount] = iPos[count - 1] - 1;
                                addMI = true;
                                works++;
                            }
                        }
                         if (jPos[count] + 1<y&&matrix[iPos[count], jPos[count]] == matrix[iPos[count], jPos[count] +1])
                        {
                            for (int a = 0; a < bigCount + 1; a++)
                            {
                                if (iPos[a] == iPos[count] && jPos[a] == jPos[count]+1)
                                {
                                    addPJ = true;
                                }
                            }
                            if (addPJ == false)
                            {
                                count++;
                                bigCount++;
                                jPos[bigCount] = jPos[count - 1] + 1;
                                iPos[bigCount] = iPos[count - 1];
                                addPJ = true;
                                works++;
                            }
                        }
                         if (jPos[count] - 1>=0&&matrix[iPos[count], jPos[count]] == matrix[iPos[count], jPos[count] -1])
                        {
                            for (int a = 0; a < bigCount + 1; a++)
                            {
                                if (iPos[a] == iPos[count] && jPos[a] == jPos[count]-1)
                                {
                                    addMJ = true;
                                }
                            }
                            if (addMJ == false)
                            {
                                count++;
                                bigCount++;
                                jPos[bigCount] = jPos[count - 1] - 1;
                                iPos[bigCount] = iPos[count - 1];
                                addMJ = true;
                                works++;
                            }
                        }
                        if(works==0)
                        {
                            count--;
                            if (count < 0)
                            {
                                cycling = false;
                            }
                        }
                        else
                        {
                            count = bigCount;
                        }
                    }
                    if(biggest<bigCount)
                    {
                        biggest = bigCount+1;
                        mostCommonNumber = number;
                    }
                    bigCount = 0;
                    count = 0;
                }
            }
            Console.WriteLine("Most common connected number is " + mostCommonNumber + " there are " + biggest + " of this number.");
        }
    }
}
