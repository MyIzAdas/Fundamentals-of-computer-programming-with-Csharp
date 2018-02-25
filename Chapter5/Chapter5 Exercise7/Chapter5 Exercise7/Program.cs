using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5_Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter 5 numbers and I will print you the BIGGEST of them!");
            int num;
            int compNum = int.Parse(Console.ReadLine());
            int biggest;
            for (int i=0; i<4;i++)
            {
                num = int.Parse(Console.ReadLine());
                if(compNum>num)
                {
                    biggest = compNum;
                }
                else
                {
                    biggest = num;
                }
                compNum = biggest;
            }
            biggest = compNum;
            Console.WriteLine("The biggest number is "+ biggest);
        }
    }
}
