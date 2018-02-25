using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1_Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("What is your age?: ");
            age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age in 10 years will be: "+(age+10));
        }
    }
}
