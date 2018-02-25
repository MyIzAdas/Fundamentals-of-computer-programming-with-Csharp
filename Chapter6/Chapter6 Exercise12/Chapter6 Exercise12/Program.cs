using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program converts decimal numbers to binary.");
            Console.Write("Please enter decimal number: ");
            int dec = int.Parse(Console.ReadLine());
            int quotient;
            List<int> outputList = new List<int>();
            if(dec==0)
            {
                Console.Write(0);
            }
            while (dec > 0)
            {
                quotient = dec / 2;
                outputList.Add(dec % 2);
                dec = quotient;
            }
            outputList.Reverse();
            foreach(var i in outputList)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
