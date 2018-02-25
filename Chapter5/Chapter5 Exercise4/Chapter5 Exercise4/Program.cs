using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5_Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers to sort them from highest to lowest value.");
            double num0 = double.Parse(Console.ReadLine());
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            if(num0>num1)
            {
                if(num0>num2)
                {
                    if(num1>num2)
                    {
                        Console.WriteLine(num0+" "+num1+" "+num2);
                    }
                    else
                    {
                        Console.WriteLine(num0 + " " + num2 + " " + num1);
                    }
                }
                else
                {
                    Console.WriteLine(num2 + " " + num0 + " " + num1);
                }
            }
            else
            {
                if (num1 > num2)
                {
                    if (num0 > num2)
                    {
                        Console.WriteLine(num1 + " " + num0 + " " + num2);
                    }
                    else
                    {
                        Console.WriteLine(num1 + " " + num2 + " " + num0);
                    }
                }
                else
                {
                    Console.WriteLine(num2+" "+num1+" "+num0);
                }
            }
        }
    }
}
