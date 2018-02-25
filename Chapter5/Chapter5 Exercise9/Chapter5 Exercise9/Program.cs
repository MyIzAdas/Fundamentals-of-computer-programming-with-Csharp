using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5_Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I find sum of 0 from array of numbers.");
            int [] numbers = { 3, 22, -7, 3, 1 };
            double num0 = 0.1;
            double num1 = 0.1;
            double num2 = 0.1;
            double num3 = 0.1;
            double num4 = 0.1;
            for (int i=0;i<5;i++)
            {
                for(int n=1;n<5;n++)
                {
                    for(int a=2;a<5;a++)
                    {
                        for (int b=3;b<5;b++)
                        {
                            for (int c=4; c<5;c++)
                            {
                                if (numbers[i] + numbers[n] == 0)
                                {
                                    Console.WriteLine(numbers[i] + "+" + numbers[n] + "=0");
                                    num0 = numbers[i];
                                    num1 = numbers[n];
                                }
                                if (numbers[i] + numbers[n] + numbers[a] == 0)
                                {
                                    num0 = numbers[i];
                                    num1 = numbers[n];
                                    num2 = numbers[a];
                                }
                                if (numbers[i] + numbers[n] + numbers[a] + numbers[b] == 0)
                                {
                                    num0 = numbers[i];
                                    num1 = numbers[n];
                                    num2 = numbers[a];
                                    num3 = numbers[b];
                                }
                                if (numbers[i] + numbers[n] + numbers[a] + numbers[b] + numbers[c] == 0)
                                {
                                    num0 = numbers[i];
                                    num1 = numbers[n];
                                    num2 = numbers[a];
                                    num3 = numbers[b];
                                    num4 = numbers[c];
                                }
                            }
                        }
                    }
                }
            }
            if (num0 != 0.1)
            {
                Console.Write(num0+" ");
            }
            if (num1 != 0.1)
            {
                Console.Write(num1+" ");
            }
            if (num2 != 0.1)
            {
                Console.Write(num2+" ");
            }
            if (num3 != 0.1)
            {
                Console.Write(num3+" ");
            }
            if (num4 != 0.1)
            {
                Console.Write(num4);
            }
            Console.WriteLine();
        }
    }
}
