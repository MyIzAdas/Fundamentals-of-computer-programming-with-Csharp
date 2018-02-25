using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 4 digit number and press \"Enter\"");
            int num = Convert.ToInt32(Console.ReadLine()) ;
            int a = num / 1000;
            int b = num / 100%10;
            int c = num / 10%10;
            int d = num % 10;
            Console.WriteLine(a+b+c+d+" "+d+c+b+a+" "+d+a+b+c+" "+a+c+b+d);
        }
    }
}
