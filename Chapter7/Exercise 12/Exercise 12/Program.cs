using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program makes different number sequences in square matrices.");
            Console.WriteLine("What is the size of your matrix?");
            int n = int.Parse(Console.ReadLine());
            int[,] arrA = new int[n, n];
            int[,] arrB = new int[n, n];
            int[,] arrC = new int[n, n];
            int[,] arrD = new int[n, n];
            int add = 1;

            //calculation for A
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    arrA[j, i] = add;
                    add++;
                }
            }

            //calculation for B
            add = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 0)
                    {
                        arrB[j, i] = add;
                    }
                    else
                    {
                        arrB[n-1-j, i] = add;
                    }
                    add++;
                }
            }

            //calculation for C
            add = 1;
            int x = n - 1;
            int y = 0;
            int mem = 0;
            int memY = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arrC[x, y] = add;
                    add++;
                    if(y==n-1)
                    {
                        memY++;
                        x = 0;
                        y = memY;
                    }
                    else if (x == n - 1)
                    {
                        y = 0;
                        x =x- mem - 1;
                        mem++;
                    }
                    else if(x<n-1 || y<n-1)
                    {
                        y++;
                        x++;
                    }
                }
            }

            //calculation for D
            x = 1;
            y = n-1;
            add = 1;
            int counter = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (add<=n)
                    {
                        arrD[j, i] = add;
                    }
                    else
                    {
                        arrD[y, x] = add;
                        if (y == n - counter && x < n - counter)
                        {
                            x++;
                        }
                        else if (x == n - counter && y > counter-1)
                        {
                            y--;
                        }
                        else if (y == counter-1 && x > counter)
                        {
                            x--;
                        }
                        else if(x==counter && y<n-counter-1)
                        {
                            y++;
                            if (n - counter-1 == y)
                            {
                                counter++;
                            }
                        }

                    }
                    add++;
                }
            }

            //printing A
            Console.WriteLine("A)");
            for (int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.Write("{0,3}",arrA[i, j]);
                }
                Console.WriteLine();
            }

            //printing B
            Console.WriteLine();
            Console.WriteLine("B)");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", arrB[i, j]);
                }
                Console.WriteLine();
            }

            //printing C
            Console.WriteLine();
            Console.WriteLine("C)");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", arrC[i, j]);
                }
                Console.WriteLine();
            }

            //printing D
            Console.WriteLine();
            Console.WriteLine("D)");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", arrD[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
