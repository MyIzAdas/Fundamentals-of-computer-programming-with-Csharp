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
            Console.WriteLine("Please enter binary number to convert it to decimal.");
            string n = Console.ReadLine();
            int num=0;
            int oneOrZero = 0;
            int strLenght = n.Length;
            for(int i= 0; i< n.Length; i++)
            {
                strLenght--;
               if(Convert.ToInt32(n[i])==49)
                {
                    oneOrZero = 1;
                }
               if(Convert.ToInt32(n[i])==48)
                {
                    oneOrZero = 0;
                }
                num =num + (oneOrZero * Convert.ToInt32(Math.Pow(2, strLenght)));
            }
            Console.WriteLine(num);
        }
    }
}
